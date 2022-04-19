using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace Gramma
{
    public partial class Form1 : Form
    {
        Bitmap myimage, initial_image;
        Bitmap binaryimage;
        Operations operations = new Operations();
        Binarize binarize = new Binarize();
        Models models = new Models();
        Filters filters = new Filters();
        YcbcrForm ycbcr_components = new YcbcrForm();
        RGBForm rgb_components = new RGBForm();
        HistogramForm histogram_form = new HistogramForm();   
        public Form1()
        {
           
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    myimage = new Bitmap(open.FileName);
                    pictureBox1.Image = myimage;
                    initial_image = (Bitmap)myimage.Clone();
                    button1.Visible = true;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void rChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            operations.monocolor(myimage, 0); // r channel
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void gChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operations.monocolor(myimage, 1); // r channel
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void bChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operations.monocolor(myimage, 2); // r channel
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void convertToGrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operations.grayscale(myimage);
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }
 
        private void rGBToYCbYCrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ycbcr_components.Visible)
            {
                ycbcr_components.Hide();
            }

            if (pictureBox1.Image == null)
            {
                label1.Text = "You have to select an image";
                label1.BackColor = Color.Gray;
                label1.ForeColor = Color.Black;
                return;

            }

            Bitmap yimage = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            Bitmap cbimage = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            Bitmap crimage = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            Bitmap ycbcrimage = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);


            models.RGBtoYcbCr(myimage, yimage, cbimage, crimage, ycbcrimage);

            ycbcr_components.pictureBox1.Image = yimage;
            ycbcr_components.pictureBox2.Image = cbimage;
            ycbcr_components.pictureBox3.Image = crimage;
            ycbcr_components.pictureBox4.Image = ycbcrimage;

            pictureBox1.Image = ycbcrimage;
            ycbcr_components.ShowDialog(); 
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(saveFileDialog1.FileName, format);
            }
        }

        private void gaussianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            filters.gaussian_filter(myimage, copy);
            myimage = copy;
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void meanFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            filters.mean_filter(myimage, copy);
            myimage = copy;
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            filters.median_filter(myimage, copy);
            myimage = copy;
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void binarizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.myimage = myimage;
            form2.ShowDialog();
            pictureBox1.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void yCbYrToRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bitmap yimage = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            //Bitmap cbimage = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            //Bitmap crimage = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            //Bitmap ycbcrimage = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);


            //models.ycbcr_to_rgb(myimage, yimage, cbimage, crimage, ycbcrimage);

            //rgb_components.pictureBox1.Image = yimage;
            //rgb_components.pictureBox2.Image = cbimage;
            //rgb_components.pictureBox3.Image = crimage;
            //rgb_components.pictureBox4.Image = ycbcrimage;

            ////pictureBox1.Image = ycbcrimage;
            //rgb_components.Show();
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operations.erosion(myimage);
            pictureBox1.Image=myimage;
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = initial_image;
            pictureBox1.Refresh();
        }

        private void highpassFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(myimage.Width, myimage.Height, PixelFormat.Format24bppRgb);
            filters.highpass_filter(myimage, copy);
            myimage = copy;
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void erosionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            operations.erosion(myimage);
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void dilationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            operations.dilation(myimage);
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operations.erosion(myimage);
            operations.dilation(myimage);
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operations.dilation(myimage);
            operations.erosion(myimage);            
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            histogram_form = new HistogramForm();
            histogram_form.grayscale_image = myimage;
            histogram_form.ShowDialog();
            
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operations.dilation(myimage);
            pictureBox1.Image = myimage;
            pictureBox1.Refresh();
        }
    }
}
    

