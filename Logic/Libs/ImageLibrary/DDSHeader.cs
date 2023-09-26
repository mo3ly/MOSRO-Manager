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
using System.IO;

namespace MediaExtractorLibrary.GDImageLibrary
{
    class DDSHeader
    {
        public const int DefaultSize = 124;
        public uint Size { get; set; }
        public DDSHeaderFlags Flags { get; set; }
        public uint Height { get; set; }
        public uint Width { get; set; }
        public uint LinearSize { get; set; }
        public uint Depth { get; set; }
        public uint MipmapCount { get; set; }
        public uint[] Reserved1 { get; set; } //x11
        public DDSPixelFormat PixelFormat { get; set; }
        public DDSCaps Caps { get; set; }
        public DDSCaps2 Caps2 { get; set; }
        public uint Caps3 { get; set; }
        public uint Caps4 { get; set; }
        public uint Reserved2 { get; set; }

        public static DDSHeader Parse(byte[] buffer, int offset = 0)
        {
            int length = buffer.Length - offset;
            var stream = new MemoryStream(buffer, offset, length);
            var reader = new BinaryReader(stream);

            var header = new DDSHeader { Size = reader.ReadUInt32() };
            if (header.Size != DefaultSize)
            {
                throw new ArgumentException("Wrong Header Size!");
            }
            header.Flags = (DDSHeaderFlags) reader.ReadUInt32();
            header.Height = reader.ReadUInt32();
            header.Width = reader.ReadUInt32();
            header.LinearSize = reader.ReadUInt32();
            header.Depth = reader.ReadUInt32();
            header.MipmapCount = reader.ReadUInt32();
            header.Reserved1 = new uint[11];
            for (int i = 0; i < header.Reserved1.Length; i++)
            {
                header.Reserved1[i] = reader.ReadUInt32();
            }

            header.PixelFormat = DDSPixelFormat.Parse(reader.ReadBytes(32));
            header.Caps = (DDSCaps) reader.ReadUInt32();
            header.Caps2 = (DDSCaps2) reader.ReadUInt32();
            header.Caps3 = reader.ReadUInt32();
            header.Caps4 = reader.ReadUInt32();
            header.Reserved2 = reader.ReadUInt32();

            return header;
        }

        public byte[] GetBytes()
        {
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);

            writer.Write(Size);
            writer.Write((uint) Flags);
            writer.Write(Height);
            writer.Write(Width);
            writer.Write(LinearSize);
            writer.Write(Depth);
            writer.Write(MipmapCount);
            foreach (uint item in Reserved1)
            {
                writer.Write(item);
            }
            writer.Write(PixelFormat.GetBytes());
            writer.Write((uint) Caps);
            writer.Write((uint) Caps2);
            writer.Write(Caps3);
            writer.Write(Caps4);
            writer.Write(Reserved2);

            return stream.ToArray();
        }
    }
}