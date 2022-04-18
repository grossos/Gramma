using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gramma
{
    public partial class Form2 : Form
    {
        public Bitmap myimage;
        Binarize binarize = new Binarize();
        Form1 form1 = new Form1();  
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            Bitmap copy_image = (Bitmap)myimage.Clone();
            pictureBox1.Image = copy_image;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    myimage = new Bitmap(open.FileName);
                    pictureBox1.Image = myimage;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           // Bitmap binaryimage = (Bitmap)image.Clone();
           // binarize.binarize(binaryimage, trackBar1.Value);
           // pictureBox1.Image  = binaryimage;
           // pictureBox1.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(trackBar1.Value);
            Bitmap binaryimage = (Bitmap)myimage.Clone();
            binarize.binarize(binaryimage, trackBar1.Value);
            pictureBox1.Image = binaryimage;
            pictureBox1.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap binaryimage = (Bitmap)myimage.Clone();
            int otsu_threshold = binarize.GetOtsuThreshold(binaryimage);
            trackBar1.Value = otsu_threshold;
            textBox2.Text = otsu_threshold.ToString();
            binarize.binarize(binaryimage, trackBar1.Value);
            pictureBox1.Image = binaryimage;
            pictureBox1.Refresh();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
