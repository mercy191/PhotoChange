namespace PhotoChange.Controllers
{
    public class SelectionController
    {
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

        private bool _isMouseDown = false;
        private bool _isDrawing = false;
        private int _mouseClickNum = 1;
        private PointF _mouseLastDownPosition = new PointF(0f, 0f);
    }
}
