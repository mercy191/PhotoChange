using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoChange.Common
{
    public class GlueImagesHelper
    {
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

        public int FirstImageWidht
        {
            get => _firstImageWidht;
            set => _firstImageWidht = value;
        }

        public int FirstImageHeight
        {
            get => _firstImageHeight;
            set => _firstImageHeight = value;
        }

        public int SecondImageWidht
        {
            get => _secondImageWidht;
            set => _secondImageWidht = value;
        }

        public int SecondImageHeight
        {
            get => _secondImageHeight;
            set => _secondImageHeight = value;
        }

        public Point GlueLocation
        {
            get => _glueLocation;
            set => _glueLocation = value;
        }

        public Point ImageStep
        {
            get => _imageStep;
            set => _imageStep = value;
        }

        public Point ImageScale
        {
            get => _imageScale;
            set => _imageScale = value; 
        }

        public bool SecondImageOnTop
        {
            get => _secondImageOnTop;
            set => _secondImageOnTop = value;
        }

        public bool IsChanged
        {
            get => _isChanged;
            set => _isChanged = value;
        }

        private Bitmap _resultImage;
        private int _firstImageWidht;
        private int _firstImageHeight;
        private int _secondImageWidht;
        private int _secondImageHeight;
        private Point _glueLocation;
        private Point _imageStep;
        private Point _imageScale;
        private bool _secondImageOnTop;
        private bool _isChanged = false;
    }
}
