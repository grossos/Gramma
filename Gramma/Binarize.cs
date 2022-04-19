using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Gramma
{
    internal class Binarize
    {
        public void binarize(Bitmap image, int threshold)
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
                        if (p[i] <= threshold) p[i] = p[i + 1] = p[i + 2] = 0;
                        else p[i] = p[i + 1] = p[i + 2] = (byte)255;
                    }
                }
            }
            image.UnlockBits(bmData);
        }

        private static float Px(int init, int end, int[] hist)
        {

            int sum = 0;

            int i;



            for (i = init; i <= end; i++)

                sum += hist[i];



            return (float)sum;

        }



        private static float Mx(int init, int end, int[] hist)
        {

            int sum = 0;

            int i;



            for (i = init; i <= end; i++)

                sum += i * hist[i];



            return (float)sum;

        }



        private static int FindMax(float[] vec, int n)
        {

            float maxVec = 0;

            int idx = 0;

            int i;



            for (i = 1; i < n - 1; i++)
            {

                if (vec[i] > maxVec)
                {

                    maxVec = vec[i];

                    idx = i;

                }

            }



            return idx;

        }



        unsafe private static void GetHistogram(byte* p, int w, int h, int ws, int[] hist)
        {

            hist.Initialize();



            for (int i = 0; i < h; i++)
            {

                for (int j = 0; j < w * 3; j += 3)
                {

                    int index = i * ws + j;

                    hist[p[index]]++;

                }

            }

        }



        public  int GetOtsuThreshold(Bitmap bmp)
        {

            byte t = 0;

            float[] vet = new float[256];

            int[] hist = new int[256];

            vet.Initialize();



            float p1, p2, p12;

            int k;



            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),

            ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);



            unsafe
            {

                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();



                GetHistogram(p, bmp.Width, bmp.Height, bmData.Stride, hist);



                for (k = 1; k != 255; k++)
                {

                    p1 = Px(0, k, hist);

                    p2 = Px(k + 1, 255, hist);

                    p12 = p1 * p2;

                    if (p12 == 0)

                        p12 = 1;

                    float diff = (Mx(0, k, hist) * p2) - (Mx(k + 1, 255, hist) * p1);

                    vet[k] = (float)diff * diff / p12;

                }

            }



            bmp.UnlockBits(bmData);

            t = (byte)FindMax(vet, 256);



            return t;

        }
    }
}

