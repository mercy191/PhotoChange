using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoChange.Common
{
    /// <summary>
    /// Stores image color information for building a histogram.
    /// </summary>
    public class Histogram
    {
        /// <summary>
        /// The number of red pixels depending on the brightness.
        /// </summary>
        public int[] BrightnessValuesRed 
        {
            get => _brightnessValuesRed;
            set
            {
                _brightnessValuesRed = value;
                _maxBrightnessRed = _brightnessValuesRed.Max();
            }               
        }

        /// <summary>
        /// The number of green pixels depending on the brightness.
        /// </summary>
        public int[] BrightnessValuesGreen
        {
            get => _brightnessValuesGreen;
            set
            {
                _brightnessValuesGreen = value;
                _maxBrightnessGreen = _brightnessValuesGreen.Max();
            }
        }

        /// <summary>
        /// The number of blue pixels depending on the brightness.
        /// </summary>
        public int[] BrightnessValuesBlue
        {
            get => _brightnessValuesBlue;
            set
            {
                _brightnessValuesBlue = value;
                _maxBrightnessBlue = _brightnessValuesBlue.Max();
            }
        }

        /// <summary>
        /// The number of gray pixels depending on the brightness.
        /// </summary>
        public int[] BrightnessValuesGray
        {
            get => _brightnessValuesGray;
            set
            {
                _brightnessValuesGray = value;
                _maxBrightnessGray = _brightnessValuesGray.Max();
            }
        }

        /// <summary>
        /// The maximum number of red pixels of a certain brightness.
        /// </summary>
        public int MaxBrightnessRed 
        {
            get => _maxBrightnessRed;
        }

        /// <summary>
        /// The maximum number of green pixels of a certain brightness.
        /// </summary>
        public int MaxBrightnessGreen
        {
            get => _maxBrightnessGreen;
        }

        /// <summary>
        /// The maximum number of blue pixels of a certain brightness.
        /// </summary>
        public int MaxBrightnessBlue
        {
            get => _maxBrightnessBlue;
        }

        /// <summary>
        /// The maximum number of gray pixels of a certain brightness.
        /// </summary>
        public int MaxBrightnessGray
        {
            get => _maxBrightnessGray;
        }

        /// <summary>
        /// The maximum number of pixels of the image.
        /// </summary>
        public int MaxPixels
        {
            get => _maxPixels;
            set => _maxPixels = value;
        }

        public Histogram() 
        {
            _brightnessValuesRed = Array.Empty<int>();
            _brightnessValuesGreen = Array.Empty<int>();
            _brightnessValuesBlue = Array.Empty<int>();
            _brightnessValuesGray = Array.Empty<int>();
        }

        private int[] _brightnessValuesRed;
        private int[] _brightnessValuesGreen;
        private int[] _brightnessValuesBlue;
        private int[] _brightnessValuesGray;
        private int _maxBrightnessRed;
        private int _maxBrightnessGreen;
        private int _maxBrightnessBlue;
        private int _maxBrightnessGray;
        private int _maxPixels;
    }
}
