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
    }
}
