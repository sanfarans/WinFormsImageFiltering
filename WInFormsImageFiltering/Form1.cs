using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInFormsImageFiltering
{
    public partial class Form1 : Form
    {
        private string? loadedFileName = null;

        private Bitmap? outputBitmap;
        private Bitmap? preview;
        private Bitmap? previous;

        private const int BRIGHTNESS_SLIDER_DEFAULT = 0;
        private const int CONTRAST_SLIDER_DEFAULT = 100;
        private const int GAMMA_SLIDER_DEFAULT = 100;

        private Timer delayTimer = new Timer();
        private const int DELAY_INTERVAL = 500;

        private ConvolutionFilter? selectedFilter;

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            DisplayConvolutionFilterInfo(null);
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedFileName = openFileDialog.FileName;
                Bitmap image = new Bitmap(loadedFileName);
                inputImage.Image = image;
                outputImage.Image = image;
                outputBitmap = new Bitmap(loadedFileName);
                preview = new Bitmap(loadedFileName);
                resetButton.Enabled = true;
                undoButton.Enabled = false;
            }
            editingControlsTable.Enabled = true;
            customFilters.Enabled = true;
        }

        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            if (loadedFileName == null)
                return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            sfd.Title = "Save an Image";

            string timestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            sfd.FileName = System.IO.Path.GetFileNameWithoutExtension(loadedFileName) + "_" + timestamp;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                string ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();
                System.Drawing.Imaging.ImageFormat? format = null;
                switch (ext)
                {
                    case ".jpg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    default:
                        MessageBox.Show("Unsupported file format.");
                        return;
                }
                outputImage.Image.Save(fileName, format);
            }
        }


        private void ResetSliders(TrackBar? excepted = null)
        {
            if (excepted != brightnessSlider)
                brightnessSlider.Value = BRIGHTNESS_SLIDER_DEFAULT;
            if (excepted != contrastSlider)
                contrastSlider.Value = CONTRAST_SLIDER_DEFAULT;
            if (excepted != gammaSlider)
                gammaSlider.Value = GAMMA_SLIDER_DEFAULT;
        }
        private void ApplyChanges()
        {
            delayTimer.Dispose();
            if (preview == null)
                return;
            progressBar.Value = 0;
            if (outputBitmap != null)
                previous = (Bitmap)outputBitmap.Clone();
            else
                previous = (Bitmap)inputImage.Image.Clone();
            outputBitmap = (Bitmap)preview.Clone();
            outputImage.Image = outputBitmap;
            undoButton.Enabled = true;
            ResetSliders();
        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }
        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (previous != null)
            {
                outputBitmap = (Bitmap)previous.Clone();
                preview = (Bitmap)previous.Clone();
                outputImage.Image = outputBitmap;
            }
            undoButton.Enabled = false;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            outputBitmap = (Bitmap)inputImage.Image.Clone();
            preview = (Bitmap)inputImage.Image.Clone();
            outputImage.Image = outputBitmap;
        }


        #region Functional filters
        private void ApplyFunctionalFilter(Func<Color, Color> filter)
        {
            if (outputBitmap == null || preview == null)
                return;
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = outputBitmap.Width;
            for (int i = 0; i < outputBitmap.Width; i++)
            {
                 for (int j = 0; j < outputBitmap.Height; j++)
                 {
                     Color pixelColor = outputBitmap.GetPixel(i, j);
                     Color newPixelColor = filter(pixelColor);
                     preview.SetPixel(i, j, newPixelColor);
                 }
                 progressBar.Value++;
             }
            outputImage.Image = preview;
        }

        // Inversion
        private Color InvertColor(Color colorIn)
        {
            Color colorOut = Color.FromArgb(
                colorIn.A,
                (byte)(255 - colorIn.R),
                (byte)(255 - colorIn.G),
                (byte)(255 - colorIn.B)
            );
            return colorOut;
        }
        private void InversionButton_Click(object sender, EventArgs e)
        {
            ApplyFunctionalFilter(InvertColor);
            ApplyChanges();
        }

        // Brightness
        private Color AdjustBrightness(Color colorIn, int brightness)
        {
            Color colorOut = Color.FromArgb(
                colorIn.A,
                (byte)Math.Clamp(colorIn.R + brightness, 0, 255),
                (byte)Math.Clamp(colorIn.G + brightness, 0, 255),
                (byte)Math.Clamp(colorIn.B + brightness, 0, 255)
            );
            return colorOut;
        }
        private void OnDelayBrightnessTimerTick(object? sender, EventArgs e)
        {
            delayTimer.Dispose();
            if (sender == null)
                return;
            ApplyFunctionalFilter((Color) => AdjustBrightness(Color, brightnessSlider.Value));
        }
        private void BrightnessSlider_ValueChanged(object sender, EventArgs e)
        {
            if (brightnessSlider.Value == BRIGHTNESS_SLIDER_DEFAULT)
                return;
            ResetSliders(excepted: brightnessSlider);
            delayTimer.Dispose();
            delayTimer = new Timer();
            delayTimer.Interval = DELAY_INTERVAL;
            delayTimer.Tick += OnDelayBrightnessTimerTick;
            delayTimer.Start();
        }

        // Contrast
        private Color AdjustContrast(Color colorIn, double contrast)
        {
            Color colorOut = Color.FromArgb(
                colorIn.A,
                (byte)Math.Clamp(128 + contrast * (colorIn.R - 128), 0, 255),
                (byte)Math.Clamp(128 + contrast * (colorIn.G - 128), 0, 255),
                (byte)Math.Clamp(128 + contrast * (colorIn.B - 128), 0, 255)
            );
            return colorOut;
        }
        private void OnDelayContrastTimerTick(object? sender, EventArgs e)
        {
            delayTimer.Dispose();
            if (sender == null)
                return;
            double minimum = 0.2;
            double maximum = 1.8;
            double step = 0.1;
            double value = (double)contrastSlider.Value / contrastSlider.Maximum * (maximum - minimum) + minimum;
            value = Math.Round(value / step) * step;
            ApplyFunctionalFilter((Color) => AdjustContrast(Color, value));
        }
        private void ContrastSlider_ValueChanged(object sender, EventArgs e)
        {
            if (contrastSlider.Value == CONTRAST_SLIDER_DEFAULT)
                return;
            ResetSliders(excepted: contrastSlider);
            delayTimer.Dispose();
            delayTimer = new Timer();
            delayTimer.Interval = DELAY_INTERVAL;
            delayTimer.Tick += OnDelayContrastTimerTick;
            delayTimer.Start();
        }

        // Gamma
        private Color AdjustGamma(Color colorIn, double gamma)
        {
            Color colorOut = Color.FromArgb(
                colorIn.A,
                (byte)Math.Clamp(Math.Pow(colorIn.R / 255.0, gamma) * 255.0, 0, 255),
                (byte)Math.Clamp(Math.Pow(colorIn.G / 255.0, gamma) * 255.0, 0, 255),
                (byte)Math.Clamp(Math.Pow(colorIn.B / 255.0, gamma) * 255.0, 0, 255)
            );
            return colorOut;
        }
        private void OnDelayGammaTimerTick(object? sender, EventArgs e)
        {
            delayTimer.Dispose();
            if (sender == null)
                return;
            double minimum = 0.2;
            double maximum = 1.8;
            double step = 0.1;
            double value = (double)gammaSlider.Value / gammaSlider.Maximum * (maximum - minimum) + minimum;
            value = Math.Round(value / step) * step;
            ApplyFunctionalFilter((Color) => AdjustGamma(Color, value));
        }

        private void GammaSlider_ValueChanged(object sender, EventArgs e)
        {
            if (gammaSlider.Value == GAMMA_SLIDER_DEFAULT)
                return;
            ResetSliders(excepted: gammaSlider);
            delayTimer.Dispose();
            delayTimer = new Timer();
            delayTimer.Interval = DELAY_INTERVAL;
            delayTimer.Tick -= null;
            delayTimer.Tick += OnDelayGammaTimerTick;
            delayTimer.Start();
        }

        #endregion

        #region Convolution filters
        public class ConvolutionFilter
        {
            public string Name { get; set; }
            public double[,] Kernel { get; set; }
            public double Divisor { get; set; }
            public double Offset { get; set; }
            public Point Anchor { get; set; }

            public ConvolutionFilter(string name, double[,] kernel, double divisor = 1, double offset = 0, Point? anchor = null)
            {
                Name = name;
                Kernel = kernel;
                Divisor = divisor;
                Offset = offset;
                if (anchor != null)
                    Anchor = (Point)anchor;
                else
                {
                    int kernelHeight = kernel.GetLength(0);
                    int kernelWidth = kernel.GetLength(1);
                    Anchor = new Point(kernelWidth/2, kernelHeight/2);
                }
            }
        }
        private void UseConvolutionFilter(ConvolutionFilter cf)
        {
            ApplyConvolutionFilter(cf);
            ApplyChanges();
        }
        private void ApplyConvolutionFilter(ConvolutionFilter cf)
        {
            if (outputBitmap == null || preview == null)
                return;
            double[,] kernel = cf.Kernel;
            double divisor = cf.Divisor;
            double offset = cf.Offset;
            int kernelHeight = kernel.GetLength(0);
            int kernelWidth = kernel.GetLength(1);

            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = outputBitmap.Width;

            for (int x = 0; x < outputBitmap.Width; x++)
            {
                for (int y = 0; y < outputBitmap.Height; y++)
                {
                    double red = 0;
                    double green = 0;
                    double blue = 0;

                    for (int i = 0; i < kernelWidth; i++)
                    {
                        int currentX = x + i - cf.Anchor.X;
                        if (currentX < 0)
                            currentX = 0;
                        else if (currentX >= outputBitmap.Width)
                            currentX = outputBitmap.Width - 1;

                        for (int j = 0; j < kernelHeight; j++)
                        {
                            int currentY = y + j - cf.Anchor.Y;
                            if (currentY < 0)
                                currentY = 0;
                            else if (currentY >= outputBitmap.Height)
                                currentY = outputBitmap.Height - 1;

                            Color pixelColor = outputBitmap.GetPixel(currentX, currentY);

                            double kernelValue = kernel[j, i];
                            red += pixelColor.R * kernelValue;
                            green += pixelColor.G * kernelValue;
                            blue += pixelColor.B * kernelValue;
                        }
                    }

                    red = Math.Clamp(offset + red / divisor, 0, 255);
                    green = Math.Clamp(offset + green / divisor, 0, 255);
                    blue = Math.Clamp(offset + blue / divisor, 0, 255);

                    Color newPixelColor = Color.FromArgb((byte)255, (byte)red, (byte)green, (byte)blue);
                    preview.SetPixel(x, y, newPixelColor);
                }
                progressBar.Value++;
            }
            outputImage.Image = preview;
        }

        private void DisplayConvolutionFilterInfo(ConvolutionFilter? cf)
        {
            if (cf != null)
            {
                filterInformationLabel.Text = "Filter information";
                selectedFilter = cf;
                double[,] kernel = cf.Kernel;
                int kernelHeight = kernel.GetLength(0);
                int kernelWidth = kernel.GetLength(1);
                filterInformationMatrix.RowCount = kernelHeight;
                filterInformationMatrix.ColumnCount = kernelWidth;
                for (int x = 0; x < kernelWidth; x++)
                    for (int y = 0; y < kernelHeight; y++)
                        filterInformationMatrix.Rows[y].Cells[x].Value = kernel[y, x];
                filterNameInput.Text = cf.Name;
                kernelRowsInput.Text = kernelHeight.ToString();
                kernelColumnsInput.Text = kernelWidth.ToString();
                divisorInput.Text = cf.Divisor.ToString();
                offsetInput.Text = cf.Offset.ToString();
                anchorXInput.Text = cf.Anchor.X.ToString();
                anchorYInput.Text = cf.Anchor.Y.ToString();
            }
            else
            {
                filterInformationLabel.Text = "Create new filter";
                filterInformationMatrix.RowCount = 3;
                filterInformationMatrix.ColumnCount = 3;
                for (int x = 0; x < 3; x++)
                    for (int y = 0; y < 3; y++)
                        filterInformationMatrix.Rows[y].Cells[x].Value = (double)0;
                filterNameInput.Text = "new filter";
                kernelRowsInput.Text = "3";
                kernelColumnsInput.Text = "3";
                divisorInput.Text = "1";
                offsetInput.Text = "0";
                anchorXInput.Text = "1";
                anchorYInput.Text = "1";
            }
        }
        private void AutocomputeDivisorButton_Click(object sender, EventArgs e)
        {
            if (kernelRowsInput.Text == "" || kernelColumnsInput.Text == "")
                return;
            double divisor = 0;
            int kernelHeight = int.Parse(kernelRowsInput.Text);
            int kernelWidth = int.Parse(kernelColumnsInput.Text);
            for (int x = 0; x < kernelWidth; x++)
                for (int y = 0; y < kernelHeight; y++)
                {
                    double value;
                    try
                    {
                        value = (double)filterInformationMatrix.Rows[y].Cells[x].Value;
                    }
                    catch (Exception)
                    {
                        value = double.Parse((string)filterInformationMatrix.Rows[y].Cells[x].Value);
                    }
                    divisor += value;
                }
            divisorInput.Text = divisor.ToString();
        }

        private void SaveConvolutionFilterInfo()
        {
            string name = filterNameInput.Text;
            int kernelHeight = int.Parse(kernelRowsInput.Text);
            int kernelWidth = int.Parse(kernelColumnsInput.Text);
            double[,] kernel = new double[kernelHeight, kernelWidth];
            double divisor = double.Parse(divisorInput.Text);
            double offset = double.Parse(offsetInput.Text);
            Point anchor = new Point(int.Parse(anchorXInput.Text), int.Parse(anchorYInput.Text));
            for (int x = 0; x < kernelWidth; x++)
                for (int y = 0; y < kernelHeight; y++)
                {
                    double value;
                    try
                    {
                        value = (double)filterInformationMatrix.Rows[y].Cells[x].Value;
                    }
                    catch (Exception)
                    {
                        value = double.Parse((string)filterInformationMatrix.Rows[y].Cells[x].Value);
                    }
                    kernel[y, x] = value;
                }
            if (selectedFilter != null)
            {
                selectedFilter.Name = name;
                selectedFilter.Kernel = kernel;
                selectedFilter.Divisor = divisor;
                selectedFilter.Offset = offset;
                selectedFilter.Anchor = anchor;
                return;
            }
            ConvolutionFilter filter = new ConvolutionFilter(
                name: name,
                kernel: kernel,
                divisor: divisor,
                offset: offset,
                anchor: anchor
            );
            TableLayoutPanel filterLayout = new TableLayoutPanel();
            filterLayout.RowCount = 2;
            filterLayout.ColumnCount = 2;
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Label filterLabel = new Label();
            filterLabel.Text = filter.Name;
            filterLabel.Dock = DockStyle.Fill;
            filterLabel.TextAlign = ContentAlignment.MiddleCenter;
            Button filterButton = new Button();
            filterButton.Dock = DockStyle.Fill;
            filterButton.Text = "Apply";
            filterButton.Click += (sender, e) => UseConvolutionFilter(filter);
            Button inspectFilterButton = new Button();
            inspectFilterButton.Dock = DockStyle.Fill;
            inspectFilterButton.Text = "Inspect";
            inspectFilterButton.Click += (sender, e) => DisplayConvolutionFilterInfo(filter);
            filterLayout.Controls.Add(filterLabel);
            filterLayout.SetColumnSpan(filterLabel, 2);
            filterLayout.Controls.Add(filterButton);
            filterLayout.Controls.Add(inspectFilterButton);
            customFilters.Controls.Add(filterLayout);
        }
        private void FilterInformationSaveButton_Click(object sender, EventArgs e)
        {
            SaveConvolutionFilterInfo();
        }

        private void filterInformationNewButton_Click(object sender, EventArgs e)
        {
            selectedFilter = null;
            DisplayConvolutionFilterInfo(null);
        }

        private void KernelDimensions_TextChanged(object sender, EventArgs e)
        {
            if (kernelRowsInput.Text == "" || kernelColumnsInput.Text == "")
                return;
            int kernelHeight = int.Parse(kernelRowsInput.Text);
            int kernelWidth = int.Parse(kernelColumnsInput.Text);
            double[,] newKernel = new double[kernelHeight, kernelWidth];
            if (selectedFilter == null)
            {
                for (int y = 0; y < kernelHeight; y++)
                    for (int x = 0; x < kernelWidth; x++)
                        newKernel[y, x] = 0;
            }
            else
            {
                for (int y = 0; y < kernelHeight; y++)
                    for (int x = 0; x < kernelWidth; x++)
                    {
                        if (y < selectedFilter.Kernel.GetLength(0) && x < selectedFilter.Kernel.GetLength(1))
                            newKernel[y, x] = selectedFilter.Kernel[y, x];
                        else
                            newKernel[y, x] = 0;
                    }
            }
            filterInformationMatrix.RowCount = kernelHeight;
            filterInformationMatrix.ColumnCount = kernelWidth;
            for (int x = 0; x < kernelWidth; x++)
                for (int y = 0; y < kernelHeight; y++)
                    filterInformationMatrix.Rows[y].Cells[x].Value = newKernel[y, x];

        }


        // Blur
        ConvolutionFilter blurFilter = new(
            name: "Blur",
            kernel: new double[5, 5] {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            },
            divisor: 25
        );

        private void BlurButton_Click(object sender, EventArgs e)
        {
            UseConvolutionFilter(blurFilter);
        }

        // Gaussian smoothing
        ConvolutionFilter gaussianSmoothingFilter = new(
            name: "Gaussian smoothing",
            kernel: new double[5, 5] {
                { 0, 1, 2, 1, 0 },
                { 1, 4, 8, 4, 1 },
                { 2, 8, 16, 8, 2 },
                { 1, 4, 8, 4, 1 },
                { 0, 1, 2, 1, 0 }
            },
            divisor: 80
        );
        private void GaussianSmoothingButton_Click(object sender, EventArgs e)
        {
            UseConvolutionFilter(gaussianSmoothingFilter);
        }

        // Sharpen
        ConvolutionFilter sharpenFilter = new(
            name: "Sharpen",
            kernel: new double[3, 3] {
                { -1, -1, -1 },
                { -1, 9, -1 },
                { -1, -1, -1 }
            }
        );
        private void SharpenButton_Click(object sender, EventArgs e)
        {
            UseConvolutionFilter(sharpenFilter);
        }

        // Edge detection
        ConvolutionFilter edgeDetectionFilter = new(
            name: "Edge detection",
            kernel: new double[3, 3] {
                { -1, -1, -1 },
                { -1, 8, -1 },
                { -1, -1, -1 }
            }
        );
        private void EdgeDetectionButton_Click(object sender, EventArgs e)
        {
            UseConvolutionFilter (edgeDetectionFilter);
        }

        // Emboss
        ConvolutionFilter embossFilter = new(
            name: "Emboss",
            kernel: new double[3, 3] {
                { -1, 0, 1 },
                { -1, 1, 1 },
                { -1, 0, 1 }
            }
        );
        private void EmbossButton_Click(object sender, EventArgs e)
        {
            UseConvolutionFilter(embossFilter);
        }
        private void inspectBlurButton_Click(object sender, EventArgs e)
        {
            DisplayConvolutionFilterInfo(blurFilter);
        }

        private void inspectGaussianSmoothingButton_Click(object sender, EventArgs e)
        {
            DisplayConvolutionFilterInfo(gaussianSmoothingFilter);
        }

        private void inspectSharpenButton_Click(object sender, EventArgs e)
        {
            DisplayConvolutionFilterInfo(sharpenFilter);
        }

        private void inspectEdgeDetectionButton_Click(object sender, EventArgs e)
        {
            DisplayConvolutionFilterInfo(edgeDetectionFilter);
        }

        private void inspectEmbossButton_Click(object sender, EventArgs e)
        {
            DisplayConvolutionFilterInfo(embossFilter);
        }
        #endregion

        #region Lab task

        // Lab task

        private const int EDGE_DETECTION_THRESHOLD = 50;
        private void ApplyBiderectionalEdgeDetection()
        {
            if (outputBitmap == null || preview == null)
                return;

            double[,] verticalEdgeDetectionKernel = new double[3, 3]
            {
                { 0, -1, 0 },
                { 0, 1, 0 },
                { 0, 0, 0 }
            };

            double[,] horizontalEdgeDetectionKernel = new double[3, 3]
            {
                { 0, 0, 0 },
                { -1, 1, 0 },
                { 0, 0, 0 }
            };

            int kernelHeight = 3;
            int kernelWidth = 3;
            Point anchor = new Point(kernelHeight, kernelWidth);
            double divisor = 1;
            double offset = 0;

            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = outputBitmap.Width;

            for (int x = 0; x < outputBitmap.Width; x++)
            {
                for (int y = 0; y < outputBitmap.Height; y++)
                {
                    double red1 = 0;
                    double green1 = 0;
                    double blue1 = 0;

                    double red2 = 0;
                    double green2 = 0;
                    double blue2 = 0;

                    for (int i = 0; i < kernelWidth; i++)
                    {
                        int currentX = x + i - anchor.X;
                        if (currentX < 0)
                            currentX = 0;
                        else if (currentX >= outputBitmap.Width)
                            currentX = outputBitmap.Width - 1;

                        for (int j = 0; j < kernelHeight; j++)
                        {
                            int currentY = y + j - anchor.Y;
                            if (currentY < 0)
                                currentY = 0;
                            else if (currentY >= outputBitmap.Height)
                                currentY = outputBitmap.Height - 1;

                            Color pixelColor = outputBitmap.GetPixel(currentX, currentY);

                            double verticalKernelValue = verticalEdgeDetectionKernel[j, i];
                            double horizontalKernelValue = horizontalEdgeDetectionKernel[j, i];

                            red1 += pixelColor.R * verticalKernelValue;
                            green1 += pixelColor.G * verticalKernelValue;
                            blue1 += pixelColor.B * verticalKernelValue;

                            red2 += pixelColor.R * horizontalKernelValue;
                            green2 += pixelColor.G * horizontalKernelValue;
                            blue2 += pixelColor.B * horizontalKernelValue;
                        }
                    }

                    red1 = Math.Clamp(Math.Abs(offset + red1 / divisor), 0, 255);
                    green1 = Math.Clamp(Math.Abs(offset + green1 / divisor), 0, 255);
                    blue1 = Math.Clamp(Math.Abs(offset + blue1 / divisor), 0, 255);

                    red2 = Math.Clamp(Math.Abs(offset + red2 / divisor), 0, 255);
                    green2 = Math.Clamp(Math.Abs(offset + green2 / divisor), 0, 255);
                    blue2 = Math.Clamp(Math.Abs(offset + blue2 / divisor), 0, 255);

                    double[] values = new double[6]
                    {
                        red1, green1, blue1, red2, green2, blue2
                    };
                    if (values.Max() > EDGE_DETECTION_THRESHOLD)
                        preview.SetPixel(x, y, Color.White);
                    else
                        preview.SetPixel(x, y, Color.Black);
                }
                progressBar.Value++;
            }
            ApplyChanges();
        }

        private void bidirectionalEdgeDetectionButton_Click(object sender, EventArgs e)
        {
            ApplyBiderectionalEdgeDetection();
        }

        #endregion

        private int RgbToGreyscale(Color color)
        {
            return (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
        }
        private Color ConvertToGrayscale(Color colorIn)
        {
            int grayscale = RgbToGreyscale(colorIn);
            Color colorOut = Color.FromArgb(
               colorIn.A,
               grayscale,
               grayscale,
               grayscale
            );
            return colorOut;
        }
        private void GrayscaleButton_Click(object sender, EventArgs e)
        {
            ApplyFunctionalFilter(ConvertToGrayscale);
            ApplyChanges();
        }

        private Color RandomDithering(Color colorIn, int K = 4)
        {
            Color[] colors = new Color[4]
            {
                Color.Black,
                Color.DarkGray,
                Color.LightGray,
                Color.White
            };

            int factor = 256 / K;
            int grayscale = RgbToGreyscale(colorIn);

            int quantized = grayscale + (int)(256 * (random.NextDouble() - 0.5));
            quantized = Math.Clamp(quantized, 0, 255);

            int index = quantized / factor;
            
            Color colorOut = Color.FromArgb(
                colorIn.A,
                quantized,
                quantized,
                quantized
            );
            return colors[index];
        }

        private void randomDitheringButton_Click(object sender, EventArgs e)
        {
            ApplyFunctionalFilter((Color) => RandomDithering(Color));
            ApplyChanges();
        }
    }
}
