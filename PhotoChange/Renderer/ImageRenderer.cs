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
        }

        /// <summary>
        /// Current image.
        /// </summary>
        public Bitmap Image
        {
            get => _image; set => _image = value;
        }

        /// <summary>
        /// Original image.
        /// </summary>
        public Bitmap OriginalImage
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

        private Bitmap _image;
        private Bitmap _originalImage;
        private List<Bitmap> _editList;
        private int _editListIterator;
        private string _path;
        private float _scaleFactor;
        private float _widthRetreat;
        private float _heightRetreat;


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
        /// <returns></returns>
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

    }
}
