namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Main Menu Edit Events --

        private void UndoMainMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectionController.CurrentLayer.ImageRenderer.EditListIterator == -1 || pictureBoxCanvas.BackgroundImage == null) return;

            if (_selectionController.CurrentLayer.ImageRenderer.EditListIterator != 0)
            {
                _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.EditList[--_selectionController.CurrentLayer.ImageRenderer.EditListIterator]);
            }
            else
            {
                _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.OriginalImage);
                --_selectionController.CurrentLayer.ImageRenderer.EditListIterator;
            }

            if (_selectionController.CurrentLayer.ImageRenderer.EditListIterator == -1)
            {
                undoMainMenuItem.Enabled = false;
                redoMainMenuItem.Enabled = true;
            }
            else
            {
                undoMainMenuItem.Enabled = true;
                redoMainMenuItem.Enabled = true;
            }

            pictureBoxCanvas.BackgroundImage.Dispose();
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
        }

        private void RedoMainMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectionController.CurrentLayer.ImageRenderer.EditListIterator == _selectionController.CurrentLayer.ImageRenderer.EditList.Count - 1 || pictureBoxCanvas.BackgroundImage == null) return;

            _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.EditList[++_selectionController.CurrentLayer.ImageRenderer.EditListIterator]);

            if (_selectionController.CurrentLayer.ImageRenderer.EditListIterator == _selectionController.CurrentLayer.ImageRenderer.EditList.Count - 1)
            {
                redoMainMenuItem.Enabled = false;
                undoMainMenuItem.Enabled = true;
            }
            else
            {
                redoMainMenuItem.Enabled = true;
                undoMainMenuItem.Enabled = true;
            }

            pictureBoxCanvas.BackgroundImage.Dispose();
            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
        }

        private void CopyMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage != null)
                Clipboard.SetImage(pictureBoxCanvas.BackgroundImage);
        }

        private void PasteMainMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxCanvas.BackgroundImage = Clipboard.GetImage();

            if (pictureBoxCanvas.BackgroundImage != null)
                _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
        }

        private void DeleteImageMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage != null)
            {
                _selectionController.CurrentLayer.ImageRenderer.Dispose();
                _graphicsController.Dispose();
                _selectionController.IsDrawing = false;
                redoMainMenuItem.Enabled = false;
                undoMainMenuItem.Enabled = false;

                pictureBoxCanvas.BackgroundImage = null;
            }
        }

        #endregion
    }
}
