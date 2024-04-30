using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoChange.Common
{
    public class GlueImagesHelper
    {
        public Point GlueLocation
        {
            get => _glueLocation;
            set => _glueLocation = value;
        }

        public PointF ScaleFactor
        {
            get => _scaleFactor;
            set => _scaleFactor = value; 
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

        private Point _glueLocation;
        private PointF _scaleFactor;
        private bool _secondImageOnTop;
        private bool _isChanged = false;
    }
}
