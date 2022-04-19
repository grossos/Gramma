using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gramma
{
    public partial class HistogramForm : Form
    {
        public Bitmap grayscale_image;
        private int[] values;

        public HistogramForm()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            //int stride = bmData.Stride;
            //System.IntPtr Scan0 = bmData.Scan0;

            ChartArea ChartArea1 = new ChartArea();
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.Series[0].LegendText = "Sum of each gray level";

            values = Histogram.get_hist_values(grayscale_image);

            for (int x = 0; x < 255; x++)
            {
                chart1.Series[0].Points.AddXY(x, values[x]);
            }
            chart1.Show();    
        }
    }
}
