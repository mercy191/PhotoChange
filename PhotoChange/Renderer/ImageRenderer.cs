using PhotoChange.Common;

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
            _path = "";
            _image = new Bitmap(1, 1);
            _originalImage = new Bitmap(1, 1);
            _editList = new List<Bitmap>();
            _editListIterator = -1;
            _scaleFactor = 1;
            _widthRetreat = 0;
            _heightRetreat = 0;
            _rotateAngle = 0;
        }


        /// <param name="path">Image path.</param>
        public ImageRenderer(string path)
        {
            _path = path;
            _image = new Bitmap(path);
            _originalImage = new Bitmap(_image);
            _editList = new List<Bitmap>();
            _editListIterator = -1;
            _scaleFactor = 1;
            _widthRetreat = 0;
            _heightRetreat = 0;
            _rotateAngle = 0;
        }

        /// <summary>
        /// Current image.
        /// </summary>
        public Bitmap? Image
        {
            get => _image; 
            set
            {
                if (_image != null && _image != value ) 
                    _image.Dispose();
                _image = value;
            }
        }

        /// <summary>
        /// Original image.
        /// </summary>
        public Bitmap? OriginalImage
        {
            get => _originalImage;
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
            get => _editListIterator; set => _editListIterator = value;
        }

        /// <summary>
        /// Indicates the path to the image.
        /// </summary>
        public string Path
        {
            get => _path; set => _path = value;
        }

        /// <summary>
        /// Image proportionality coefficient.
        /// </summary>
        public float ScaleFactor
        {
            get => _scaleFactor; set => _scaleFactor = value;
        }

        /// <summary>
        /// Horizontal retreat from the edges of the canvas.
        /// </summary>
        public float WidthRetreat
        {
            get => _widthRetreat; set => _widthRetreat = value;
        }

        /// <summary>
        /// Vertical retreat from the edges of the canvas.
        /// </summary>
        public float HeightRetreat
        {
            get => _heightRetreat; set => _heightRetreat = value;
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

        private Bitmap? _image;
        private Bitmap? _originalImage;
        private List<Bitmap> _editList;
        private int _editListIterator;
        private string _path;
        private float _scaleFactor;
        private float _widthRetreat;
        private float _heightRetreat;
        private float _rotateAngle;


        /// <param name="width">Canvas width.</param>
        /// <param name="height">Canvas height.</param>
        public void CalculateScaleFactor(int width, int height)
        {
            ScaleFactor = (float)Image.Width / width > (float)Image.Height / height
                ? (float)Image.Width / width : (float)Image.Height / height;
        }

        /// <param name="width">Canvas width.</param>
        /// <param name="height">Canvas height.</param>
        public void CalculateRetreat(int width, int height)
        {
            WidthRetreat = (width - Image.Width / ScaleFactor) / 2;
            HeightRetreat = (height - Image.Height / ScaleFactor) / 2;
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

        public void Dispose()
        {
            foreach (var item in _editList)
                item.Dispose();
            _editList.Clear();
            _editListIterator = -1;
            _image?.Dispose();
            _image = null;
            _originalImage?.Dispose();
            _originalImage = null;
        }


        /// <param name="width">New image width.</param>
        /// <param name="heignt">New image height.</param>
        public void Resize(int width, int height)
        {
            if (width == 0 || height == 0) return;   

            Bitmap newImage = new Bitmap(width, height, Image.PixelFormat);

            float nWidthFactor = (float)Image.Width / width;
            float nHeightFactor = (float)Image.Height / height;

            double fx, fy, nx, ny;
            int cx, cy, fr_x, fr_y;
            Color color1 = new Color();
            Color color2 = new Color();
            Color color3 = new Color();
            Color color4 = new Color();
            byte nRed, nGreen, nBlue;

            byte bp1, bp2;

            for (int x = 0; x < newImage.Width; ++x)
            {
                for (int y = 0; y < newImage.Height; ++y)
                {

                    fr_x = (int)Math.Floor(x * nWidthFactor);
                    fr_y = (int)Math.Floor(y * nHeightFactor);
                    cx = fr_x + 1;
                    if (cx >= Image.Width) cx = fr_x;
                    cy = fr_y + 1;
                    if (cy >= Image.Height) cy = fr_y;
                    fx = x * nWidthFactor - fr_x;
                    fy = y * nHeightFactor - fr_y;
                    nx = 1.0 - fx;
                    ny = 1.0 - fy;

                    color1 = Image.GetPixel(fr_x, fr_y);
                    color2 = Image.GetPixel(cx, fr_y);
                    color3 = Image.GetPixel(fr_x, cy);
                    color4 = Image.GetPixel(cx, cy);

                    // Blue
                    bp1 = (byte)(nx * color1.B + fx * color2.B);

                    bp2 = (byte)(nx * color3.B + fx * color4.B);

                    nBlue = (byte)(ny * (bp1) + fy * (bp2));

                    // Green
                    bp1 = (byte)(nx * color1.G + fx * color2.G);

                    bp2 = (byte)(nx * color3.G + fx * color4.G);

                    nGreen = (byte)(ny * (bp1) + fy * (bp2));

                    // Red
                    bp1 = (byte)(nx * color1.R + fx * color2.R);

                    bp2 = (byte)(nx * color3.R + fx * color4.R);

                    nRed = (byte)(ny * (bp1) + fy * (bp2));

                    newImage.SetPixel(x, y, System.Drawing.Color.FromArgb(255, nRed, nGreen, nBlue));
                }
            }

            Image = newImage;
            EditList.Add(new Bitmap(Image));
            EditListIterator += 1;
        }


        /// <param name="angle">Angle of rotation.</param>
        public void Rotate(float angle)
        {
            // Вычисление размеров нового изображения после поворота
            RotateAngle += angle;
            double radianAngle = RotateAngle * Math.PI / 180;
            double sin = Math.Abs(Math.Sin(radianAngle));
            double cos = Math.Abs(Math.Cos(radianAngle));
            int newWidth = (int)Math.Round(OriginalImage.Width * cos + OriginalImage.Height * sin);
            int newHeight = (int)Math.Round(OriginalImage.Width * sin + OriginalImage.Height * cos);

            // Создание Bitmap для нового изображения
            Bitmap rotatedImage = new Bitmap(newWidth, newHeight);

            // Получение Graphics объекта для рисования на новом изображении
            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                graphics.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2); // Смещение в центр
                graphics.RotateTransform((float)angle); // Поворот изображения
                graphics.TranslateTransform(-Image.Width / 2, -Image.Height / 2); // Смещение от центра
                graphics.DrawImage(Image, new Point(0, 0));
            }

            Image.Dispose();
            Image = rotatedImage;
            EditList.Add(new Bitmap(Image));
            EditListIterator += 1;
        }


        /// <param name="flipType">Type of rotate or flip filter.</param>
        public void Flip(RotateFlipType flipType)
        {
            Image.RotateFlip(flipType);
            EditList.Add(new Bitmap(Image));
            EditListIterator += 1;
        }

        public enum ColorFilterTypes
        {
            Red,
            Green,
            Blue,
            All
        }

        public void IncreaseColorDepth()
        {

        }

        public void ReduceColorDepth()
        {
            
        }

        public void SetGrayscale()
        {
            Color color;
            for (int i = 0; i < Image.Width; i++)
            {
                for (int j = 0; j < Image.Height; j++)
                {
                    color = Image.GetPixel(i, j);
                    byte gray = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);

                    Image.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            EditList.Add(new Bitmap(Image));
            EditListIterator += 1;
        }

        /// <param name="colorFilterType">Type of color filter</param>
        public void SetColorFilter(ColorFilterTypes colorFilterType)
        {
            Color color;
            for (int i = 0; i < Image.Width; i++)
            {
                for (int j = 0; j < Image.Height; j++)
                {
                    color = Image.GetPixel(i, j);
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

                    Image.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }

            EditList.Add(new Bitmap(Image));
            EditListIterator += 1;
        }      

        /// <param name="colorFilterType">Type of color filter</param>
        public void SetInvert(ColorFilterTypes colorFilterType)
        {
            Color color;
            for (int i = 0; i < Image.Width; i++)
            {
                for (int j = 0; j < Image.Height; j++)
                {
                    color = Image.GetPixel(i, j);
                    if (colorFilterType == ColorFilterTypes.Red)
                    {
                        Image.SetPixel(i, j, Color.FromArgb(255 - color.R, color.G, color.B));
                    }
                    else if (colorFilterType == ColorFilterTypes.Green)
                    {
                        Image.SetPixel(i, j, Color.FromArgb(color.R, 255 - color.G, color.B));
                    }
                    else if (colorFilterType == ColorFilterTypes.Blue)
                    {
                        Image.SetPixel(i, j, Color.FromArgb(color.R, color.G, 255 - color.B));
                    }
                    else if (colorFilterType == ColorFilterTypes.All)
                    {
                        Image.SetPixel(i, j, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                    }                    
                }
            }

            EditList.Add(new Bitmap(Image));
            EditListIterator += 1;
        }

        public Histogram CalculateHistogram()
        {
            Histogram histogram = new Histogram();

            int[] brightnessValuesRed = new int[256];
            int[] brightnessValuesGreen = new int[256];
            int[] brightnessValuesBlue = new int[256];
            int[] brightnessValuesGray = new int[256];

            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    Color pixelColor = Image.GetPixel(x, y);
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
            histogram.MaxPixels = Image.Width * Image.Height;

            return histogram;
        }
    }
}
