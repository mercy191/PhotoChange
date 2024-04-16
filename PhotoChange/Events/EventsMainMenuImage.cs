using PhotoChange.Controls;
using PhotoChange.Renderer;
using PhotoChange.Common;

namespace PhotoChange
{   
    public partial class MainForm
    {
        #region -- Main Menu Image Events --
        
        private void ImagePropertiesMainMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            ImagePropertiesControl control = new ImagePropertiesControl();

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
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            UpdateInterface();
        }

        private void RotateLeftMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.Rotate90FlipNone);
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.Rotate180FlipNone);
            UpdateInterface();
        }

        private void RotateRightMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.Rotate90FlipNone);
            UpdateInterface();
        }

        private void FlipVerticallyMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.RotateNoneFlipX);
            UpdateInterface();
        }

        private void FlipHorizontallyMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.RotateNoneFlipY);
            UpdateInterface();
        }

        private void EditImageSizeMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.Resize(2000, 1000);
            UpdateInterface();
        }

        private void InShadesOfGreyMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetGrayscale();
            UpdateInterface();
        }

        private void ShowChannelMainMenuItemClick(object sender, EventArgs e)
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

        #endregion
    }
}
