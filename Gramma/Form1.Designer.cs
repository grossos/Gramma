namespace Gramma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToGrayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromaticModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToYCbYCrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highpassFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.erosionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(35, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Save";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rChannelToolStripMenuItem,
            this.gChannelToolStripMenuItem,
            this.bChannelToolStripMenuItem,
            this.convertToGrayscaleToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            this.operationsToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
            // 
            // rChannelToolStripMenuItem
            // 
            this.rChannelToolStripMenuItem.Name = "rChannelToolStripMenuItem";
            this.rChannelToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.rChannelToolStripMenuItem.Text = "R Channel";
            this.rChannelToolStripMenuItem.Click += new System.EventHandler(this.rChannelToolStripMenuItem_Click);
            // 
            // gChannelToolStripMenuItem
            // 
            this.gChannelToolStripMenuItem.Name = "gChannelToolStripMenuItem";
            this.gChannelToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gChannelToolStripMenuItem.Text = "G Channel";
            this.gChannelToolStripMenuItem.Click += new System.EventHandler(this.gChannelToolStripMenuItem_Click);
            // 
            // bChannelToolStripMenuItem
            // 
            this.bChannelToolStripMenuItem.Name = "bChannelToolStripMenuItem";
            this.bChannelToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bChannelToolStripMenuItem.Text = "B Channel";
            this.bChannelToolStripMenuItem.Click += new System.EventHandler(this.bChannelToolStripMenuItem_Click);
            // 
            // convertToGrayscaleToolStripMenuItem
            // 
            this.convertToGrayscaleToolStripMenuItem.Name = "convertToGrayscaleToolStripMenuItem";
            this.convertToGrayscaleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.convertToGrayscaleToolStripMenuItem.Text = "Convert to grayscale";
            this.convertToGrayscaleToolStripMenuItem.Click += new System.EventHandler(this.convertToGrayscaleToolStripMenuItem_Click);
            // 
            // chromaticModelsToolStripMenuItem
            // 
            this.chromaticModelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBToYCbYCrToolStripMenuItem});
            this.chromaticModelsToolStripMenuItem.Name = "chromaticModelsToolStripMenuItem";
            this.chromaticModelsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.chromaticModelsToolStripMenuItem.Text = "Chromatic Models";
            // 
            // rGBToYCbYCrToolStripMenuItem
            // 
            this.rGBToYCbYCrToolStripMenuItem.Name = "rGBToYCbYCrToolStripMenuItem";
            this.rGBToYCbYCrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rGBToYCbYCrToolStripMenuItem.Text = "RGB to YCbYCr";
            this.rGBToYCbYCrToolStripMenuItem.Click += new System.EventHandler(this.rGBToYCbYCrToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.chromaticModelsToolStripMenuItem,
            this.binarizeToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.addNoiseToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.binarizeToolStripMenuItem.Text = "Binarize";
            this.binarizeToolStripMenuItem.Click += new System.EventHandler(this.binarizeToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionToolStripMenuItem1,
            this.dilationToolStripMenuItem1,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gaussianFilterToolStripMenuItem,
            this.meanFilterToolStripMenuItem,
            this.medianFilterToolStripMenuItem,
            this.highpassFilterToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // gaussianFilterToolStripMenuItem
            // 
            this.gaussianFilterToolStripMenuItem.Name = "gaussianFilterToolStripMenuItem";
            this.gaussianFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gaussianFilterToolStripMenuItem.Text = "Gaussian Filter";
            this.gaussianFilterToolStripMenuItem.Click += new System.EventHandler(this.gaussianFilterToolStripMenuItem_Click);
            // 
            // meanFilterToolStripMenuItem
            // 
            this.meanFilterToolStripMenuItem.Name = "meanFilterToolStripMenuItem";
            this.meanFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meanFilterToolStripMenuItem.Text = "Mean Filter";
            this.meanFilterToolStripMenuItem.Click += new System.EventHandler(this.meanFilterToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianFilterToolStripMenuItem.Text = "Median Filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // highpassFilterToolStripMenuItem
            // 
            this.highpassFilterToolStripMenuItem.Name = "highpassFilterToolStripMenuItem";
            this.highpassFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.highpassFilterToolStripMenuItem.Text = "Highpass Filter";
            this.highpassFilterToolStripMenuItem.Click += new System.EventHandler(this.highpassFilterToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.edgeDetectionToolStripMenuItem.Text = "Edge detection";
            // 
            // addNoiseToolStripMenuItem
            // 
            this.addNoiseToolStripMenuItem.Name = "addNoiseToolStripMenuItem";
            this.addNoiseToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.addNoiseToolStripMenuItem.Text = "Add Noise";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 23);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(870, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // erosionToolStripMenuItem1
            // 
            this.erosionToolStripMenuItem1.Name = "erosionToolStripMenuItem1";
            this.erosionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.erosionToolStripMenuItem1.Text = "Erosion";
            this.erosionToolStripMenuItem1.Click += new System.EventHandler(this.erosionToolStripMenuItem1_Click);
            // 
            // dilationToolStripMenuItem1
            // 
            this.dilationToolStripMenuItem1.Name = "dilationToolStripMenuItem1";
            this.dilationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dilationToolStripMenuItem1.Text = "Dilation";
            this.dilationToolStripMenuItem1.Click += new System.EventHandler(this.dilationToolStripMenuItem1_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1350, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gramma Image Processing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToGrayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromaticModelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToYCbYCrToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem highpassFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
    }
}

