using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoChange.Common
{
    public class ImageHelper
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

                    int nPixelA = Math.Min(255, color1.A + color2.A);
                    int nPixelR = Math.Min(255, color1.R + color2.R);
                    int nPixelG = Math.Min(255, color1.G + color2.G);
                    int nPixelB = Math.Min(255, color1.B + color2.B);

                    image1.SetPixel(x, y, Color.FromArgb(nPixelA, nPixelR, nPixelG, nPixelB));
                }
            }
        }

        static public void SetBrightness(Bitmap oldImage, Bitmap newImage, int brightness)
        {
            if (brightness < -255) brightness = -255;
            if (brightness > 255) brightness = 255;
            Color color1;
            for (int i = 0; i < oldImage.Width; i++)
            {
                for (int j = 0; j < oldImage.Height; j++)
                {
                    color1 = oldImage.GetPixel(i, j);
                    int cR = color1.R + brightness;
                    int cG = color1.G + brightness;
                    int cB = color1.B + brightness;

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    newImage.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
        }

        static public void SetContrast(Bitmap oldImage, Bitmap newImage, double contrast)
        {
            if (contrast < -127) contrast = -127;
            if (contrast > 127) contrast = 127;
            contrast = (127.0 + contrast) / 127.0;
            contrast *= contrast;
            Color color1;
            Color color2;
            for (int i = 0; i < oldImage.Width; i++)
            {
                for (int j = 0; j < oldImage.Height; j++)
                {
                    color1 = oldImage.GetPixel(i, j);
                    color2 = newImage.GetPixel(i, j);
                    double pR = color1.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    pR = Math.Max(0, Math.Min(255, pR));

                    double pG = color1.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    pG = Math.Max(0, Math.Min(255, pG));

                    double pB = color1.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    pB = Math.Max(0, Math.Min(255, pB));

                    newImage.SetPixel(i, j, Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }
        }

        static public void SetRBalance(Bitmap oldImage, Bitmap newImage, int balance)
        {
            if (balance < -255) balance = -255;
            if (balance > 255) balance = 255;
            Color c;
            for (int i = 0; i < oldImage.Width; i++)
            {
                for (int j = 0; j < oldImage.Height; j++)
                {
                    c = oldImage.GetPixel(i, j);
                    int cR = c.R + balance;
                    int cG = c.G;
                    int cB = c.B;
                    cB = Math.Max(0, Math.Min(255, cB));

                    newImage.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
        }

        static public void SetGBalance(Bitmap oldImage, Bitmap newImage, int balance)
        { 
            if (balance < -255) balance = -255;
            if (balance > 255) balance = 255;
            Color c;
            for (int i = 0; i < oldImage.Width; i++)
            {
                for (int j = 0; j < oldImage.Height; j++)
                {
                    c = oldImage.GetPixel(i, j);
                    int cR = c.R;
                    int cG = c.G + balance;
                    int cB = c.B;
                    cG = Math.Max(0, Math.Min(255, cG));

                    newImage.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
        }

        static public void SetBBalance(Bitmap oldImage, Bitmap newImage, int balance)
        {
            if (balance < -255) balance = -255;
            if (balance > 255) balance = 255;
            Color c;
            for (int i = 0; i < oldImage.Width; i++)
            {
                for (int j = 0; j < oldImage.Height; j++)
                {
                    c = oldImage.GetPixel(i, j);
                    int cR = c.R;
                    int cG = c.G;
                    int cB = c.B + balance;
                    cR = Math.Max(0, Math.Min(255, cR));

                    newImage.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
        }

        static public void SetGamma(Bitmap oldImage, Bitmap newImage, float gamma)
        {
            Color c;
            for (int i = 0; i < oldImage.Width; i++)
            {
                for (int j = 0; j < oldImage.Height; j++)
                {
                    c = oldImage.GetPixel(i, j);
                    int cR = (int)(Math.Pow(c.R / 255.0, 1.0 / gamma) * 255.0);
                    int cG = (int)(Math.Pow(c.G / 255.0, 1.0 / gamma) * 255.0);
                    int cB = (int)(Math.Pow(c.B / 255.0, 1.0 / gamma) * 255.0);

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    newImage.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
        }

        static public void SetSaturation(Bitmap oldImage, Bitmap newImage, int saturation)
        {
            Color c;
            for (int i = 0; i < oldImage.Width; i++)
            {
                for (int j = 0; j < oldImage.Height; j++)
                {
                    c = oldImage.GetPixel(i, j);
                    int cR = c.R;
                    int cG = c.G;
                    int cB = c.B;
                    int cGr = (int)(c.R * 0.2126f + c.G * 0.7152f + c.B * 0.0722f);

                    cR += (cR - cGr) * saturation / 255;
                    cG += (cG - cGr) * saturation / 255;
                    cB += (cB - cGr) * saturation / 255;

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    newImage.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
        }

        static public void ColorCorrection(Bitmap oldImage, Bitmap newImage, int Rbalance, int Gbalance, int Bbalance, int brightness, int saturation, int contrast, float gamma) 
        {
            float contr = (127.0f + contrast) / 127.0f;
            contr *= contr;
            Color c;
            for (int i = 0; i < oldImage.Width; i++)
            {
                for (int j = 0; j < oldImage.Height; j++)
                {
                    c = oldImage.GetPixel(i, j);
                    int cR = c.R + brightness;
                    int cG = c.G + brightness;
                    int cB = c.B + brightness;

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    cR += Rbalance;
                    cG += Gbalance;
                    cB += Bbalance;

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    cR = (int)(Math.Pow(cR / 255.0, 1.0 / gamma) * 255.0);
                    cG = (int)(Math.Pow(cG / 255.0, 1.0 / gamma) * 255.0);
                    cB = (int)(Math.Pow(cB / 255.0, 1.0 / gamma) * 255.0);

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    int cGr = (int)(cR * 0.2126f + cG * 0.7152f + cB * 0.0722f);
                    cR += (cR - cGr) * saturation / 255;
                    cG += (cG - cGr) * saturation / 255;
                    cB += (cB - cGr) * saturation / 255;

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    double pR = cR / 255.0;
                    pR -= 0.5;
                    pR *= contr;
                    pR += 0.5;
                    pR *= 255;
                    pR = Math.Max(0, Math.Min(255, pR));

                    double pG = cG / 255.0;
                    pG -= 0.5;
                    pG *= contr;
                    pG += 0.5;
                    pG *= 255;
                    pG = Math.Max(0, Math.Min(255, pG));

                    double pB = cB / 255.0;
                    pB -= 0.5;
                    pB *= contr;
                    pB += 0.5;
                    pB *= 255;
                    pB = Math.Max(0, Math.Min(255, pB));

                    newImage.SetPixel(i, j, Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }
        }
    }
}
