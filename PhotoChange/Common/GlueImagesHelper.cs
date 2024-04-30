using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoChange.Common
{
    /// <summary>
    /// Stores the data needed for the final bonding of two images.
    /// </summary>
    public class GlueImagesHelper
    {
        /// <summary>
        /// The point from which the gluing of two images begins.
        /// </summary>
        public Point GlueLocation
        {
            get => _glueLocation;
            set => _glueLocation = value;
        }

        /// <summary>
        /// The scaling coefficient of one image relative to another.
        /// </summary>
        public PointF ScaleFactor
        {
            get => _scaleFactor;
            set => _scaleFactor = value; 
        }

        /// <summary>
        /// Shows which image to glue on top.
        /// </summary>
        public bool SecondImageOnTop
        {
            get => _secondImageOnTop;
            set => _secondImageOnTop = value;
        }

        /// <summary>
        /// Has the image changed.
        /// </summary>
        public bool IsChanged
        {
            get => _isChanged;
            set => _isChanged = value;
        }

        /// <summary>
        /// Horizontal image offset.
        /// </summary>
        public int HorizontalExpension 
        { 
            get => _horizontalExpension; 
            set => _horizontalExpension = value; 
        }

        /// <summary>
        /// Vertical image offset.
        /// </summary>
        public int VerticalExpension 
        { 
            get => _verticalExpension;
            set => _verticalExpension = value; 
        }

        private Point _glueLocation;
        private PointF _scaleFactor;
        private int _horizontalExpension;
        private int _verticalExpension;
        private bool _secondImageOnTop;
        private bool _isChanged = false;
    }
}
