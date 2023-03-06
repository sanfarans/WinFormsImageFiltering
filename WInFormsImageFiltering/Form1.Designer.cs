namespace WInFormsImageFiltering
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inputImage = new System.Windows.Forms.PictureBox();
            this.outputImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.editingControlsTable = new System.Windows.Forms.TableLayoutPanel();
            this.edgeDetectionButton = new System.Windows.Forms.Button();
            this.sharpenButton = new System.Windows.Forms.Button();
            this.gaussianSmoothingButton = new System.Windows.Forms.Button();
            this.embossButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.gammaSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.inversionButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.brightnessSlider = new System.Windows.Forms.TrackBar();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.contrastSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.blurButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.undoButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.editingControlsTable.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaSlider)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastSlider)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editingControlsTable, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel2.Controls.Add(this.inputImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.outputImage, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 494F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1176, 494);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // inputImage
            // 
            this.inputImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputImage.Location = new System.Drawing.Point(20, 20);
            this.inputImage.Margin = new System.Windows.Forms.Padding(20);
            this.inputImage.Name = "inputImage";
            this.inputImage.Size = new System.Drawing.Size(460, 454);
            this.inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImage.TabIndex = 0;
            this.inputImage.TabStop = false;
            // 
            // outputImage
            // 
            this.outputImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputImage.Location = new System.Drawing.Point(696, 20);
            this.outputImage.Margin = new System.Windows.Forms.Padding(20);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(460, 454);
            this.outputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputImage.TabIndex = 1;
            this.outputImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.undoButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.saveImageButton);
            this.panel1.Controls.Add(this.loadImageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(503, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 488);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "progress";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 399);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(145, 29);
            this.progressBar.TabIndex = 2;
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(13, 83);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(145, 29);
            this.saveImageButton.TabIndex = 1;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(13, 48);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(145, 29);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // editingControlsTable
            // 
            this.editingControlsTable.ColumnCount = 5;
            this.editingControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.editingControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.editingControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.editingControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.editingControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.editingControlsTable.Controls.Add(this.edgeDetectionButton, 0, 1);
            this.editingControlsTable.Controls.Add(this.sharpenButton, 0, 1);
            this.editingControlsTable.Controls.Add(this.gaussianSmoothingButton, 0, 1);
            this.editingControlsTable.Controls.Add(this.embossButton, 0, 1);
            this.editingControlsTable.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.editingControlsTable.Controls.Add(this.inversionButton, 0, 0);
            this.editingControlsTable.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.editingControlsTable.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.editingControlsTable.Controls.Add(this.blurButton, 0, 1);
            this.editingControlsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editingControlsTable.Enabled = false;
            this.editingControlsTable.Location = new System.Drawing.Point(3, 503);
            this.editingControlsTable.Name = "editingControlsTable";
            this.editingControlsTable.RowCount = 2;
            this.editingControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editingControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editingControlsTable.Size = new System.Drawing.Size(1176, 247);
            this.editingControlsTable.TabIndex = 1;
            // 
            // edgeDetectionButton
            // 
            this.edgeDetectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edgeDetectionButton.Location = new System.Drawing.Point(708, 126);
            this.edgeDetectionButton.Name = "edgeDetectionButton";
            this.edgeDetectionButton.Size = new System.Drawing.Size(229, 118);
            this.edgeDetectionButton.TabIndex = 9;
            this.edgeDetectionButton.Text = "Edge detection";
            this.edgeDetectionButton.UseVisualStyleBackColor = true;
            this.edgeDetectionButton.Click += new System.EventHandler(this.edgeDetectionButton_Click);
            // 
            // sharpenButton
            // 
            this.sharpenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sharpenButton.Location = new System.Drawing.Point(473, 126);
            this.sharpenButton.Name = "sharpenButton";
            this.sharpenButton.Size = new System.Drawing.Size(229, 118);
            this.sharpenButton.TabIndex = 8;
            this.sharpenButton.Text = "Sharpen";
            this.sharpenButton.UseVisualStyleBackColor = true;
            this.sharpenButton.Click += new System.EventHandler(this.sharpenButton_Click);
            // 
            // gaussianSmoothingButton
            // 
            this.gaussianSmoothingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaussianSmoothingButton.Location = new System.Drawing.Point(238, 126);
            this.gaussianSmoothingButton.Name = "gaussianSmoothingButton";
            this.gaussianSmoothingButton.Size = new System.Drawing.Size(229, 118);
            this.gaussianSmoothingButton.TabIndex = 7;
            this.gaussianSmoothingButton.Text = "Gaussian smoothing";
            this.gaussianSmoothingButton.UseVisualStyleBackColor = true;
            this.gaussianSmoothingButton.Click += new System.EventHandler(this.gaussianSmoothingButton_Click);
            // 
            // embossButton
            // 
            this.embossButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.embossButton.Location = new System.Drawing.Point(943, 126);
            this.embossButton.Name = "embossButton";
            this.embossButton.Size = new System.Drawing.Size(230, 118);
            this.embossButton.TabIndex = 6;
            this.embossButton.Text = "Emboss";
            this.embossButton.UseVisualStyleBackColor = true;
            this.embossButton.Click += new System.EventHandler(this.embossButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel6.Controls.Add(this.gammaSlider, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(708, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(229, 117);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // gammaSlider
            // 
            this.gammaSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gammaSlider.Location = new System.Drawing.Point(3, 26);
            this.gammaSlider.Maximum = 200;
            this.gammaSlider.Name = "gammaSlider";
            this.gammaSlider.Size = new System.Drawing.Size(223, 40);
            this.gammaSlider.TabIndex = 0;
            this.gammaSlider.Value = 100;
            this.gammaSlider.ValueChanged += new System.EventHandler(this.gammaSlider_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gamma correction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // inversionButton
            // 
            this.inversionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inversionButton.Location = new System.Drawing.Point(3, 3);
            this.inversionButton.Name = "inversionButton";
            this.inversionButton.Size = new System.Drawing.Size(229, 117);
            this.inversionButton.TabIndex = 0;
            this.inversionButton.Text = "Inversion";
            this.inversionButton.UseVisualStyleBackColor = true;
            this.inversionButton.Click += new System.EventHandler(this.inversionButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel4.Controls.Add(this.brightnessSlider, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.brightnessLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(238, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(229, 117);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // brightnessSlider
            // 
            this.brightnessSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessSlider.Location = new System.Drawing.Point(3, 26);
            this.brightnessSlider.Maximum = 128;
            this.brightnessSlider.Minimum = -128;
            this.brightnessSlider.Name = "brightnessSlider";
            this.brightnessSlider.Size = new System.Drawing.Size(223, 40);
            this.brightnessSlider.TabIndex = 0;
            this.brightnessSlider.ValueChanged += new System.EventHandler(this.brightnessSlider_ValueChanged);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessLabel.Location = new System.Drawing.Point(3, 0);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(223, 23);
            this.brightnessLabel.TabIndex = 1;
            this.brightnessLabel.Text = "Brightness correction";
            this.brightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel3.Controls.Add(this.contrastSlider, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(473, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(229, 117);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // contrastSlider
            // 
            this.contrastSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastSlider.Location = new System.Drawing.Point(3, 26);
            this.contrastSlider.Maximum = 200;
            this.contrastSlider.Name = "contrastSlider";
            this.contrastSlider.Size = new System.Drawing.Size(223, 40);
            this.contrastSlider.TabIndex = 0;
            this.contrastSlider.Value = 100;
            this.contrastSlider.ValueChanged += new System.EventHandler(this.contrastSlider_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contrast correction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // blurButton
            // 
            this.blurButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blurButton.Location = new System.Drawing.Point(3, 126);
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(229, 118);
            this.blurButton.TabIndex = 5;
            this.blurButton.Text = "Blur";
            this.blurButton.UseVisualStyleBackColor = true;
            this.blurButton.Click += new System.EventHandler(this.blurButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel5.Controls.Add(this.trackBar2, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar2.Location = new System.Drawing.Point(3, 23);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Minimum = -255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(223, 74);
            this.trackBar2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brightness correction";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // undoButton
            // 
            this.undoButton.Enabled = false;
            this.undoButton.Location = new System.Drawing.Point(13, 157);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(145, 29);
            this.undoButton.TabIndex = 4;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(13, 192);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(145, 29);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editingControlsTable.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaSlider)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastSlider)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox inputImage;
        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.TableLayoutPanel editingControlsTable;
        private System.Windows.Forms.Button inversionButton;
        private System.Windows.Forms.TrackBar brightnessSlider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TrackBar gammaSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TrackBar contrastSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button blurButton;
        private System.Windows.Forms.Button edgeDetectionButton;
        private System.Windows.Forms.Button sharpenButton;
        private System.Windows.Forms.Button gaussianSmoothingButton;
        private System.Windows.Forms.Button embossButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button resetButton;
    }
}
