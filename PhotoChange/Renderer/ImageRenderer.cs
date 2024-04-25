using PhotoChange.Common;
using System.Diagnostics.Contracts;
using System.Drawing.Imaging;
using System.IO;

namespace PhotoChange.Renderer
{
    /// <summary>
    /// It stores all the settings of the original image, 
    /// and also allows you to change the settings in accordance with the display mode.
    /// </summary>
	public class ImageRenderer
    {
        public ImageRenderer()
        {
            _path = string.Empty;
            _originalImage = new Bitmap(1, 1);
            _scaleImage = new Bitmap(1, 1);
            _editList = new List<Bitmap>();
            _staticImageWidth = 1;
            _staticImageHeight = 1;
            _editListIterator = -1;
            _scaleFactor = 1;
            _scalePercent = 100;
            _widthRetreat = 0;
            _heightRetreat = 0;
            _rotateAngle = 0;
        }

        /// <param name="path">Image path.</param>
        public ImageRenderer(string path)
        {
            _path = path;          
            _originalImage = new Bitmap(path);
            _scaleImage = new Bitmap(_originalImage);
            _editList = [new Bitmap(_originalImage)];
            _staticImageWidth = _originalImage.Width;
            _staticImageHeight = _originalImage.Height;
            _editListIterator = 0;
            _scaleFactor = 1;
            _scalePercent = 100;
            _widthRetreat = 0;
            _heightRetreat = 0;
            _rotateAngle = 0;
        }

        public ImageRenderer(Bitmap image)
        {
            _path = string.Empty;
            _originalImage = new Bitmap(image);
            _scaleImage = new Bitmap(_originalImage);
            _editList = [new Bitmap(_originalImage)];
            _staticImageWidth = _originalImage.Width;
            _staticImageHeight = _originalImage.Height;
            _editListIterator = 0;
            _scaleFactor = 1;
            _scalePercent = 100;
            _widthRetreat = 0;
            _heightRetreat = 0;
            _rotateAngle = 0;
        }

        /// <summary>
        /// Original size image.
        /// </summary>
        public Bitmap OriginalImage
        {
            get => _originalImage;
            set
            {
                if (_originalImage != null && _originalImage != value)
                    _originalImage.Dispose();
                _originalImage = value;
            }
        }

        /// <summary>
        /// Current image.
        /// </summary>
        public Bitmap ScaleImage
        {
            get => _scaleImage; 
            set
            {
                if (_scaleImage != null && _scaleImage != value ) 
                    _scaleImage.Dispose();
                _scaleImage = value;
            }
        }

        /// <summary>
        /// Widht of not rotated original image.
        /// </summary>
        public int StaticImageWidth
        {
            get => _staticImageWidth;
            set => _staticImageWidth = value;
        }

        /// <summary>
        /// Height of not rotated original image.
        /// </summary>
        public int StaticImageHeight
        {
            get => _staticImageHeight;
            set => _staticImageHeight = value;
        }

        /// <summary>
        /// The list stores all image changes.
        /// </summary>
        public List<Bitmap> EditList
        {
            get => _editList;          
        }

        /// <summary>
        /// Indicates the current item in the list of changes.
        /// </summary>
        public int EditListIterator
        {
            get => _editListIterator; 
            set => _editListIterator = value;
        }

        /// <summary>
        /// Indicates the path to the image.
        /// </summary>
        public string Path
        {
            get => _path; 
            set => _path = value;
        }

        /// <summary>
        /// Image proportionality coefficient.
        /// </summary>
        public float ScaleFactor
        {
            get => _scaleFactor;
            set
            {
                _scaleFactor = value;
                _scalePercent = (float)(100.0f / _scaleFactor);
            }
        }

        /// <summary>
        /// Image scalability percentage.
        /// </summary>
        public float ScalePercent
        {
            get => _scalePercent;
            set
            {
                _scalePercent = value;
                _scaleFactor = (float)(100.0f / _scalePercent);
            }
        }

        /// <summary>
        /// Horizontal retreat from the edges of the canvas.
        /// </summary>
        public float WidthRetreat
        {
            get => _widthRetreat; 
            set => _widthRetreat = value;
        }

        /// <summary>
        /// Vertical retreat from the edges of the canvas.
        /// </summary>
        public float HeightRetreat
        {
            get => _heightRetreat; 
            set => _heightRetreat = value;
        }

        public float RotateAngle
        {
            get => _rotateAngle;
            set
            {
                _rotateAngle = value;
                if (_rotateAngle >= 360)
                    _rotateAngle -= 360;
            } 
        }

        public enum ColorFilterTypes
        {
            Red,
            Green,
            Blue,
            All
        }

        public enum ColorChannelTypes
        {
            RBG,
            BGR,
            BRG,
            GRB,
            GBR
        }

        private Bitmap _scaleImage;
        private Bitmap _originalImage;
        private List<Bitmap> _editList;
        private int _staticImageWidth;
        private int _staticImageHeight;
        private int _editListIterator;
        private string _path;
        private float _scaleFactor;
        private float _scalePercent;
        private float _widthRetreat;
        private float _heightRetreat;
        private float _rotateAngle;
        public void Dispose()
        {
            foreach (var item in _editList)
                item.Dispose();
            _editList.Clear();
            _editListIterator = -1;
            _scaleImage.Dispose();
            _originalImage.Dispose();
        }

        /// <param name="width">Canvas width.</param>
        /// <param name="height">Canvas height.</param>
        public void CalculateScaleFactor(int width, int height)
        {
            ScaleFactor = (float)OriginalImage.Width / width > (float)OriginalImage.Height / height
                ? (float)OriginalImage.Width / width : (float)OriginalImage.Height / height;
        }

        /// <param name="width">Canvas width.</param>
        /// <param name="height">Canvas height.</param>
        public void CalculateRetreat(int width, int height)
        {
            WidthRetreat = (width - ScaleImage.Width) / 2;
            HeightRetreat = (height - ScaleImage.Height) / 2;
        }

        /// <param name="point">Point position on screen</param>
        public PointF ConvertToProportions(PointF point)
        {
            return new PointF(ConvertXToProportions(point.X), ConvertYToProportions(point.Y));
        }

        /// <param name="x">X position on screen</param>
        public float ConvertXToProportions(float x)
        {
            return (x - WidthRetreat) * ScaleFactor;
        }

        /// <param name="y">Y position on screen</param>
        public float ConvertYToProportions(float y)
        {
            return (y - HeightRetreat) * ScaleFactor;
        }

        public void EditScale()
        {
            int newWidth = (int)(OriginalImage.Width * ScalePercent / 100);
            int newHeight = (int)(OriginalImage.Height * ScalePercent / 100);
            Bitmap newImage = new Bitmap(newWidth, newHeight);

            double nWidthFactor = (double)OriginalImage.Width / (double)newWidth;
            double nHeightFactor = (double)OriginalImage.Height / (double)newHeight;

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
                    if (cx >= OriginalImage.Width) cx = fr_x;
                    cy = fr_y + 1;
                    if (cy >= OriginalImage.Height) cy = fr_y;
                    fx = x * nWidthFactor - fr_x;
                    fy = y * nHeightFactor - fr_y;
                    nx = 1.0 - fx;
                    ny = 1.0 - fy;

                    color1 = OriginalImage.GetPixel(fr_x, fr_y);
                    color2 = OriginalImage.GetPixel(cx, fr_y);
                    color3 = OriginalImage.GetPixel(fr_x, cy);
                    color4 = OriginalImage.GetPixel(cx, cy);

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
            ScaleImage = newImage;
        }

        /// <param name="newWidth">New width of image.</param>
        /// <param name="newHeight">New height of image.</param>
        public void Resize(int newWidth, int newHeight)
        {
            if (newWidth != 0 && newHeight != 0)
            {
                Bitmap newImage = new Bitmap(newWidth, newHeight);

                double nWidthFactor = (double)OriginalImage.Width / (double)newWidth;
                double nHeightFactor = (double)OriginalImage.Height / (double)newHeight;

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
                        if (cx >= OriginalImage.Width) cx = fr_x;
                        cy = fr_y + 1;
                        if (cy >= OriginalImage.Height) cy = fr_y;
                        fx = x * nWidthFactor - fr_x;
                        fy = y * nHeightFactor - fr_y;
                        nx = 1.0 - fx;
                        ny = 1.0 - fy;

                        color1 = OriginalImage.GetPixel(fr_x, fr_y);
                        color2 = OriginalImage.GetPixel(cx, fr_y);
                        color3 = OriginalImage.GetPixel(fr_x, cy);
                        color4 = OriginalImage.GetPixel(cx, cy);

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

                        newImage.SetPixel(x, y, System.Drawing.Color.FromArgb(nAlpha, nRed, nGreen, nBlue));
                    }
                }
                OriginalImage = newImage;
            }
        }

        /// <param name="angle">Angle of rotation.</param>
        public void Rotate(float angle)
        {
            // Вычисление размеров нового изображения после поворота
            RotateAngle += angle;
            double radianAngle = RotateAngle * Math.PI / 180;
            double sin = Math.Abs(Math.Sin(radianAngle));
            double cos = Math.Abs(Math.Cos(radianAngle));
            int newWidth = (int)Math.Round(StaticImageWidth * cos + StaticImageHeight * sin);
            int newHeight = (int)Math.Round(StaticImageWidth * sin + StaticImageHeight * cos);

            // Создание Bitmap для нового изображения
            Bitmap rotatedImage = new Bitmap(newWidth, newHeight);

            // Получение Graphics объекта для рисования на новом изображении
            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                graphics.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2); // Смещение в центр
                graphics.RotateTransform((float)angle); // Поворот изображения
                graphics.TranslateTransform(-OriginalImage.Width / 2, -OriginalImage.Height / 2); // Смещение от центра
                graphics.DrawImage(OriginalImage, new Point(0, 0));
            }

            OriginalImage = rotatedImage;
            EditList.Add(new Bitmap(OriginalImage));
            EditListIterator += 1;
        }

        /// <param name="flipType">Type of rotate or flip filter.</param>
        public void Flip(RotateFlipType flipType)
        {
            OriginalImage.RotateFlip(flipType);
            EditList.Add(new Bitmap(OriginalImage));
            EditListIterator += 1;
        }       

        public void SetGrayscale()
        {
            Color color;
            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    color = OriginalImage.GetPixel(i, j);
                    byte gray = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);

                    OriginalImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            EditList.Add(new Bitmap(OriginalImage));
            EditListIterator += 1;
        }      

        /// <param name="colorFilterType">Type of color filter</param>
        public void SetColorFilter(ColorFilterTypes colorFilterType)
        {
            Color color;
            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    color = OriginalImage.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;
                    if (colorFilterType == ColorFilterTypes.Red)
                    {
                        nPixelR = color.R;
                        nPixelG = color.G - 255;
                        nPixelB = color.B - 255;
                    }
                    else if (colorFilterType == ColorFilterTypes.Green)
                    {
                        nPixelR = color.R - 255;
                        nPixelG = color.G;
                        nPixelB = color.B - 255;
                    }
                    else if (colorFilterType == ColorFilterTypes.Blue)
                    {
                        nPixelR = color.R - 255;
                        nPixelG = color.G - 255;
                        nPixelB = color.B;
                    }
                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    OriginalImage.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }

            EditList.Add(new Bitmap(OriginalImage));
            EditListIterator += 1;
        }      

        /// <param name="colorFilterType">Type of color filter</param>
        public void SetInvert(ColorFilterTypes colorFilterType)
        {
            Color color;
            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    color = OriginalImage.GetPixel(i, j);
                    if (colorFilterType == ColorFilterTypes.Red)
                    {
                        OriginalImage.SetPixel(i, j, Color.FromArgb(255 - color.R, color.G, color.B));
                    }
                    else if (colorFilterType == ColorFilterTypes.Green)
                    {
                        OriginalImage.SetPixel(i, j, Color.FromArgb(color.R, 255 - color.G, color.B));
                    }
                    else if (colorFilterType == ColorFilterTypes.Blue)
                    {
                        OriginalImage.SetPixel(i, j, Color.FromArgb(color.R, color.G, 255 - color.B));
                    }
                    else if (colorFilterType == ColorFilterTypes.All)
                    {
                        OriginalImage.SetPixel(i, j, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                    }                    
                }
            }

            EditList.Add(new Bitmap(OriginalImage));
            EditListIterator += 1;
        }

        /// <param name="colorChannelType">Type of color channel.</param>
        public void SwitchColorChannel(ColorChannelTypes colorChannelType)
        {
            Color color;
            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    color = OriginalImage.GetPixel(i, j);
                    if (colorChannelType == ColorChannelTypes.RBG)
                        OriginalImage.SetPixel(i, j, Color.FromArgb(color.R, color.B, color.G));

                    else if (colorChannelType == ColorChannelTypes.BGR)
                        OriginalImage.SetPixel(i, j, Color.FromArgb(color.B, color.G, color.R));

                    else if (colorChannelType == ColorChannelTypes.BRG)
                        OriginalImage.SetPixel(i, j, Color.FromArgb(color.B, color.R, color.G));

                    else if (colorChannelType == ColorChannelTypes.GRB)
                        OriginalImage.SetPixel(i, j, Color.FromArgb(color.G, color.R, color.B));

                    else if (colorChannelType == ColorChannelTypes.GBR)
                        OriginalImage.SetPixel(i, j, Color.FromArgb(color.G, color.B, color.R));
                }
            }

            EditList.Add(new Bitmap(OriginalImage));
            EditListIterator += 1;
        }

        /// <param name="colorCorrectionHelper">A class that stores changes received from the user.</param>
        public void ColorCorrection(ColorCorrectionHelper colorCorrectionHelper)
        {
            if (!colorCorrectionHelper.IsChanged) return;

            float contr = (127.0f + colorCorrectionHelper.Contrast) / 127.0f;
            contr *= contr;
            Color c;
            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    c = OriginalImage.GetPixel(i, j);
                    int cR = c.R + colorCorrectionHelper.Brightness;
                    int cG = c.G + colorCorrectionHelper.Brightness;
                    int cB = c.B + colorCorrectionHelper.Brightness;

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    cR += colorCorrectionHelper.R;
                    cG += colorCorrectionHelper.G;
                    cB += colorCorrectionHelper.B;

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    cR = (int)(Math.Pow(cR / 255.0, 1.0 / colorCorrectionHelper.Gamma) * 255.0);
                    cG = (int)(Math.Pow(cG / 255.0, 1.0 / colorCorrectionHelper.Gamma) * 255.0);
                    cB = (int)(Math.Pow(cB / 255.0, 1.0 / colorCorrectionHelper.Gamma) * 255.0);

                    cR = Math.Max(0, Math.Min(255, cR));
                    cG = Math.Max(0, Math.Min(255, cG));
                    cB = Math.Max(0, Math.Min(255, cB));

                    int cGr = (int)(cR * 0.2126f + cG * 0.7152f + cB * 0.0722f);
                    cR += (cR - cGr) * colorCorrectionHelper.Saturation / 255;
                    cG += (cG - cGr) * colorCorrectionHelper.Saturation / 255;
                    cB += (cB - cGr) * colorCorrectionHelper.Saturation / 255;

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

                    OriginalImage.SetPixel(i, j, Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }

            EditList.Add(new Bitmap(OriginalImage));
            EditListIterator += 1;
        }

        public Histogram CalculateHistogram()
        {
            Histogram histogram = new Histogram();

            int[] brightnessValuesRed = new int[256];
            int[] brightnessValuesGreen = new int[256];
            int[] brightnessValuesBlue = new int[256];
            int[] brightnessValuesGray = new int[256];

            for (int y = 0; y < OriginalImage.Height; y++)
            {
                for (int x = 0; x < OriginalImage.Width; x++)
                {
                    Color pixelColor = OriginalImage.GetPixel(x, y);
                    int brightnessRed = pixelColor.R;
                    int brightnessGreen = pixelColor.G;
                    int brightnessBlue = pixelColor.B;
                    int brightnessGray = (int)(0.2126 * pixelColor.R + 0.7152 * pixelColor.G + 0.0722 * pixelColor.B);
                    brightnessValuesRed[brightnessRed]++;
                    brightnessValuesGreen[brightnessGreen]++;
                    brightnessValuesBlue[brightnessBlue]++;
                    brightnessValuesGray[brightnessGray]++;
                }
            }

            histogram.BrightnessValuesRed = brightnessValuesRed;
            histogram.BrightnessValuesGreen = brightnessValuesGreen;
            histogram.BrightnessValuesBlue = brightnessValuesBlue;
            histogram.BrightnessValuesGray = brightnessValuesGray;
            histogram.MaxPixels = OriginalImage.Width * OriginalImage.Height;

            return histogram;
        }
    }
}
