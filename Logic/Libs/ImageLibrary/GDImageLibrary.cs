using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace MediaExtractorLibrary.GDImageLibrary
{
    static class _DDS
    {
        [IODescription("Loads a .dds file and returns it as a bitmap.")]
        public static Bitmap LoadImage(byte[] DDSFile)
        {
            /*if (!File.Exists(DDsFile))
            {
                throw new Exception("File: " + DDsFile + " could not be found.");
            }

            byte[] DDSFile = File.ReadAllBytes(DDsFile);
            */
            DDSReader ddsReader = new DDSReader();
            int[] pixel = ddsReader.read(DDSFile, ddsReader.ARGB, 0);
            if (pixel != null)
            {
                int ImageWidth = ddsReader.getWidth(DDSFile);
                int ImageHeight = ddsReader.getHeight(DDSFile);
                byte[] PixelArray = pixel.SelectMany(BitConverter.GetBytes).ToArray();
                return ImageBuild(PixelArray, ImageWidth, ImageHeight);
            }
            //return default;
            else
            {
                try
                {
                    Bitmap ddsImage = new DDSImage(DDSFile).BitmapImage;
                    if (ddsImage.Width == 0 || ddsImage.Height == 0)
                    {
                        throw new Exception("No Width and Height");
                    }
                    return ddsImage;
                }
                catch
                {
                    return default;// new Bitmap(DDsFile);
                }
            }
        }
      

        [IODescription("Turns a byte array of pixels into a bitmap. Requires width and height of image as well.")]
        private static unsafe Bitmap ImageBuild(byte[] Pixel, int Imgwidth, int Imgheight)
        {
            Bitmap bmp = new Bitmap(Imgwidth, Imgheight);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, Imgwidth, Imgheight);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            byte* ptrbyte = (byte*)ptr;
            fixed (byte* p = Pixel)
            {
                for (var i = 0; i < Pixel.Length; i += 4)
                {
                    ptrbyte[i + 0] = p[i + 0];
                    ptrbyte[i + 1] = p[i + 1];
                    ptrbyte[i + 2] = p[i + 2];
                    ptrbyte[i + 3] = p[i + 3];

                }
            }
            bmp.UnlockBits(bmpData);
            return bmp;
        }
    }
}
