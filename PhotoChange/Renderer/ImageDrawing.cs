namespace PhotoChange.Renderer
{
    /// <summary>
    /// Contains graphical element settings.
    /// </summary>
    public class ImageDrawing
    {
        public ImageDrawing()
        { }

        public float BrushSize
        {
            get => _brushSize; set => _brushSize = value;
        }

        public float ErazerSize
        {
            get => _erazerSize; set => _erazerSize = value;
        }

        public Color BrushColor
        {
            get => _brushColor; set => _brushColor = value;
        }

        public Color ErazerColor
        {
            get => _erazerColor; set => _erazerColor = value;
        }

        public Color PipetteColor
        {
            get => _pipetteColor; set => _pipetteColor = value;
        }

        public Color FillingColor
        {
            get => _fillingColor; set => _fillingColor = value;
        }

        public DrawingTools Tool
        {
            get => _tool; set => _tool = value;
        }

        public enum DrawingTools
        {
            Cursor,
            Brush,
            Eraser,
            Pipette,
            Filling,
            Line,
            Ellipse
        }


        private float _brushSize = 1f;
        private float _erazerSize = 1f;
        private Color _brushColor = Color.Black;
        private Color _erazerColor = Color.Transparent;
        private Color _pipetteColor = Color.Transparent;
        private Color _fillingColor = Color.Transparent;
        private DrawingTools _tool = DrawingTools.Cursor;
    }

}
