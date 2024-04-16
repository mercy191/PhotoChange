using PhotoChange.Controllers;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Main Menu Edit Events --

        private void UndoMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            UndoRedoController.Undo(_selectionController);
            UpdateInterface();
        }

        private void RedoMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            UndoRedoController.Redo(_selectionController);
            UpdateInterface();
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

        #endregion
    }
}
