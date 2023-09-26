/*
 *  Copyright 2012 Tamme Schichler <tammeschichler@googlemail.com>
 * 
 *  This file is part of TQ.Texture.
 *
 *  TQ.Texture is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  TQ.Texture is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with TQ.Texture.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MediaExtractorLibrary.GDImageLibrary
{
    /// <summary>
    /// A texture.
    /// </summary>
    class Texture
    {
        private const string Header = "TEX";

        /// <summary>
        /// Creates a new texture instance.
        /// </summary>
        /// <param name="version">The file format version.</param>
        /// <param name="fps">The framerate of an animated texture.</param>
        /// <param name="frames">The texture's frame data.</param>
        public Texture(byte version = 1, int fps = 0, byte[][] frames = null)
        {
            Version = version;
            Fps = fps;
            Frames = frames;
        }

        /// <summary>
        /// The file format version.
        /// </summary>
        public byte Version { get; set; }

        /// <summary>
        /// The framerate of an animated texture.
        /// </summary>
        public int Fps { get; set; }

        /// <summary>
        /// The texture's frame data.
        /// </summary>
        public byte[][] Frames { get; set; }

        /// <summary>
        /// Parses a texture from a buffer.
        /// </summary>
        /// <param name="buffer">The buffer containing the texture.</param>
        /// <param name="offset">The position of the texture in buffer.</param>
        /// <returns>A new Texture instance containing the data read from buffer.</returns>
        public static Texture ParseTexture(byte[] buffer, int offset = 0)
        {

            var stream = new MemoryStream(buffer, offset, buffer.Length - offset);
            var reader = new BinaryReader(stream);

            if (Encoding.ASCII.GetString(reader.ReadBytes(3)) != Header)
            {
                throw new ArgumentException("Wrong Header!");
            }

            byte version = reader.ReadByte();
            int fps = reader.ReadInt32();

            var frames = new List<byte[]>();
            while (stream.Position < stream.Length)
            {
                int framelength = reader.ReadInt32();
                frames.Add(reader.ReadBytes(framelength));
            }

            var texture = new Texture(version, fps, frames.ToArray());
            return texture;
        }

        /// <summary>
        /// Returns the texture's data in a form that can be written to disk.
        /// </summary>
        /// <returns>The texture's data.</returns>
        public byte[] GetBytes()
        {
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);

            writer.Write(Encoding.ASCII.GetBytes(Header));
            writer.Write(Version);
            writer.Write(Fps);
            foreach (var frame in Frames)
            {
                writer.Write(frame.Length);
                writer.Write(frame);
            }

            return stream.ToArray();
        }
    }
}