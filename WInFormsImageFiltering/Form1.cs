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

        private void inversionButton_Click(object sender, EventArgs e)
        {
            applyFunctionalFilter(invertColor);
            applyChanges();
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
            applyFunctionalFilter((Color) => adjustBrightness(Color, brightnessSlider.Value));
        }

        private void resetSliders()
        {
            brightnessSlider.Value = 0;
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
    }
}
