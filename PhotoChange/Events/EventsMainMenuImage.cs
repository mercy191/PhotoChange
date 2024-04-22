using PhotoChange.Controls;
using PhotoChange.Renderer;

namespace PhotoChange
{   
    public partial class MainForm
    {
        #region -- Main Menu Image Events --
        
        private void ImagePropertiesMainMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            ImagePropertiesControl control = new ImagePropertiesControl();

            control.Dock = DockStyle.Fill;
            control.FileName = _selectionController.CurrentLayer.ImageInfo.FileName;
            control.Directory = _selectionController.CurrentLayer.ImageInfo.Directory;
            control.FullPath = _selectionController.CurrentLayer.ImageInfo.FullPath;
            control.ImageSize = _selectionController.CurrentLayer.ImageInfo.ImageSize;
            control.FileSize = _selectionController.CurrentLayer.ImageInfo.FileSize;
            control.DateTime = _selectionController.CurrentLayer.ImageInfo.DateTime;

            splitContainer2.Panel2.Controls.Add(control);
        }

        private void RotateMainMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == rotateMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.Rotate(30);            
            }    
            
            else if (sender == rotateLeftMainMenuItem) 
            {
                _selectionController.CurrentLayer.ImageRenderer.Rotate(270);
            }

            else if (sender == rotateRightMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.Rotate(90);
            }

            _selectionController.CurrentLayer.ImageRenderer.CalculateScaleFactor(pictureBoxCanvas.Width, pictureBoxCanvas.Height);

            UpdateInterface();
        }

        private void FlipMainMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == flipVerticallyMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.Flip(RotateFlipType.RotateNoneFlipX);              
            }

            else if (sender == flipHorizontallyMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.Flip(RotateFlipType.RotateNoneFlipY);
            }

            UpdateInterface();
        }

        private void InShadesOfGrayMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetGrayscale();
            UpdateInterface();
        }

        private void ShowChannelMainMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == redChannelMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SetColorFilter(ImageRenderer.ColorFilterTypes.Red);
            }

            else if (sender == greenChannelMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SetColorFilter(ImageRenderer.ColorFilterTypes.Green);
            }

            else if (sender == blueChannelMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SetColorFilter(ImageRenderer.ColorFilterTypes.Blue);
            }
            UpdateInterface();
        }

        private void InvertMainMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == allChannelMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SetInvert(ImageRenderer.ColorFilterTypes.All);
            }  
            
            else if (sender == redMainMenuItem) 
            {
                _selectionController.CurrentLayer.ImageRenderer.SetInvert(ImageRenderer.ColorFilterTypes.Red);
            }

            else if (sender == greenMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SetInvert(ImageRenderer.ColorFilterTypes.Green);
            }

            else if (sender == blueMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SetInvert(ImageRenderer.ColorFilterTypes.Blue);
            }

            UpdateInterface();
        }

        private void ChangeColorDepthMainMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == increaseColorDepthMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.ChangeColorDepth();
            }

            else if (sender == reduceColorDepthMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.ChangeColorDepth();
            }

            UpdateInterface();
        }

        private void ColorCorrectionMainMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInterface();
        }

        private void HistogramMainMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HistogramControl control = new HistogramControl();

            control.Histogram = _selectionController.CurrentLayer.ImageRenderer.CalculateHistogram();

            splitContainer2.Panel2.Controls.Add(control);
        }

        private void SwitchColorChannelMainMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == RGBtoRBGMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SwitchColorChannel(ImageRenderer.ColorChannelTypes.RBG);
            }

            else if (sender == RGBtoBGRMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SwitchColorChannel(ImageRenderer.ColorChannelTypes.BGR);
            }

            else if (sender == RGBtoBRGMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SwitchColorChannel(ImageRenderer.ColorChannelTypes.BRG); ;
            }

            else if (sender == RGBtoGRBMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SwitchColorChannel(ImageRenderer.ColorChannelTypes.GRB);
            }

            else if (sender == RGBtoGBRMainMenuItem)
            {
                _selectionController.CurrentLayer.ImageRenderer.SwitchColorChannel(ImageRenderer.ColorChannelTypes.GBR);               
            }

            UpdateInterface();
        }

        #endregion
    }
}
