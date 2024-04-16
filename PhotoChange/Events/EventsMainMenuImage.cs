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
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void RotateLeftMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.Rotate90FlipNone);
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void RotateRightMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void FlipVerticallyMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void FlipHorizontallyMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void EditImageSizeMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.Resize(2000, 1000);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void InShadesOfGreyMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetGrayscale();
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void RedChannelMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetColorFilter(ImageRenderer.ColorFilterTypes.Red);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image; 
            undoMainMenuItem.Enabled = true;
        }

        private void GreenChannelMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetColorFilter(ImageRenderer.ColorFilterTypes.Green);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void BlueChannelMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetColorFilter(ImageRenderer.ColorFilterTypes.Blue);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void AllChannelMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetInvert(ImageRenderer.ColorFilterTypes.All);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void RedMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetInvert(ImageRenderer.ColorFilterTypes.Red);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void GreenMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetInvert(ImageRenderer.ColorFilterTypes.Green);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        private void BlueMainMenuItem_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageRenderer.SetInvert(ImageRenderer.ColorFilterTypes.Blue);
            pictureBoxCanvas.BackgroundImage = null;
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            undoMainMenuItem.Enabled = true;
        }

        #endregion
    }
}
