using PhotoChange.Common;

namespace PhotoChange.Controls
{
    public partial class GlueImagesForm : Form
    {
        public GlueImagesForm(GlueImagesHelper glueImagesHelper, Bitmap firstImage, Bitmap secondImage)
        {
            InitializeComponent();
            ReductionCoefficient = new PointF(4.0f, 4.0f);
            FirstImage = ImageHelper.ResizeImage(firstImage, (int)(firstImage.Width / ReductionCoefficient.X), (int)(firstImage.Height / ReductionCoefficient.Y));
            SecondImage = ImageHelper.ResizeImage(secondImage, (int)(secondImage.Width / ReductionCoefficient.X), (int)(secondImage.Height / ReductionCoefficient.Y));
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

        public PointF ReductionCoefficient
        {
            get => _reductionCoefficient;
            set => _reductionCoefficient = value;
        }

        public PointF Step
        {
            get => _step;
            set => _step = value;
        }

        public PointF ScaleFactor
        {
            get => _scaleFactor;
            set => _scaleFactor = value;
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
        private PointF _reductionCoefficient;
        private PointF _step;
        private PointF _scaleFactor;
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
                ScaleFactor = new PointF(SecondImageLineWidth / FirstImageLineWidth, SecondImageLineHeight / FirstImageLineHeight);
                Step = new PointF(0, 0);
                VerticalExpension = 0;
                HorizontalExpension = 0;
                if (ScaleFactor.X > 1 && ScaleFactor.Y > 1)
                {
                    SecondImageOnTop = true;
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X), (int)(SecondImage.Height / ScaleFactor.Y));
                    Step = new PointF((FirstImage.Width - temp.Width) / 2, (FirstImage.Height - temp.Height) / 2);
                    GlueLocation = new Point((int)Step.X, (int)Step.Y);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    SecondImageOnTop = false;
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X), (int)(FirstImage.Height * ScaleFactor.Y));
                    Step = new PointF((SecondImage.Width - temp.Width) / 2, (SecondImage.Height - temp.Height) / 2);
                    GlueLocation = new Point((int)Step.X, (int)Step.Y);
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
                Step = new PointF(Step.X - 1, Step.Y);
                GlueLocation = new Point((int)Step.X, (int)Step.Y);
                HorizontalExpension += 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X) + HorizontalExpension, (int)(SecondImage.Height / ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X) + HorizontalExpension, (int)(FirstImage.Height * ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == leftReduceButton)
            {
                Step = new PointF(Step.X + 1, Step.Y);
                GlueLocation = new Point((int)Step.X, (int)Step.Y);
                HorizontalExpension -= 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X) + HorizontalExpension, (int)(SecondImage.Height / ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X) + HorizontalExpension, (int)(FirstImage.Height * ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == rightIncreaseButton)
            {
                Step = new PointF(Step.X, Step.Y);
                GlueLocation = new Point((int)Step.X, (int)Step.Y);
                HorizontalExpension += 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X) + HorizontalExpension, (int)(SecondImage.Height / ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X) + HorizontalExpension, (int)(FirstImage.Height * ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == rightReduceButton)
            {
                Step = new PointF(Step.X, Step.Y);
                GlueLocation = new Point((int)Step.X, (int)Step.Y);
                HorizontalExpension -= 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X) + HorizontalExpension, (int)(SecondImage.Height / ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X) + HorizontalExpension, (int)(FirstImage.Height * ScaleFactor.Y) + VerticalExpension);
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
                Step = new PointF(Step.X, Step.Y - 1);
                GlueLocation = new Point((int)Step.X, (int)Step.Y);
                VerticalExpension += 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X) + HorizontalExpension, (int)(SecondImage.Height / ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X) + HorizontalExpension, (int)(FirstImage.Height * ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == upReduceButton)
            {
                Step = new PointF(Step.X, Step.Y + 1);
                GlueLocation = new Point((int)Step.X, (int)Step.Y);
                VerticalExpension -= 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X) + HorizontalExpension, (int)(SecondImage.Height / ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X) + HorizontalExpension, (int)(FirstImage.Height * ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == downIncreaseButton)
            {
                Step = new PointF(Step.X, Step.Y);
                GlueLocation = new Point((int)Step.X, (int)Step.Y);
                VerticalExpension += 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X) + HorizontalExpension, (int)(SecondImage.Height / ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X) + HorizontalExpension, (int)(FirstImage.Height * ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            else if (sender == downReduceButton)
            {
                Step = new PointF(Step.X, Step.Y);
                GlueLocation = new Point((int)Step.X, (int)Step.Y);
                VerticalExpension -= 1;
                if (SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(SecondImage, (int)(SecondImage.Width / ScaleFactor.X) + HorizontalExpension, (int)(SecondImage.Height / ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(FirstImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(FirstImage, (int)(FirstImage.Width * ScaleFactor.X) + HorizontalExpension, (int)(FirstImage.Height * ScaleFactor.Y) + VerticalExpension);
                    ResultImage = new Bitmap(SecondImage);
                    ImageHelper.GlueImage(ResultImage, temp, GlueLocation);
                }
            }

            thirdPictureBox.Image = ResultImage;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            GlueImagesHelper.GlueLocation = new Point((int)(GlueLocation.X * ReductionCoefficient.X), (int)(GlueLocation.Y * ReductionCoefficient.Y));
            GlueImagesHelper.ScaleFactor = ScaleFactor;
            GlueImagesHelper.SecondImageOnTop = SecondImageOnTop;
            GlueImagesHelper.IsChanged = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
