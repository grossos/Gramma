using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Gramma
{
    class Operations
    {
        public void monocolor(Bitmap image, int colorcomponent)
        {

            // read image 
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width;
            int height = image.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;
                        if (colorcomponent != 0) p[i] = 0;
                        if (colorcomponent != 1) p[i + 1] = 0;
                        if (colorcomponent != 2) p[i + 2] = 0;
                    }
                }
            }
            image.UnlockBits(bmData);
        }

        public void grayscale(Bitmap image)
        {
            
            // read image 
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width;
            int height = image.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte red, green, blue;
                byte* p = (byte*)(void*)Scan0;
                for(int x=0; x<height; x++)
                {
                    for(int y=0; y<width; y++)
                    {
                        int i = x * stride + y * 3;
                        red =p[x*stride + y*3];
                        green = p[x * stride + y * 3 + 1];
                        blue = p[x * stride + y * 3 + 2];
                        p[x * stride + y * 3] = p[x * stride + y * 3 + 1] = p[x * stride + y * 3 + 2] =
                        (byte)(.299 * red + .587 * green + .114 * blue);
                    }
                }
            }
            image.UnlockBits(bmData);
        }

        public void erosion(Bitmap bmp)
        {
            Bitmap source = (Bitmap)bmp.Clone();

            BitmapData bmData2 = source.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan2 = bmData2.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int ir = y + i;
                                int jr = x + j;
                                if (ir < 0) ir = 0;
                                if (jr < 0) jr = 0;
                                if (ir >= height) ir = height - 1;
                                if (jr >= width) jr = width - 1;
                                if (p2[ir * stride + jr * 3] == 0)
                                {
                                    p[y * stride + x * 3] = 0;
                                    p[y * stride + x * 3 + 1] = 0;
                                    p[y * stride + x * 3 + 2] = 0;
                                }
                            }
                        }
                    }
                }
            }
            bmp.UnlockBits(bmData);
            source.UnlockBits(bmData2);
            //source.Dispose();
        }

        public void dilation(Bitmap bmp)
        {
            Bitmap source = (Bitmap)bmp.Clone();

            BitmapData bmData2 = source.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan2 = bmData2.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int i = -1; i <= 1; i++) 
                        {
                            for (int j = -1; j <= 1; j++) 
                            {
                                int ir = y + i;
                                int jr = x + j;
                                if (ir < 0) ir = 0;
                                if (jr < 0) jr = 0;
                                if (ir >= height) ir = height - 1;
                                if (jr >= width) jr = width - 1;
                                if (p2[ir * stride + jr * 3] == 255)
                                {
                                    p[y * stride + x * 3] = 255;
                                    p[y * stride + x * 3 + 1] = 255;
                                    p[y * stride + x * 3 + 2] = 255;
                                }
                            }
                        }
                    }
                }
            }
            bmp.UnlockBits(bmData);
            source.UnlockBits(bmData2);
            //source.Dispose();
        }
    }
}
