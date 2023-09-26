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
using System.Linq;
using System.Text;

namespace MediaExtractorLibrary.GDImageLibrary
{
    class DDS
    {
        private const string Magic = "DDS";

        /// <summary>
        /// Gets or sets the DDS variant.
        /// </summary>
        public DDSVariant Variant { get; set; }

        /// <summary>
        /// Gets or sets the DDS header.
        /// </summary>
        public DDSHeader Header { get; set; }

        /// <summary>
        /// Gets or sets the images stored in the DDS.
        /// </summary>
        public byte[][][] Images { get; set; }

        /// <summary>
        /// Parses a DDS from a buffer.
        /// </summary>
        /// <param name="buffer">The buffer the DDS is stored in.</param>
        /// <param name="offset">The position of the DDS in buffer.</param>
        /// <param name="length">The length of the DDS in buffer.</param>
        /// <returns></returns>
        public static DDS Parse(byte[] buffer, int offset = 0, int length = -1)
        {
            if (length < 0)
            {
                length = buffer.Length - offset;
            }
            var stream = new MemoryStream(buffer, offset, length);
            var reader = new BinaryReader(stream);

            var dds = new DDS();

            if (Encoding.ASCII.GetString(reader.ReadBytes(3)) != Magic)
            {
                throw new ArgumentException("Invalid Magic!");
            }

            dds.Variant = (DDSVariant) reader.ReadByte();

            dds.Header = DDSHeader.Parse(reader.ReadBytes(DDSHeader.DefaultSize));
            if (dds.Header.Flags.HasFlag(DDSHeaderFlags.PixelFormat))
            {
                if (dds.Header.PixelFormat.Flags.HasFlag(DDSPixelFlags.FourCC))
                {
                    if (dds.Header.PixelFormat.FourCC == "DX10")
                    {
                        throw new NotImplementedException("DX10 not implemented!");
                    }
                }
            }

            dds.ParseMipmaps(reader);

            return dds;
        }

        private void ParseMipmaps(BinaryReader reader)
        {
            int layers = 1;
            if (Header.Caps2.HasFlag(DDSCaps2.Cubemap))
            {
                layers = 0;
                if (Header.Caps2.HasFlag(DDSCaps2.CubemapNegativeX)) layers++;
                if (Header.Caps2.HasFlag(DDSCaps2.CubemapPositiveX)) layers++;
                if (Header.Caps2.HasFlag(DDSCaps2.CubemapNegativeY)) layers++;
                if (Header.Caps2.HasFlag(DDSCaps2.CubemapPositiveY)) layers++;
                if (Header.Caps2.HasFlag(DDSCaps2.CubemapNegativeZ)) layers++;
                if (Header.Caps2.HasFlag(DDSCaps2.CubemapPositiveZ)) layers++;
            }

            //TODO: Depth

            uint mipcount = Header.MipmapCount;
            if (mipcount == 0 && !Header.Flags.HasFlag(DDSHeaderFlags.MipmapCount)) //Malformed DDS
            {
                mipcount = 1;
            }

            var mips = new byte[layers][][];

            var lengths = new int[mipcount];


            for (int m = 0; m < mipcount; m++)
            {
                var width = (int) Header.Width;
                var height = (int) Header.Height;

                for (int i = 0; i < m; i++)
                {
                    width /= 2;
                    height /= 2;
                }

                if (width < 1) width = 1;
                if (height < 1) height = 1;

                if (Header.PixelFormat.FourCC.Contains("DXT"))
                {
                    if (width % 4 != 0)
                    {
                        width += 4 - width % 4;
                    }
                    if (height % 4 != 0)
                    {
                        height += 4 - height % 4;
                    }

                    if (Header.PixelFormat.FourCC == "DXT1")
                    {
                        lengths[m] = width * height / 2;
                    }
                    else
                    {
                        lengths[m] = width * height;
                    }
                }
                else if (Header.PixelFormat.RGBBitCount != 0)
                {
                    lengths[m] = width * height * (int) Header.PixelFormat.RGBBitCount;
                    if (lengths[m] % 8 != 0)
                    {
                        lengths[m] += 8 - lengths[m] % 8;
                    }
                    lengths[m] /= 8;
                }
            }


            if (Variant == DDSVariant.Reversed)
            {
                Array.Reverse(lengths);
            }

            for (int l = 0; l < layers; l++)
            {
                mips[l] = new byte[mipcount][];
                for (int m = 0; m < mipcount; m++)
                {
                    mips[l][m] = reader.ReadBytes(lengths[m]);
                }
            }

            Images = mips;
        }

        /// <summary>
        /// Reverses the image order.
        /// </summary>
        public void Reverse()
        {
            switch (Variant)
            {
                case DDSVariant.Reversed:
                    Variant = DDSVariant.Default;
                    break;
                case DDSVariant.Default:
                    Variant = DDSVariant.Reversed;
                    break;
            }

            foreach (byte[][] image in Images)
            {
                Array.Reverse(image);
            }
        }

        /// <summary>
        /// Fixes the header.
        /// </summary>
        public void FixHeader()
        {
            Header.Flags |= DDSHeaderFlags.Caps | DDSHeaderFlags.Height | DDSHeaderFlags.Width |
                            DDSHeaderFlags.PixelFormat;
            Header.Caps |= DDSCaps.Texture;

            Header.MipmapCount = (uint) Images[0].Length;

            if (Header.MipmapCount > 1)
            {
                Header.Flags |= DDSHeaderFlags.MipmapCount;
                Header.Caps |= DDSCaps.Complex | DDSCaps.Mipmap;
            }

            if (Header.Caps2.HasFlag(DDSCaps2.Cubemap))
            {
                Header.Caps |= DDSCaps.Complex;
            }

            if (Header.Depth > 1)
            {
                Header.Caps2 |= DDSCaps2.Volume;
            }

            if (Header.Caps2.HasFlag(DDSCaps2.Volume))
            {
                Header.Caps |= DDSCaps.Complex;
                Header.Flags |= DDSHeaderFlags.Depth;
            }

            if (Header.PixelFormat.Flags.HasFlag(DDSPixelFlags.FourCC) && Header.LinearSize != 0)
            {
                Header.Flags |= DDSHeaderFlags.LinearSize;
            }

            if ((Header.PixelFormat.Flags.HasFlag(DDSPixelFlags.RGB) ||
                 Header.PixelFormat.Flags.HasFlag(DDSPixelFlags.YUV) ||
                 Header.PixelFormat.Flags.HasFlag(DDSPixelFlags.Luminance) ||
                 Header.PixelFormat.Flags.HasFlag(DDSPixelFlags.Alpha)) && Header.LinearSize != 0)
            {
                Header.Flags |= DDSHeaderFlags.Pitch;
            }

// ReSharper disable InvertIf
            if (Header.PixelFormat.Flags.HasFlag(DDSPixelFlags.RGB) &&
// ReSharper restore InvertIf
                Header.PixelFormat.RBitMask + Header.PixelFormat.GBitMask + Header.PixelFormat.BBitMask == 0)
            {
                Header.PixelFormat.RBitMask = 0xff0000; //TODO: Make this work for any RGBBitLength
                Header.PixelFormat.GBitMask = 0x00ff00;
                Header.PixelFormat.BBitMask = 0x0000ff;
            }
        }

        /// <summary>
        /// Gets the DDS data.
        /// </summary>
        /// <returns>The DDS data.</returns>
        public byte[] GetBytes()
        {
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);

            writer.Write(Encoding.ASCII.GetBytes(Magic));
            writer.Write((byte) Variant);

            writer.Write(Header.GetBytes());

            foreach (var mipmap in Images.SelectMany(slice => slice))
            {
                writer.Write(mipmap);
            }
            return stream.ToArray();
        }
    }
}