using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoChange.Common
{
    /// <summary>
    /// Stores the data needed for the final correction of image colors.
    /// </summary>
    public class ColorCorrectionHelper
    {
        public ColorCorrectionHelper() 
        { }

        /// <summary>
        /// Red balance.
        /// </summary>
        public int R
        {
            get => _r; 
            set => _r = value;
        }

        /// <summary>
        /// Green balance.
        /// </summary>
        public int G
        {
            get => _g; 
            set => _g = value;
        }

        /// <summary>
        /// Blue balance.
        /// </summary>
        public int B
        {
            get => _b; 
            set => _b = value;
        }

        public int Brightness 
        { 
            get => _brightness; 
            set => _brightness = value; 
        }

        public int Contrast 
        { 
            get => _contrast; 
            set => _contrast = value;
        }

        public int Saturation 
        { 
            get => _saturation; 
            set => _saturation = value; 
        }

        public float Gamma 
        { 
            get => _gamma; 
            set => _gamma = value; 
        }

        /// <summary>
        /// Has the image changed.
        /// </summary>
        public bool IsChanged 
        { 
            get => _isChanged; 
            set => _isChanged = value; 
        }

        private int _r = 0;
        private int _g = 0;
        private int _b = 0;
        private int _brightness = 0;
        private int _contrast = 0;
        private int _saturation = 0;
        private float _gamma = 1.00f;
        private bool _isChanged = false;
    }
}
