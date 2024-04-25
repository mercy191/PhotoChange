using PhotoChange.Controllers;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Main Menu Edit Events --

        private void UndoRedoMainMenuItem_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            if (sender == undoMainMenuItem)
            {
                UndoRedoController.Undo(_selectionController);
            }

            else if (sender == redoMainMenuItem)
            {
                UndoRedoController.Redo(_selectionController);              
            }

            UpdateInterface();
        }

        private void CopyPasteMainMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == copyMainMenuItem)
            {
                if (_selectionController.IsImageCreated) 
                    Clipboard.SetImage(_selectionController.CurrentLayer.ImageRenderer.OriginalImage);
            }

            else if (sender == pasteMainMenuItem)
            {
                if (Clipboard.GetImage() != null)
                    _selectionController.CurrentLayer.ImageRenderer.OriginalImage = new Bitmap(Clipboard.GetImage());
                UpdateInterface();
            }
        }

        #endregion
    }
}
