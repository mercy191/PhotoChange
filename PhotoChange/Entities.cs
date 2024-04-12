using System.Numerics;

namespace PhotoChange.Entities
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
            EditListIterator = -1;
            ScaleFactor = 1;
            WidthRetreat = 0;
            HeightRetreat = 0;
        }       


        /// <param name="path">Image path.</param>
        public ImageRenderer(string path)
        {
            _path = path;
            _image = new Bitmap(path);
            _originalImage = new Bitmap(_image);
            _editList = new List<Bitmap>();
            EditListIterator = -1;
            ScaleFactor = 1;
            WidthRetreat = 0;
            HeightRetreat = 0;
        }

        /// <summary>
        /// Current image.
        /// </summary>
        public Bitmap Image
        {
            get { return _image; }
            set { _image = value; }
        }

        /// <summary>
        /// Original image.
        /// </summary>
        public Bitmap OriginalImage
        {
            get { return _originalImage; }
        }

        /// <summary>
        /// The list stores all image changes.
        /// </summary>
        public List<Bitmap> EditList
        {
            get { return _editList; }
        }

        /// <summary>
        /// Indicates the current item in the list of changes.
        /// </summary>
        public int EditListIterator
        {
            get { return _editListIterator; }
            set { _editListIterator = value; }
        }

        /// <summary>
        /// Indicates the path to the image.
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        /// <summary>
        /// Image proportionality coefficient.
        /// </summary>
        public float ScaleFactor
        {
            get { return _scaleFactor; }
            set { _scaleFactor = value; }
        }

        /// <summary>
        /// Horizontal retreat from the edges of the canvas.
        /// </summary>
        public float WidthRetreat
        {
            get { return _widthRetreat; }
            set { _widthRetreat = value; }
        }

        /// <summary>
        /// Vertical retreat from the edges of the canvas.
        /// </summary>
        public float HeightRetreat 
        {
            get { return _heightRetreat; }
            set { _heightRetreat = value; } 
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
            ScaleFactor = ((float)Image.Width / width > (float)Image.Height / height) 
				? (float)Image.Width / width : (float)Image.Height / height;
        }

        /// <param name="width">Canvas width.</param>
        /// <param name="height">Canvas height.</param>
        public void CalculateRetreat(int width, int height)
		{
            WidthRetreat = (width - Image.Width / ScaleFactor) / 2;
            HeightRetreat = (height - Image.Height / ScaleFactor) / 2;
        }

    }

	public class GraphicsRenderer
	{

	}

    /// <summary>
    /// Contains graphical element settings.
    /// </summary>
	public class Draw
	{
        public Draw()
        { }

        public bool IsMousePressed
        {
            get { return _isMousePressed; }
            set { _isMousePressed = value; } 
        }

        public bool IsDrawing
        {
            get { return _isDrawing; }
            set { _isDrawing = value; } 
        }

        public float BrushSize
        {
            get { return _brushSize; }
            set { _brushSize = value; }
        }

        public float ErazerSize
        {
            get { return _erazerSize; }
            set { _erazerSize = value; }
        }

        public Color BrushColor
        {
            get { return _brushColor; }
            set { _brushColor = value; }
        }

        public Color ErazerColor
        {
            get { return _erazerColor; }
            set { _erazerColor = value; }
        }

        public Color PipetteColor
        {
            get { return _pipetteColor; }
            set { _pipetteColor = value; }
        }

        public Color FillingColor
        {
            get { return _fillingColor; }
            set { _fillingColor = value; }
        }

        public DrawingTools Tool
        {
            get { return _tool; }
            set { _tool = value; }
        }

        public enum DrawingTools
        {
            Cursor,
            Brush,
            Eraser,
            Pipette,
            Filling,
            Point,
            Line,
            Ellipse
        }

        private bool _isMousePressed = false;
        private bool _isDrawing = false;
        private float _brushSize = 1f;
        private float _erazerSize = 1f;
        private Color _brushColor = Color.Black;
        private Color _erazerColor = Color.Transparent;
        private Color _pipetteColor = Color.Transparent;
        private Color _fillingColor = Color.Transparent;
        private DrawingTools _tool = DrawingTools.Cursor;
    }
  
    public class Line
    {
		private Vector3 _startPoint;
		private Vector3 _endPoint;
		private float _thickness;

        /// <summary>
        /// Implements a class for drawing a straight line
        /// </summary>
        public Line() : this(Vector3.Zero, Vector3.Zero)
		{ }

		/// <summary>
		/// Implements a class for drawing a straight line
		/// </summary>
		/// <param name="start">Start position of drawing line</param>
		/// <param name="end">End position of drawing line</param>
		public Line(Vector3 start, Vector3 end)
		{
			StartPoint = start;	
			EndPoint = end;
			Thickness = 0.0f;
		}

		public float Thickness
		{
			get { return _thickness; }
			set { _thickness = value; }
		}

		public Vector3 StartPoint
		{
			get { return	_startPoint; }
			set { _startPoint = value; }
		}

		public Vector3 EndPoint
        {
            get { return _endPoint; }
            set { _endPoint = value; }
        }
	}
}
