using System.Drawing;
using System.Drawing.Imaging;

namespace Gramma
{
    internal class Histogram
    {
        public static int[] get_hist_values(Bitmap image)
        {
            // read image 
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width;
            int height = image.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            int[] count = new int[256];

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y* stride + x*3;
                        count[p[i]]++;
                    }
                }
            }
            image.UnlockBits(bmData);
            return count;
        }
    }
}
