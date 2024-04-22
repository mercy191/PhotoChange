using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoChange.Common
{
    public class CombineHelper
    {
        static public Bitmap RotateImage(Bitmap image, float angle)
        {
            // Вычисление размеров нового изображения после поворота
            double radianAngle = angle * Math.PI / 180;
            double sin = Math.Abs(Math.Sin(radianAngle));
            double cos = Math.Abs(Math.Cos(radianAngle));
            int newWidth = (int)Math.Round(image.Width * cos + image.Height * sin);
            int newHeight = (int)Math.Round(image.Width * sin + image.Height * cos);

            // Создание Bitmap для нового изображения
            Bitmap rotatedImage = new Bitmap(newWidth, newHeight);

            // Получение Graphics объекта для рисования на новом изображении
            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                graphics.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2); // Смещение в центр
                graphics.RotateTransform((float)angle); // Поворот изображения
                graphics.TranslateTransform(-image.Width / 2, -image.Height / 2); // Смещение от центра
                graphics.DrawImage(image, new Point(0, 0));
            }

            return rotatedImage;
        }

        static public Bitmap ResizeImage(Bitmap image, int newWidth, int newHeight)
        {
            if (image.Width == newWidth && image.Height == newHeight) return image;

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            double nWidthFactor = (double)image.Width / (double)newWidth;
            double nHeightFactor = (double)image.Height / (double)newHeight;

            double fx, fy, nx, ny;
            int cx, cy, fr_x, fr_y;
            Color color1 = new Color();
            Color color2 = new Color();
            Color color3 = new Color();
            Color color4 = new Color();
            byte nRed, nGreen, nBlue, nAlpha;

            byte bp1, bp2;

            for (int x = 0; x < newImage.Width; ++x)
            {
                for (int y = 0; y < newImage.Height; ++y)
                {

                    fr_x = (int)Math.Floor(x * nWidthFactor);
                    fr_y = (int)Math.Floor(y * nHeightFactor);
                    cx = fr_x + 1;
                    if (cx >= image.Width) cx = fr_x;
                    cy = fr_y + 1;
                    if (cy >= image.Height) cy = fr_y;
                    fx = x * nWidthFactor - fr_x;
                    fy = y * nHeightFactor - fr_y;
                    nx = 1.0 - fx;
                    ny = 1.0 - fy;

                    color1 = image.GetPixel(fr_x, fr_y);
                    color2 = image.GetPixel(cx, fr_y);
                    color3 = image.GetPixel(fr_x, cy);
                    color4 = image.GetPixel(cx, cy);

                    // Alpha
                    bp1 = (byte)(nx * color1.A + fx * color2.A);

                    bp2 = (byte)(nx * color3.A + fx * color4.A);

                    nAlpha = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    // Blue
                    bp1 = (byte)(nx * color1.B + fx * color2.B);

                    bp2 = (byte)(nx * color3.B + fx * color4.B);

                    nBlue = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    // Green
                    bp1 = (byte)(nx * color1.G + fx * color2.G);

                    bp2 = (byte)(nx * color3.G + fx * color4.G);

                    nGreen = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    // Red
                    bp1 = (byte)(nx * color1.R + fx * color2.R);

                    bp2 = (byte)(nx * color3.R + fx * color4.R);

                    nRed = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    newImage.SetPixel(x, y, Color.FromArgb(nAlpha, nRed, nGreen, nBlue));
                }              
            }
            return newImage;
        }

        static public void CombineImage(Bitmap image1, Bitmap image2)
        {
            Color color1;
            Color color2;
            for (int x = 0; x < image1.Width; ++x)
            {
                for (int y = 0; y < image1.Height; ++y)
                {
                    color1 = image1.GetPixel(x, y);
                    color2 = image2.GetPixel(x, y);

                    int nPixelA = ((color1.A * color1.A) >> 8) + (((255 - color1.A) * color2.A) >> 8);
                    int nPixelR = ((color1.A * color1.R) >> 8) + (((255 - color1.A) * color2.R) >> 8);
                    int nPixelG = ((color1.A * color1.G) >> 8) + (((255 - color1.A) * color2.G) >> 8);
                    int nPixelB = ((color1.A * color1.B) >> 8) + (((255 - color1.A) * color2.B) >> 8);

                    image1.SetPixel(x, y, Color.FromArgb(nPixelA, nPixelR, nPixelG, nPixelB));
                }
            }
        }
    }
}
