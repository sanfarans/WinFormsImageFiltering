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

        Bitmap outputBitmap;
        Bitmap preview;

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
                Bitmap image = new Bitmap(openFileDialog.FileName);
                inputImage.Image = image;
                outputImage.Image = image;
                outputBitmap = new Bitmap(openFileDialog.FileName);
                preview = new Bitmap(openFileDialog.FileName);
            }
            editingControlsTable.Enabled = true;
        }

        private void applyFunctionalFilter(Func<Color, Color> filter)
        {
            if (outputBitmap == null)
                return;
            {
                for (int i = 0; i < outputBitmap.Width; i++)
                {
                    for (int j = 0; j < outputBitmap.Height; j++)
                    {
                        Color pixelColor = outputBitmap.GetPixel(i, j);
                        Color newPixelColor = filter(pixelColor);
                        preview.SetPixel(i, j, newPixelColor);
                    }
                }
            }
            outputImage.Image = preview;
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
            outputBitmap = (Bitmap)preview.Clone();
            outputImage.Image = outputBitmap;
            resetSliders();
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            applyChanges();
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
    }
}
