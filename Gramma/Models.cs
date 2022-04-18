using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Gramma
{
    internal class Models
    {
        public void RGBtoYcbCr(Bitmap rgbimage, Bitmap yimage, Bitmap cbimage, Bitmap crimage, Bitmap ycbcrimage)
        {
            int width = rgbimage.Width, height = rgbimage.Height;

            BitmapData rgbData = rgbimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData yData = yimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData cbData = cbimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData crData = crimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData ycbcrData = ycbcrimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = rgbData.Stride;
            System.IntPtr rgbScan0 = rgbData.Scan0;
            System.IntPtr yScan0 = yData.Scan0;
            System.IntPtr cbScan0 = cbData.Scan0;
            System.IntPtr crScan0 = crData.Scan0;
            System.IntPtr ycbcrScan0 = ycbcrData.Scan0;
            byte red, green, blue;
            unsafe
            {
                byte* rgbpointer = (byte*)(void*)rgbScan0;
                byte* ypointer = (byte*)(void*)yScan0;
                byte* cbpointer = (byte*)(void*)cbScan0;
                byte* crpointer = (byte*)(void*)crScan0;
                byte* ycbcrPointer = (byte*)(void*)ycbcrScan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        blue = rgbpointer[y * stride + x * 3 + 2];
                        green = rgbpointer[y * stride + x * 3 + 1];
                        red = rgbpointer[y * stride + x * 3];
                        for (int i = 0; i < 3; i++)
                        {
                            ypointer[y * stride + x * 3 + i] = (byte)(.2989 * red + .5866 * green + .1145 * blue);
                            cbpointer[y * stride + x * 3 + i] = (byte)(-0.1688 * red - 0.3312 * green + 0.5 * blue + 128);
                            crpointer[y * stride + x * 3 + i] = (byte)(0.5 * red - 0.4184 * green - 0.0816 * blue + 128);
                        }
                        ycbcrPointer[y * stride + x * 3 + 1] = (byte)(.2989 * red + .5866 * green + .1145 * blue);
                        ycbcrPointer[y * stride + x * 3 + 2] = (byte)(-0.1688 * red - 0.3312 * green + 0.5 * blue + 128);
                        ycbcrPointer[y * stride + x * 3 + 3] = (byte)(0.5 * red - 0.4184 * green - 0.0816 * blue + 128);

                    }
                }
            }
            rgbimage.UnlockBits(rgbData);
            yimage.UnlockBits(yData);
            cbimage.UnlockBits(cbData);
            crimage.UnlockBits(crData);
            ycbcrimage.UnlockBits(ycbcrData);
        }

        public void ycbcr_to_rgb(Bitmap rgbimage, Bitmap yimage, Bitmap cbimage, Bitmap crimage, Bitmap ycbcrimage)
        {
            int width = rgbimage.Width, height = rgbimage.Height;

            BitmapData rgbData = rgbimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData yData = yimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData cbData = cbimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData crData = crimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData ycbcrData = ycbcrimage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = rgbData.Stride;
            System.IntPtr rgbScan0 = rgbData.Scan0;
            System.IntPtr yScan0 = yData.Scan0;
            System.IntPtr cbScan0 = cbData.Scan0;
            System.IntPtr crScan0 = crData.Scan0;
            System.IntPtr ycbcrScan0 = ycbcrData.Scan0;
            byte red, green, blue;
            unsafe
            {
                byte* rgbpointer = (byte*)(void*)rgbScan0;
                byte* ypointer = (byte*)(void*)yScan0;
                byte* cbpointer = (byte*)(void*)cbScan0;
                byte* crpointer = (byte*)(void*)crScan0;
                byte* ycbcrPointer = (byte*)(void*)ycbcrScan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        blue = rgbpointer[y * stride + x * 3];
                        green = rgbpointer[y * stride + x * 3 + 1];
                        red = rgbpointer[y * stride + x * 3 + 2];
                        for (int i = 0; i < 3; i++)
                        {
                            ypointer[y * stride + x * 3 + i] = (byte)(1 * red + 0 * green + 1.4 * blue);
                            cbpointer[y * stride + x * 3 + i] = (byte)(1 * red - 0.3312 * green -0.71 * blue - 128);
                            crpointer[y * stride + x * 3 + i] = (byte)(1 * red + 1.77 * green - 0 * blue - 128);
                        }
                        ycbcrPointer[y * stride + x * 3 + 1] = (byte)(1 * red + 0 * green + 1.4 * blue);
                        ycbcrPointer[y * stride + x * 3 + 2] = (byte)(1 * red - 0.3312 * green - 0.71 * blue - 128);
                        ycbcrPointer[y * stride + x * 3 + 3] = (byte)(1 * red + 1.77 * green - 0 * blue - 128);

                    }
                }
            }
            rgbimage.UnlockBits(rgbData);
            yimage.UnlockBits(yData);
            cbimage.UnlockBits(cbData);
            crimage.UnlockBits(crData);
            ycbcrimage.UnlockBits(ycbcrData);
        }
    }
}
