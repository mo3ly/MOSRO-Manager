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
using System.Text;

namespace MediaExtractorLibrary.GDImageLibrary
{
    class DDSPixelFormat
    {
        public const uint DefaultSize = 32;
        public uint Size { get; set; }
        public DDSPixelFlags Flags { get; set; }
        public string FourCC { get; set; } // 4 Bytes
        public uint RGBBitCount { get; set; }
        public uint RBitMask { get; set; }
        public uint GBitMask { get; set; }
        public uint BBitMask { get; set; }
        public uint ABitMask { get; set; }

        public static DDSPixelFormat Parse(byte[] buffer, int offset = 0)
        {
            int length = buffer.Length - offset;
            var stream = new MemoryStream(buffer, offset, length);
            var reader = new BinaryReader(stream);

            var pixelFormat = new DDSPixelFormat { Size = reader.ReadUInt32() };

            if (pixelFormat.Size != DefaultSize)
            {
                throw new ArgumentException("Invalid PixelFormat Size!");
            }
            pixelFormat.Flags = (DDSPixelFlags) reader.ReadUInt32();
            pixelFormat.FourCC = Encoding.ASCII.GetString(reader.ReadBytes(4));
            pixelFormat.RGBBitCount = reader.ReadUInt32();
            pixelFormat.RBitMask = reader.ReadUInt32();
            pixelFormat.GBitMask = reader.ReadUInt32();
            pixelFormat.BBitMask = reader.ReadUInt32();
            pixelFormat.ABitMask = reader.ReadUInt32();

            return pixelFormat;
        }

        internal byte[] GetBytes()
        {
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);

            writer.Write(Size);
            writer.Write((uint) Flags);
            if (Encoding.ASCII.GetByteCount(FourCC) != 4)
            {
                throw new InvalidOperationException("FourCC is not 4 Bytes long!");
            }
            writer.Write(Encoding.ASCII.GetBytes(FourCC));
            writer.Write(RGBBitCount);
            writer.Write(RBitMask);
            writer.Write(GBitMask);
            writer.Write(BBitMask);
            writer.Write(ABitMask);

            return stream.ToArray();
        }
    }
}