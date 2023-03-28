using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WInFormsImageFiltering
{
    internal class ColorWheel
    {

        static public Bitmap GenerateColorWheel(int N = 512, int V = 1)
        {
            Bitmap bitmap = new Bitmap(N, N);

            double radius = N / 2.0;
            double center = N / 2.0;

            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    double dx = x - center;
                    double dy = y - center;
                    double distance = Math.Sqrt(dx * dx + dy * dy);

                    if (distance <= radius)
                    {
                        double hue = Math.Atan2(dy, dx);
                        if (hue < 0)
                        {
                            hue += 2 * Math.PI;
                        }

                        hue /= 2 * Math.PI;
                        double saturation = distance / radius;

                        Color color = FromHSV(hue, saturation, V);
                        bitmap.SetPixel(x, y, color);
                    }
                }
            }
            return bitmap;
        }


        static Color FromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue * 6));
            double f = hue * 6 - hi;
            double p = value * (1 - saturation);
            double q = value * (1 - f * saturation);
            double t = value * (1 - (1 - f) * saturation);

            byte v = Convert.ToByte(value * 255);
            byte p2 = Convert.ToByte(p * 255);
            byte q2 = Convert.ToByte(q * 255);
            byte t2 = Convert.ToByte(t * 255);

            switch (hi % 6)
            {
                case 0: return Color.FromArgb(255, v, t2, p2);
                case 1: return Color.FromArgb(255, q2, v, p2);
                case 2: return Color.FromArgb(255, p2, v, t2);
                case 3: return Color.FromArgb(255, p2, q2, v);
                case 4: return Color.FromArgb(255, t2, p2, v);
                default: return Color.FromArgb(255, v, p2, q2);
            }
        }
    }
}
