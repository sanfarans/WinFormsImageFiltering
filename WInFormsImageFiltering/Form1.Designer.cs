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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inputImage = new System.Windows.Forms.PictureBox();
            this.outputImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
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
            this.customFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterInformationNewButton = new System.Windows.Forms.Button();
            this.filterInformationSaveButton = new System.Windows.Forms.Button();
            this.filterNameInput = new System.Windows.Forms.TextBox();
            this.filterInformationTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.anchorYInput = new System.Windows.Forms.TextBox();
            this.anchorXInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.offsetInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.divisorInput = new System.Windows.Forms.TextBox();
            this.autocomputeDivisorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.kernelColumnsInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.kernelRowsInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filterInformationMatrix = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
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
            this.panel2.SuspendLayout();
            this.filterInformationTable.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterInformationMatrix)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1200F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel2, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1582, 953);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editingControlsTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.customFilters, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 947);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1188, 494);
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
            this.outputImage.Location = new System.Drawing.Point(708, 20);
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
            this.panel1.Size = new System.Drawing.Size(182, 488);
            this.panel1.TabIndex = 2;
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
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
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
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
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
            this.saveImageButton.Click += new System.EventHandler(this.SaveImageButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(13, 48);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(145, 29);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
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
            this.editingControlsTable.Size = new System.Drawing.Size(1188, 262);
            this.editingControlsTable.TabIndex = 1;
            // 
            // edgeDetectionButton
            // 
            this.edgeDetectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edgeDetectionButton.Location = new System.Drawing.Point(714, 134);
            this.edgeDetectionButton.Name = "edgeDetectionButton";
            this.edgeDetectionButton.Size = new System.Drawing.Size(231, 125);
            this.edgeDetectionButton.TabIndex = 9;
            this.edgeDetectionButton.Text = "Edge detection";
            this.edgeDetectionButton.UseVisualStyleBackColor = true;
            this.edgeDetectionButton.Click += new System.EventHandler(this.EdgeDetectionButton_Click);
            // 
            // sharpenButton
            // 
            this.sharpenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sharpenButton.Location = new System.Drawing.Point(477, 134);
            this.sharpenButton.Name = "sharpenButton";
            this.sharpenButton.Size = new System.Drawing.Size(231, 125);
            this.sharpenButton.TabIndex = 8;
            this.sharpenButton.Text = "Sharpen";
            this.sharpenButton.UseVisualStyleBackColor = true;
            this.sharpenButton.Click += new System.EventHandler(this.SharpenButton_Click);
            // 
            // gaussianSmoothingButton
            // 
            this.gaussianSmoothingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaussianSmoothingButton.Location = new System.Drawing.Point(240, 134);
            this.gaussianSmoothingButton.Name = "gaussianSmoothingButton";
            this.gaussianSmoothingButton.Size = new System.Drawing.Size(231, 125);
            this.gaussianSmoothingButton.TabIndex = 7;
            this.gaussianSmoothingButton.Text = "Gaussian smoothing";
            this.gaussianSmoothingButton.UseVisualStyleBackColor = true;
            this.gaussianSmoothingButton.Click += new System.EventHandler(this.GaussianSmoothingButton_Click);
            // 
            // embossButton
            // 
            this.embossButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.embossButton.Location = new System.Drawing.Point(951, 134);
            this.embossButton.Name = "embossButton";
            this.embossButton.Size = new System.Drawing.Size(234, 125);
            this.embossButton.TabIndex = 6;
            this.embossButton.Text = "Emboss";
            this.embossButton.UseVisualStyleBackColor = true;
            this.embossButton.Click += new System.EventHandler(this.EmbossButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel6.Controls.Add(this.gammaSlider, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(714, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(229, 114);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // gammaSlider
            // 
            this.gammaSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gammaSlider.Location = new System.Drawing.Point(3, 25);
            this.gammaSlider.Maximum = 200;
            this.gammaSlider.Name = "gammaSlider";
            this.gammaSlider.Size = new System.Drawing.Size(223, 39);
            this.gammaSlider.TabIndex = 0;
            this.gammaSlider.Value = 100;
            this.gammaSlider.ValueChanged += new System.EventHandler(this.GammaSlider_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gamma correction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // inversionButton
            // 
            this.inversionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inversionButton.Location = new System.Drawing.Point(3, 3);
            this.inversionButton.Name = "inversionButton";
            this.inversionButton.Size = new System.Drawing.Size(231, 125);
            this.inversionButton.TabIndex = 0;
            this.inversionButton.Text = "Inversion";
            this.inversionButton.UseVisualStyleBackColor = true;
            this.inversionButton.Click += new System.EventHandler(this.InversionButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel4.Controls.Add(this.brightnessSlider, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.brightnessLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(240, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(229, 114);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // brightnessSlider
            // 
            this.brightnessSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessSlider.Location = new System.Drawing.Point(3, 25);
            this.brightnessSlider.Maximum = 128;
            this.brightnessSlider.Minimum = -128;
            this.brightnessSlider.Name = "brightnessSlider";
            this.brightnessSlider.Size = new System.Drawing.Size(223, 39);
            this.brightnessSlider.TabIndex = 0;
            this.brightnessSlider.ValueChanged += new System.EventHandler(this.BrightnessSlider_ValueChanged);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessLabel.Location = new System.Drawing.Point(3, 0);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(223, 22);
            this.brightnessLabel.TabIndex = 1;
            this.brightnessLabel.Text = "Brightness correction";
            this.brightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel3.Controls.Add(this.contrastSlider, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(477, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(229, 114);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // contrastSlider
            // 
            this.contrastSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastSlider.Location = new System.Drawing.Point(3, 25);
            this.contrastSlider.Maximum = 200;
            this.contrastSlider.Name = "contrastSlider";
            this.contrastSlider.Size = new System.Drawing.Size(223, 39);
            this.contrastSlider.TabIndex = 0;
            this.contrastSlider.Value = 100;
            this.contrastSlider.ValueChanged += new System.EventHandler(this.ContrastSlider_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contrast correction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // blurButton
            // 
            this.blurButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blurButton.Location = new System.Drawing.Point(3, 134);
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(231, 125);
            this.blurButton.TabIndex = 5;
            this.blurButton.Text = "Blur";
            this.blurButton.UseVisualStyleBackColor = true;
            this.blurButton.Click += new System.EventHandler(this.BlurButton_Click);
            // 
            // customFilters
            // 
            this.customFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customFilters.Location = new System.Drawing.Point(3, 771);
            this.customFilters.Name = "customFilters";
            this.customFilters.Size = new System.Drawing.Size(1188, 173);
            this.customFilters.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filterInformationNewButton);
            this.panel2.Controls.Add(this.filterInformationSaveButton);
            this.panel2.Controls.Add(this.filterNameInput);
            this.panel2.Controls.Add(this.filterInformationTable);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.filterInformationMatrix);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1203, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 947);
            this.panel2.TabIndex = 1;
            // 
            // filterInformationNewButton
            // 
            this.filterInformationNewButton.Location = new System.Drawing.Point(142, 796);
            this.filterInformationNewButton.Name = "filterInformationNewButton";
            this.filterInformationNewButton.Size = new System.Drawing.Size(94, 29);
            this.filterInformationNewButton.TabIndex = 18;
            this.filterInformationNewButton.Text = "New";
            this.filterInformationNewButton.UseVisualStyleBackColor = true;
            this.filterInformationNewButton.Click += new System.EventHandler(this.filterInformationNewButton_Click);
            // 
            // filterInformationSaveButton
            // 
            this.filterInformationSaveButton.Location = new System.Drawing.Point(142, 747);
            this.filterInformationSaveButton.Name = "filterInformationSaveButton";
            this.filterInformationSaveButton.Size = new System.Drawing.Size(94, 29);
            this.filterInformationSaveButton.TabIndex = 17;
            this.filterInformationSaveButton.Text = "Save";
            this.filterInformationSaveButton.UseVisualStyleBackColor = true;
            this.filterInformationSaveButton.Click += new System.EventHandler(this.FilterInformationSaveButton_Click);
            // 
            // filterNameInput
            // 
            this.filterNameInput.Location = new System.Drawing.Point(41, 141);
            this.filterNameInput.Name = "filterNameInput";
            this.filterNameInput.Size = new System.Drawing.Size(300, 27);
            this.filterNameInput.TabIndex = 16;
            this.filterNameInput.Text = "filter name";
            this.filterNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // filterInformationTable
            // 
            this.filterInformationTable.ColumnCount = 1;
            this.filterInformationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterInformationTable.Controls.Add(this.tableLayoutPanel11, 0, 4);
            this.filterInformationTable.Controls.Add(this.tableLayoutPanel10, 0, 3);
            this.filterInformationTable.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.filterInformationTable.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.filterInformationTable.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.filterInformationTable.Location = new System.Drawing.Point(67, 471);
            this.filterInformationTable.Name = "filterInformationTable";
            this.filterInformationTable.RowCount = 5;
            this.filterInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filterInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filterInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filterInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filterInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filterInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterInformationTable.Size = new System.Drawing.Size(257, 250);
            this.filterInformationTable.TabIndex = 15;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 5;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel11.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.anchorYInput, 4, 0);
            this.tableLayoutPanel11.Controls.Add(this.anchorXInput, 2, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(250, 40);
            this.tableLayoutPanel11.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(190, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 40);
            this.label8.TabIndex = 17;
            this.label8.Text = "y:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(128, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 40);
            this.label7.TabIndex = 16;
            this.label7.Text = "x:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "anchor";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anchorYInput
            // 
            this.anchorYInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.anchorYInput.Location = new System.Drawing.Point(215, 6);
            this.anchorYInput.Name = "anchorYInput";
            this.anchorYInput.Size = new System.Drawing.Size(32, 27);
            this.anchorYInput.TabIndex = 16;
            // 
            // anchorXInput
            // 
            this.anchorXInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.anchorXInput.Location = new System.Drawing.Point(153, 6);
            this.anchorXInput.Name = "anchorXInput";
            this.anchorXInput.Size = new System.Drawing.Size(31, 27);
            this.anchorXInput.TabIndex = 15;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.offsetInput, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(250, 40);
            this.tableLayoutPanel10.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "offset";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // offsetInput
            // 
            this.offsetInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.offsetInput.Location = new System.Drawing.Point(128, 6);
            this.offsetInput.Name = "offsetInput";
            this.offsetInput.Size = new System.Drawing.Size(119, 27);
            this.offsetInput.TabIndex = 14;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.divisorInput, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.autocomputeDivisorButton, 2, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(250, 40);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "divisor";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisorInput
            // 
            this.divisorInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divisorInput.Location = new System.Drawing.Point(128, 6);
            this.divisorInput.Name = "divisorInput";
            this.divisorInput.Size = new System.Drawing.Size(56, 27);
            this.divisorInput.TabIndex = 14;
            // 
            // autocomputeDivisorButton
            // 
            this.autocomputeDivisorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autocomputeDivisorButton.Location = new System.Drawing.Point(190, 3);
            this.autocomputeDivisorButton.Name = "autocomputeDivisorButton";
            this.autocomputeDivisorButton.Size = new System.Drawing.Size(57, 34);
            this.autocomputeDivisorButton.TabIndex = 15;
            this.autocomputeDivisorButton.Text = "auto";
            this.autocomputeDivisorButton.UseVisualStyleBackColor = true;
            this.autocomputeDivisorButton.Click += new System.EventHandler(this.autocomputeDivisorButton_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.kernelColumnsInput, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(250, 40);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "kernel columns";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kernelColumnsInput
            // 
            this.kernelColumnsInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kernelColumnsInput.Location = new System.Drawing.Point(128, 6);
            this.kernelColumnsInput.Name = "kernelColumnsInput";
            this.kernelColumnsInput.Size = new System.Drawing.Size(119, 27);
            this.kernelColumnsInput.TabIndex = 14;
            this.kernelColumnsInput.TextChanged += new System.EventHandler(this.KernelDimensions_TextChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.kernelRowsInput, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(250, 40);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "kernel rows";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kernelRowsInput
            // 
            this.kernelRowsInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kernelRowsInput.Location = new System.Drawing.Point(128, 6);
            this.kernelRowsInput.Name = "kernelRowsInput";
            this.kernelRowsInput.Size = new System.Drawing.Size(119, 27);
            this.kernelRowsInput.TabIndex = 14;
            this.kernelRowsInput.TextChanged += new System.EventHandler(this.KernelDimensions_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(67, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Filter information";
            // 
            // filterInformationMatrix
            // 
            this.filterInformationMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filterInformationMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filterInformationMatrix.ColumnHeadersVisible = false;
            this.filterInformationMatrix.Location = new System.Drawing.Point(41, 174);
            this.filterInformationMatrix.Name = "filterInformationMatrix";
            this.filterInformationMatrix.RowHeadersVisible = false;
            this.filterInformationMatrix.RowHeadersWidth = 51;
            this.filterInformationMatrix.RowTemplate.Height = 29;
            this.filterInformationMatrix.Size = new System.Drawing.Size(300, 275);
            this.filterInformationMatrix.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MinimumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainTableLayoutPanel.ResumeLayout(false);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.filterInformationTable.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterInformationMatrix)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView filterInformationMatrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel filterInformationTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox offsetInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox divisorInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox kernelColumnsInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox kernelRowsInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox anchorYInput;
        private System.Windows.Forms.TextBox anchorXInput;
        private System.Windows.Forms.Button autocomputeDivisorButton;
        private System.Windows.Forms.TextBox filterNameInput;
        private System.Windows.Forms.Button filterInformationSaveButton;
        private System.Windows.Forms.FlowLayoutPanel customFilters;
        private System.Windows.Forms.Button filterInformationNewButton;
    }
}
