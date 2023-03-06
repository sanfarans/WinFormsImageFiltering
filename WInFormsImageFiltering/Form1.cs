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

        public Form1()
        {
            InitializeComponent();
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
        private void ApplyConvolutionFilter(double[,] matrix, double divisor = 1)
        {
            if (outputBitmap == null || preview == null)
                return;

            int matrixWidth = matrix.GetLength(0);
            int matrixHeight = matrix.GetLength(1);
            int halfWidth = matrixWidth / 2;
            int halfHeight = matrixHeight / 2;

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

                    for (int i = 0; i < matrixWidth; i++)
                    {
                        int currentX = x + i - halfWidth;
                        if (currentX < 0)
                            currentX = 0;
                        else if (currentX >= outputBitmap.Width)
                            currentX = outputBitmap.Width - 1;

                        for (int j = 0; j < matrixHeight; j++)
                        {
                            int currentY = y + j - halfHeight;
                            if (currentY < 0)
                                currentY = 0;
                            else if (currentY >= outputBitmap.Height)
                                currentY = outputBitmap.Height - 1;

                            Color pixelColor = outputBitmap.GetPixel(currentX, currentY);

                            double matrixValue = matrix[i, j];
                            red += pixelColor.R * matrixValue;
                            green += pixelColor.G * matrixValue;
                            blue += pixelColor.B * matrixValue;
                        }
                    }

                    red = Math.Clamp(red / divisor, 0, 255);
                    green = Math.Clamp(green / divisor, 0, 255);
                    blue = Math.Clamp(blue / divisor, 0, 255);

                    Color newPixelColor = Color.FromArgb((byte)255, (byte)red, (byte)green, (byte)blue);
                    preview.SetPixel(x, y, newPixelColor);
                }
                progressBar.Value++;
            }
            outputImage.Image = preview;
        }

        // Blur
        private void BlurButton_Click(object sender, EventArgs e)
        {
            double[,] blurFilter = new double[5, 5] {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            };
            double divisor = 25;
            ApplyConvolutionFilter(blurFilter, divisor);
            ApplyChanges();
        }

        // Gaussian smoothing
        private void GaussianSmoothingButton_Click(object sender, EventArgs e)
        {
            double[,] gaussianSmoothingFilter = new double[5, 5] {
                { 0, 1, 2, 1, 0 },
                { 1, 4, 8, 4, 1 },
                { 2, 8, 16, 8, 2 },
                { 1, 4, 8, 4, 1 },
                { 0, 1, 2, 1, 0 }
            };
            double divisor = 80;
            ApplyConvolutionFilter(gaussianSmoothingFilter, divisor);
            ApplyChanges();
        }
    
        // Sharpen
        private void SharpenButton_Click(object sender, EventArgs e)
        {
            double[,] sharpenFilter = new double[3, 3] {
                { -1, -1, -1 },
                { -1, 9, -1 },
                { -1, -1, -1 }
            };
            ApplyConvolutionFilter(sharpenFilter);
            ApplyChanges();
        }

        // Edge detection
        private void EdgeDetectionButton_Click(object sender, EventArgs e)
        {
            double[,] edgeDetectionFilter = new double[3, 3] {
                { -1, -1, -1 },
                { -1, 8, -1 },
                { -1, -1, -1 }
            };
            ApplyConvolutionFilter(edgeDetectionFilter);
            ApplyChanges();
        }

        // Emboss
        private void EmbossButton_Click(object sender, EventArgs e)
        {
            double[,] embossFilter = new double[3, 3] {
                { -1, 0, 1 },
                { -1, 1, 1 },
                { -1, 0, 1 }
            };
            ApplyConvolutionFilter(embossFilter);
            ApplyChanges();
        }

        #endregion


    }
}
