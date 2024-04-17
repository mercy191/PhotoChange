namespace PhotoChange.Controllers
{
    /// <summary>
    /// Graphic display.
    /// </summary>
    public class GraphicsController
    {
        public GraphicsController() 
        {
            _editBitmap = new Bitmap(1, 1);
            _bitmapGraphics = Graphics.FromImage(_editBitmap);
            _visualGraphics = Graphics.FromImage(_editBitmap);
        }

        public Bitmap EditBitmap 
        { 
            get => _editBitmap; 
            set
            {
                if (_editBitmap != null && _editBitmap != value)
                    _editBitmap.Dispose();
                _editBitmap = value;
            }
        }

        /// <summary>
        /// Responsible for the graphics in the image.
        /// </summary>
        public Graphics BitmapGraphics 
        { 
            get => _bitmapGraphics; 
            set
            {
                if (_bitmapGraphics != null && _bitmapGraphics != value)
                    _bitmapGraphics.Dispose();
                _bitmapGraphics = value;
            }
        }

        /// <summary>
        /// Responsible for displaying visual graphics.
        /// </summary>
        public Graphics VisualGraphics 
        { 
            get => _visualGraphics;
            set
            {
                if (_visualGraphics != null && _visualGraphics != value)
                    _visualGraphics.Dispose();
                _visualGraphics = value;
            }
        }

        private Bitmap _editBitmap;
        private Graphics _bitmapGraphics;
        private Graphics _visualGraphics;

        public void Dispose()
        {
            _editBitmap.Dispose();
            _bitmapGraphics.Dispose();
            _visualGraphics.Dispose();
        }
    }
}
