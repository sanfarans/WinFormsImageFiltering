﻿using System;
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
        string? loadedFileName = null;

        Bitmap? outputBitmap;
        Bitmap? preview;

        int brightnessSliderDefault = 0;
        int contrastSliderDefault = 100;
        int gammaSliderDefault = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
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
            }
            editingControlsTable.Enabled = true;
        }

        private void saveImageButton_Click(object sender, EventArgs e)
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


        private void resetSliders(TrackBar? excepted = null)
        {
            if (excepted != brightnessSlider)
                brightnessSlider.Value = brightnessSliderDefault;
            if (excepted != contrastSlider)
                contrastSlider.Value = contrastSliderDefault;
            if (excepted != gammaSlider)
                gammaSlider.Value = gammaSliderDefault;
        }
        private void applyChanges()
        {
            if (preview == null)
                return;
            progressBar.Value = 0;
            outputBitmap = (Bitmap)preview.Clone();
            outputImage.Image = outputBitmap;
            resetSliders();
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            applyChanges();
        }


        #region Functional filters
        private void applyFunctionalFilter(Func<Color, Color> filter)
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
        private Color invertColor(Color colorIn)
        {
            Color colorOut = Color.FromArgb(
                colorIn.A,
                (byte)(255 - colorIn.R),
                (byte)(255 - colorIn.G),
                (byte)(255 - colorIn.B)
            );
            return colorOut;
        }
        private void inversionButton_Click(object sender, EventArgs e)
        {
            applyFunctionalFilter(invertColor);
            applyChanges();
        }

        // Brightness
        private Color adjustBrightness(Color colorIn, int brightness)
        {
            Color colorOut = Color.FromArgb(
                colorIn.A,
                (byte)Math.Clamp(colorIn.R + brightness, 0, 255),
                (byte)Math.Clamp(colorIn.G + brightness, 0, 255),
                (byte)Math.Clamp(colorIn.B + brightness, 0, 255)
            );
            return colorOut;
        }

        private void brightnessSlider_ValueChanged(object sender, EventArgs e)
        {
            if (brightnessSlider.Value == brightnessSliderDefault)
                return;
            resetSliders(excepted: brightnessSlider);
            applyFunctionalFilter((Color) => adjustBrightness(Color, brightnessSlider.Value));
        }

        // Contrast
        private Color adjustContrast(Color colorIn, double contrast)
        {
            Color colorOut = Color.FromArgb(
                colorIn.A,
                (byte)Math.Clamp(128 + contrast * (colorIn.R - 128), 0, 255),
                (byte)Math.Clamp(128 + contrast * (colorIn.G - 128), 0, 255),
                (byte)Math.Clamp(128 + contrast * (colorIn.B - 128), 0, 255)
            );
            return colorOut;
        }
        private void contrastSlider_ValueChanged(object sender, EventArgs e)
        {
            if (contrastSlider.Value == contrastSliderDefault)
                return;
            resetSliders(excepted: contrastSlider);
            double minimum = 0.2;
            double maximum = 1.8;
            double step = 0.1;
            double value = (double)contrastSlider.Value / contrastSlider.Maximum * (maximum - minimum) + minimum;
            value = Math.Round(value / step) * step;
            applyFunctionalFilter((Color) => adjustContrast(Color, value));
        }

        // Gamma
        private Color adjustGamma(Color colorIn, double gamma)
        {
            Color colorOut = Color.FromArgb(
                colorIn.A,
                (byte)Math.Clamp(Math.Pow(colorIn.R / 255.0, gamma) * 255.0, 0, 255),
                (byte)Math.Clamp(Math.Pow(colorIn.G / 255.0, gamma) * 255.0, 0, 255),
                (byte)Math.Clamp(Math.Pow(colorIn.B / 255.0, gamma) * 255.0, 0, 255)
            );
            return colorOut;
        }

        private void gammaSlider_ValueChanged(object sender, EventArgs e)
        {
            if (gammaSlider.Value == gammaSliderDefault)
                return;
            resetSliders(excepted: gammaSlider);
            double minimum = 0.2;
            double maximum = 1.8;
            double step = 0.1;
            double value = (double)gammaSlider.Value / gammaSlider.Maximum * (maximum - minimum) + minimum;
            value = Math.Round(value / step) * step;
            applyFunctionalFilter((Color) => adjustGamma(Color, value));
        }

        #endregion

        #region Convolution filters
        private void applyConvolutionFilter(double[,] matrix, double divisor = 1)
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
        private void blurButton_Click(object sender, EventArgs e)
        {
            double[,] blurFilter = new double[5, 5] {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            };
            double divisor = 25;
            applyConvolutionFilter(blurFilter, divisor);
            applyChanges();
        }

        // Gaussian smoothing
        private void gaussianSmoothingButton_Click(object sender, EventArgs e)
        {
            double[,] gaussianSmoothingFilter = new double[5, 5] {
                { 0, 1, 2, 1, 0 },
                { 1, 4, 8, 4, 1 },
                { 2, 8, 16, 8, 2 },
                { 1, 4, 8, 4, 1 },
                { 0, 1, 2, 1, 0 }
            };
            double divisor = 80;
            applyConvolutionFilter(gaussianSmoothingFilter, divisor);
            applyChanges();
        }
    
        // Sharpen
        private void sharpenButton_Click(object sender, EventArgs e)
        {
            double[,] sharpenFilter = new double[3, 3] {
                { -1, -1, -1 },
                { -1, 9, -1 },
                { -1, -1, -1 }
            };
            applyConvolutionFilter(sharpenFilter);
            applyChanges();
        }

        // Edge detection
        private void edgeDetectionButton_Click(object sender, EventArgs e)
        {
            double[,] edgeDetectionFilter = new double[3, 3] {
                { -1, -1, -1 },
                { -1, 8, -1 },
                { -1, -1, -1 }
            };
            applyConvolutionFilter(edgeDetectionFilter);
            applyChanges();
        }

        // Emboss
        private void embossButton_Click(object sender, EventArgs e)
        {
            double[,] embossFilter = new double[3, 3] {
                { -1, 0, 1 },
                { -1, 1, 1 },
                { -1, 0, 1 }
            };
            applyConvolutionFilter(embossFilter);
            applyChanges();
        }

        #endregion
    }
}
