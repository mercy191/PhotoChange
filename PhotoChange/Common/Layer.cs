using PhotoChange.Renderer;

namespace PhotoChange.Common
{
    /// <summary>
    /// Stores complete layer information.
    /// </summary>
    public class Layer
    {
        public Layer(ImageRenderer imageRenderer, ImageDrawing imageDrawing, ImageInfo imageInfo) 
        { 
            _imageRenderer = imageRenderer;
            _imageDrawing = imageDrawing;
            _imageInfo = imageInfo;
            _layerName = imageInfo.FileName;
        }

        public ImageRenderer ImageRenderer 
        { 
            get => _imageRenderer;
            set => _imageRenderer = value;
        }

        public ImageDrawing ImageDrawing
        {
            get => _imageDrawing;
            set => _imageDrawing = value;
        }

        public ImageInfo ImageInfo
        {
            get => _imageInfo;
            set => _imageInfo = value;
        }

        public string LayerName
        {
            get => _layerName;
            set => _layerName = value;
        }

        private ImageRenderer _imageRenderer;
        private ImageDrawing _imageDrawing;
        private ImageInfo _imageInfo;
        private string _layerName;
    }
}
