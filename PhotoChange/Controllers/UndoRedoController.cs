namespace PhotoChange.Controllers
{
    public class UndoRedoController
    {
        public static void Undo(SelectionController selectionController)
        {
            if (selectionController.CurrentLayer.ImageRenderer.EditListIterator == 0) return;

            selectionController.CurrentLayer.ImageRenderer.OriginalImage = new Bitmap(selectionController.CurrentLayer.ImageRenderer.EditList[--selectionController.CurrentLayer.ImageRenderer.EditListIterator]);
        }

        public static void Redo(SelectionController selectionController)
        {
            if (selectionController.CurrentLayer.ImageRenderer.EditListIterator == selectionController.CurrentLayer.ImageRenderer.EditList.Count - 1) return;

            selectionController.CurrentLayer.ImageRenderer.OriginalImage = new Bitmap(selectionController.CurrentLayer.ImageRenderer.EditList[++selectionController.CurrentLayer.ImageRenderer.EditListIterator]);          
        }
    }
}
