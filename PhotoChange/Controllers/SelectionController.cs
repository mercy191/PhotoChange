using PhotoChange.Common;

namespace PhotoChange.Controllers
{
    /// <summary>
    /// Following the latest user actions.
    /// </summary>
    public class SelectionController
    {
        public Layer CurrentLayer 
        { 
            get => _currentLayer; 
            set => _currentLayer = value;
        }

        public int CurrentLayerNumber
        {
            get => _currentLayerNumber;
            set => _currentLayerNumber = value;
        }

        public bool IsMouseDown
        {
            get => _isMouseDown; set => _isMouseDown = value;
        }

        public bool IsDrawing
        {
            get => _isDrawing; set => _isDrawing = value;
        }

        public int MouseClickNum
        {
            get => _mouseClickNum; set => _mouseClickNum = value;
        }

        public PointF MouseLastDownPosition
        {
            get => _mouseLastDownPosition; set => _mouseLastDownPosition = value;
        }


        private Layer _currentLayer;
        private int _currentLayerNumber = 0;
        private bool _isMouseDown = false;
        private bool _isDrawing = false;
        private int _mouseClickNum = 1;
        private PointF _mouseLastDownPosition = new PointF(0f, 0f);

    }
}
