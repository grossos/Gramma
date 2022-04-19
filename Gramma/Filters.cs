using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Gramma
{
    internal class Filters
    {
        //byte[] array = new byte[9];
        private byte median_value(byte[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i+1; j < array.Length -1; j++)
                    if(array[i] > array[j + 1])
                    {
                        byte temp = array[i];
                        array[i] = array[j];
                        array[j] = temp; 
                    }
            }
            return array[4];
        }
        public void gaussian_filter(Bitmap image, Bitmap result_image)
        {
            // read image 
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData copyData = result_image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width;
            int height = image.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan1 = copyData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan1;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;

                        if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                        {
                            p2[i] = p[i];
                            p2[i + 1] = p[i + 1];
                            p2[i + 2] = p[i + 2];
                        }
                        else
                        {
                            p2[i] = (byte)((p[(y - 1) * stride + (x - 1) * 3] + p[(y - 1) * stride + x * 3] * 2 + p[(y - 1) * stride + (x + 1) * 3] * 1 +
                                p[(y) * stride + (x - 1) * 3] * 2 + p[(y) * stride + x * 3] * 4 + p[(y) * stride + (x + 1) * 3] * 2 +
                                p[(y + 1) * stride + (x - 1) * 3] + p[(y + 1) * stride + x * 3] * 2 + p[(y + 1) * stride + (x + 1) * 3] * 1)/16);

                            p2[i+1] = (byte)((p[(y - 1) * stride + (x - 1) * 3 + 1] + p[(y - 1) * stride + x * 3 + 1] * 2 + p[(y - 1) * stride + (x + 1) * 3 + 1] * 1 +
                                p[(y) * stride + (x - 1) * 3 + 1] * 2 + p[(y) * stride + x * 3 + 1] * 4 + p[(y) * stride + (x + 1) * 3 + 1] * 2 +
                                p[(y + 1) * stride + (x - 1) * 3 + 1] + p[(y + 1) * stride + x * 3 + 1] * 2 + p[(y + 1) * stride + (x + 1) * 3 + 1] * 1)/16);

                            p2[i+2] = (byte)((p[(y - 1) * stride + (x - 1) * 3 + 2] + p[(y - 1) * stride + x * 3 + 2] * 2 + p[(y - 1) * stride + (x + 1) * 3 + 2] * 1 +
                                p[(y) * stride + (x - 1) * 3 + 2] * 2 + p[(y) * stride + x * 3 + 2] * 4 + p[(y) * stride + (x + 1) * 3 + 2] * 2 +
                                p[(y + 1) * stride + (x - 1) * 3 + 2] + p[(y + 1) * stride + x * 3 + 2] * 2 + p[(y + 1) * stride + (x + 1) * 3 + 2] * 1)/16);
                        }
                    }
                }
            }
            image.UnlockBits(bmData);
            result_image.UnlockBits(copyData);
        }

        public void mean_filter(Bitmap image, Bitmap result_image)
        {
            // read image 
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData copyData = result_image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width;
            int height = image.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan1 = copyData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan1;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;

                        if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                        {
                            p2[i] = p[i];
                            p2[i + 1] = p[i + 1];
                            p2[i + 2] = p[i + 2];
                        }
                        else
                        {
                            p2[i] = (byte)((p[(y - 1) * stride + (x - 1) * 3] + p[(y - 1) * stride + x * 3] + p[(y - 1) * stride + (x + 1) * 3] +
                                p[(y) * stride + (x - 1) * 3] + p[(y) * stride + x * 3] + p[(y) * stride + (x + 1) * 3] +
                                p[(y + 1) * stride + (x - 1) * 3] + p[(y + 1) * stride + x * 3] + p[(y + 1) * stride + (x + 1) * 3]) / 9);

                            p2[i + 1] = (byte)((p[(y - 1) * stride + (x - 1) * 3 + 1] + p[(y - 1) * stride + x * 3 + 1] + p[(y - 1) * stride + (x + 1) * 3 + 1] +
                                p[(y) * stride + (x - 1) * 3 + 1] + p[(y) * stride + x * 3 + 1] + p[(y) * stride + (x + 1) * 3 + 1] +
                                p[(y + 1) * stride + (x - 1) * 3 + 1] + p[(y + 1) * stride + x * 3 + 1] + p[(y + 1) * stride + (x + 1) * 3 + 1]) / 9);

                            p2[i + 2] = (byte)((p[(y - 1) * stride + (x - 1) * 3 + 2] + p[(y - 1) * stride + x * 3 + 2] + p[(y - 1) * stride + (x + 1) * 3 + 2] +
                                p[(y) * stride + (x - 1) * 3 + 2] + p[(y) * stride + x * 3 + 2] + p[(y) * stride + (x + 1) * 3 + 2] +
                                p[(y + 1) * stride + (x - 1) * 3 + 2] + p[(y + 1) * stride + x * 3 + 2] + p[(y + 1) * stride + (x + 1) * 3 + 2] ) / 9);
                        }
                    }
                }
            }
            image.UnlockBits(bmData);
            result_image.UnlockBits(copyData);
        }

        public void median_filter(Bitmap image, Bitmap result_image)
        {
            // read image 
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData copyData = result_image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width;
            int height = image.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan1 = copyData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan1;

                byte[] temp_p = new byte[9];
                byte[] temp_p1 = new byte[9];
                byte[] temp_p2 = new byte[9];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;

                        if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                        {
                            p2[i] = p[i];
                            p2[i + 1] = p[i + 1];
                            p2[i + 2] = p[i + 2];
                        }
                        else
                        {
                            temp_p[0] = p[(y - 1) * stride + (x - 1)*3];
                            temp_p[1] = p[(y - 1) * stride + (x) * 3];
                            temp_p[2] = p[(y - 1) * stride + (x + 1) * 3];
                            temp_p[3] = p[(y) * stride + (x - 1) * 3];
                            temp_p[4] = p[(y) * stride + (x) * 3];
                            temp_p[5] = p[(y) * stride + (x + 1) * 3];
                            temp_p[6] = p[(y + 1) * stride + (x - 1) * 3];
                            temp_p[7] = p[(y + 1) * stride + (x) * 3];
                            temp_p[8] = p[(y + 1) * stride + (x + 1) * 3];

                            temp_p1[0] = p[(y - 1) * stride + 3*(x - 1)+1];
                            temp_p1[1] = p[(y - 1) * stride + 3 * (x)+1];
                            temp_p1[2] = p[(y - 1) * stride + 3 * (x + 1)+1];
                            temp_p1[3] = p[(y) * stride + 3 * (x - 1)+1];
                            temp_p1[4] = p[(y) * stride + 3 * (x)+1];
                            temp_p1[5] = p[(y) * stride + 3 * (x + 1)+1];
                            temp_p1[6] = p[(y + 1) * stride + 3 * (x - 1)+1];
                            temp_p1[7] = p[(y + 1) * stride + 3 * (x)+1];
                            temp_p1[8] = p[(y + 1) * stride + 3 * (x + 1)+1];

                            temp_p2[0] = p[(y - 1) * stride + 3 * (x - 1)+2];
                            temp_p2[1] = p[(y - 1) * stride + 3 * (x) + 2];
                            temp_p2[2] = p[(y - 1) * stride + 3 * (x + 1) + 2];
                            temp_p2[3] = p[(y) * stride + 3 * (x - 1) + 2];
                            temp_p2[4] = p[(y) * stride + 3 * (x) + 2];
                            temp_p2[5] = p[(y) * stride + 3 * (x + 1) + 2];
                            temp_p2[6] = p[(y + 1) * stride + 3 * (x - 1) + 2];
                            temp_p2[7] = p[(y + 1) * stride + 3 * (x) + 2];
                            temp_p2[8] = p[(y + 1) * stride + 3 * (x + 1) + 2];

                            p2[i] = median_value(temp_p);
                            p2[i+1] = median_value(temp_p1);
                            p2[i+2] = median_value(temp_p2);
                        }
                    }
                }
            }
            image.UnlockBits(bmData);
            result_image.UnlockBits(copyData);
        }
        
        public void highpass_filter(Bitmap image, Bitmap result_image)
        {
            // read image 
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData copyData = result_image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width;
            int height = image.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan1 = copyData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan1;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;

                        if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                        {
                            p2[i] = p[i];
                            p2[i + 1] = p[i + 1];
                            p2[i + 2] = p[i + 2];
                        }
                        else
                        {
                            p2[i] = (byte)((p[(y - 1) * stride + (x - 1) * 3] *-1 + p[(y - 1) * stride + x * 3] * -1 + p[(y - 1) * stride + (x + 1) * 3] * -1 +
                                p[(y) * stride + (x - 1) * 3] * -1 + p[(y) * stride + x * 3] *8 + p[(y) * stride + (x + 1) * 3] * -1 +
                                p[(y + 1) * stride + (x - 1) * 3] * -1 + p[(y + 1) * stride + x * 3] * -1 + p[(y + 1) * stride + (x + 1) * 3] * -1) / 9);

                            p2[i + 1] = (byte)((p[(y - 1) * stride + (x - 1) * 3 + 1] * -1 + p[(y - 1) * stride + x * 3 + 1] * -1 + p[(y - 1) * stride + (x + 1) * 3 + 1] * -1 +
                                p[(y) * stride + (x - 1) * 3 + 1] * -1 + p[(y) * stride + x * 3 + 1] * 8 + p[(y) * stride + (x + 1) * 3 + 1] * -1 +
                                p[(y + 1) * stride + (x - 1) * 3 + 1] * -1 + p[(y + 1) * stride + x * 3 + 1] * -1 + p[(y + 1) * stride + (x + 1) * 3 + 1] * -1) / 9);

                            p2[i + 2] = (byte)((p[(y - 1) * stride + (x - 1) * 3 + 2] * -1 + p[(y - 1) * stride + x * 3 + 2] * -1 + p[(y - 1) * stride + (x + 1) * 3 + 2] * -1 +
                                p[(y) * stride + (x - 1) * 3 + 2] * -1 + p[(y) * stride + x * 3 + 2] * 8 + p[(y) * stride + (x + 1) * 3 + 2] * -1 +
                                p[(y + 1) * stride + (x - 1) * 3 + 2] * -1 + p[(y + 1) * stride + x * 3 + 2] * -1 + p[(y + 1) * stride + (x + 1) * 3 + 2] * -1) / 9);
                        }
                    }
                }
            }
            image.UnlockBits(bmData);
            result_image.UnlockBits(copyData);
        }
    }
}
