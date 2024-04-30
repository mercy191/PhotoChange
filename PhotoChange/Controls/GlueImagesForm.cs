using PhotoChange.Common;

namespace PhotoChange.Controls
{
    public partial class GlueImagesForm : Form
    {
        public GlueImagesForm(GlueImagesHelper glueImagesHelper, Bitmap firstImage, Bitmap secondImage)
        {
            InitializeComponent();
            //FirstImage = new Bitmap(firstImage);
            //SecondImage = new Bitmap(secondImage);
            FirstImage = ImageHelper.ResizeImage(firstImage, 1000, 1000);
            SecondImage = ImageHelper.ResizeImage(secondImage, 1000, 1000);
            GlueImagesHelper = glueImagesHelper;
            firstPictureBox.Image = FirstImage;
            secondPictureBox.Image = SecondImage;
        }

        public Bitmap FirstImage
        {
            get => _firstImage;
            set
            {
                if (_firstImage != null && _firstImage != value)
                    _firstImage.Dispose();
                _firstImage = value;
            }
        }

        public Bitmap SecondImage
        {
            get => _secondImage;
            set
            {
                if (_secondImage != null && _secondImage != value)
                    _secondImage.Dispose();
                _secondImage = value;
            }
        }
        public Bitmap ResultImage
        {
            get => _resultImage;
            set
            {
                if (_resultImage != null && _resultImage != value)
                    _resultImage.Dispose();
                _resultImage = value;
            }
        }

        public GlueImagesHelper GlueImagesHelper
        {
            get => _glueImagesHelper;
            set => _glueImagesHelper = value;
        }

        public PointF FirstImageFirstPoint
        {
            get => _firstImageFirstPoint;
            set => _firstImageFirstPoint = value;
        }

        public PointF FirstImageSecondPoint
        {
            get => _firstImageSecondPoint;
            set => _firstImageSecondPoint = value;
        }

        public PointF SecondImageFirstPoint
        {
            get => _secondImageFirstPoint;
            set => _secondImageFirstPoint = value;
        }

        public PointF SecondImageSecondPoint
        {
            get => _secondImageSecondPoint;
            set => _secondImageSecondPoint = value;
        }

        public Point GlueLocation
        {
            get => _glueLocation;
            set => _glueLocation = value;
        }

        public PointF ImageStep
        {
            get => _imageStep;
            set => _imageStep = value;
        }

        public PointF ImageScale
        {
            get => _imageScale;
            set => _imageScale = value;
        }

        public float FirstImageLineWidth
        {
            get => _firstImageLineWidth;
            set => _firstImageLineWidth = value;
        }

        public float FirstImageLineHeight
        {
            get => _fisrtImageLineHeight;
            set => _fisrtImageLineHeight = value;
        }

        public float SecondImageLineWidth
        {
            get => _secondImageLineWidth;
            set => _secondImageLineWidth = value;
        }

        public float SecondImageLineHeight
        {
            get => _secondImageLineHeight;
            set => _secondImageLineHeight = value;
        }

        public int SecondClickNumber
        {
            get => _secondClickNumber;
            set => _secondClickNumber = value;
        }

        public int FirstClickNumber
        {
            get => _firstClickNumber;
            set => _firstClickNumber = value;
        }

        public bool SecondImageOnTop
        {
            get => _secondImageOnTop;
            set => _secondImageOnTop = value;
        }
        public int HorizontalExpension
        {
            get => _horizontalExpension;
            set => _horizontalExpension = value;
        }

        public int VerticalExpension
        {
            get => _verticalExpension;
            set => _verticalExpension = value;
        }

        private Bitmap _firstImage;
        private Bitmap _secondImage;
        private Bitmap _resultImage;
        private GlueImagesHelper _glueImagesHelper;
        private Point _glueLocation;
        private PointF _firstImageFirstPoint;
        private PointF _firstImageSecondPoint;
        private PointF _secondImageFirstPoint;
        private PointF _secondImageSecondPoint;
        private PointF _imageStep;
        private PointF _imageScale;
        private float _firstImageLineWidth;
        private float _fisrtImageLineHeight;
        private float _secondImageLineWidth;
        private float _secondImageLineHeight;
        private int _horizontalExpension;
        private int _verticalExpension;
        private int _firstClickNumber = 0;
        private int _secondClickNumber = 0;
        private bool _secondImageOnTop = false;

        private void FirstPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            FirstClickNumber += 1;
            switch (FirstClickNumber)
            {
                case 1:
                    FirstImageFirstPoint = e.Location;
                    break;
                case 2:
                    FirstImageSecondPoint = e.Location;
                    FirstImageLineWidth = Math.Abs(FirstImageSecondPoint.X - FirstImageFirstPoint.X);
                    FirstImageLineHeight = Math.Abs(FirstImageSecondPoint.Y - FirstImageFirstPoint.Y);
                    FirstClickNumber = 0;
                    break;
            }
        }

        private void SecondPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SecondClickNumber += 1;
            switch (SecondClickNumber)
            {
                case 1:
                    SecondImageFirstPoint = e.Location;
                    break;
                case 2:
                    SecondImageSecondPoint = e.Location;
                    SecondImageLineWidth = Math.Abs(SecondImageSecondPoint.X - SecondImageFirstPoint.X);
                    SecondImageLineHeight = Math.Abs(SecondImageSecondPoint.Y - SecondImageFirstPoint.Y);
                    SecondClickNumber = 0;
                    break;
            }
        }

        private void GlueButton_Click(object sender, EventArgs e)
        {
            if (FirstImageLineWidth > 0 && SecondImageLineWidth > 0)
            {
                ImageScale = new PointF(SecondImageLineWidth / FirstImageLineWidth, SecondImageLineHeight / FirstImageLineHeight);
                ImageStep = new PointF(0, 0);
                VerticalExpension = 0;
                HorizontalExpension = 0;
                if (ImageScale.X > 1 && ImageScale.Y > 1)
                {
                    SecondImageOnTop = true;
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X), (int)(SecondImage.Height / ImageScale.Y));
                    ImageStep = new PointF((FirstImage.Width - temp.Width) / 2, (FirstImage.Height - temp.Height) / 2);
                    GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    SecondImageOnTop = false;
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X), (int)(FirstImage.Height * ImageScale.Y));
                    ImageStep = new PointF((SecondImage.Width - temp.Width) / 2, (SecondImage.Height - temp.Height) / 2);
                    GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }

                thirdPictureBox.Image = ResultImage;
            }
        }

        private void HorizontalButton_Click(object sender, EventArgs e)
        {
            if (sender == leftIncreaseButton)
            {
                ImageStep = new PointF(ImageStep.X - 1, ImageStep.Y);
                GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                HorizontalExpension += 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X) + HorizontalExpension, (int)(SecondImage.Height / ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X) + HorizontalExpension, (int)(FirstImage.Height * ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == leftReduceButton)
            {
                ImageStep = new PointF(ImageStep.X + 1, ImageStep.Y);
                GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                HorizontalExpension -= 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X) + HorizontalExpension, (int)(SecondImage.Height / ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X) + HorizontalExpension, (int)(FirstImage.Height * ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == rightIncreaseButton)
            {
                ImageStep = new PointF(ImageStep.X, ImageStep.Y);
                GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                HorizontalExpension += 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X) + HorizontalExpension, (int)(SecondImage.Height / ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X) + HorizontalExpension, (int)(FirstImage.Height * ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == rightReduceButton)
            {
                ImageStep = new PointF(ImageStep.X, ImageStep.Y);
                GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                HorizontalExpension -= 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X) + HorizontalExpension, (int)(SecondImage.Height / ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X) + HorizontalExpension, (int)(FirstImage.Height * ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            thirdPictureBox.Image = ResultImage;
        }

        private void VerticalButton_Click(object sender, EventArgs e)
        {
            if (sender == upIncreaseButton)
            {
                ImageStep = new PointF(ImageStep.X, ImageStep.Y - 1);
                GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                VerticalExpension += 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X) + HorizontalExpension, (int)(SecondImage.Height / ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X) + HorizontalExpension, (int)(FirstImage.Height * ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == upReduceButton)
            {
                ImageStep = new PointF(ImageStep.X, ImageStep.Y + 1);
                GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                VerticalExpension -= 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X) + HorizontalExpension, (int)(SecondImage.Height / ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X) + HorizontalExpension, (int)(FirstImage.Height * ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == downIncreaseButton)
            {
                ImageStep = new PointF(ImageStep.X, ImageStep.Y);
                GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                VerticalExpension += 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X) + HorizontalExpension, (int)(SecondImage.Height / ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X) + HorizontalExpension, (int)(FirstImage.Height * ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == downReduceButton)
            {
                ImageStep = new PointF(ImageStep.X, ImageStep.Y);
                GlueLocation = new Point((int)ImageStep.X, (int)ImageStep.Y);
                VerticalExpension -= 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ImageScale.X) + HorizontalExpension, (int)(SecondImage.Height / ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ImageScale.X) + HorizontalExpension, (int)(FirstImage.Height * ImageScale.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            thirdPictureBox.Image = ResultImage;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            GlueImagesHelper.ResultImage = new Bitmap(ResultImage);
            GlueImagesHelper.IsChanged = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
