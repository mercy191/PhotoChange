using PhotoChange.Renderer;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Drawing Tools Panel Events --

        private void DrawingToolsPanelCursorButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Cursor;
            _selectionController.IsDrawing = false;
            Cursor.Current = Cursors.Default;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = Color.Black;
        }

        private void DrawingToolsPanelBrushButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Brush;
            _selectionController.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.BrushColor;           
        }

        private void DrawingToolsPanelEraserButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Eraser;
            _selectionController.IsDrawing = true;
            _selectionController.CurrentLayer.ImageDrawing.ErazerColor = pictureBoxCanvas.BackColor;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.ErazerSize.ToString();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.ErazerColor;
        }

        private void DrawingToolsPanelPipetteButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Pipette;
            _selectionController.IsDrawing = false;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.PipetteColor;
        }

        private void DrawingToolsPanelFillingButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Filling;
            _selectionController.IsDrawing = false;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.FillingColor;
        }

        private void DrawingToolsPanelLineButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Line;
            _selectionController.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.BrushColor;
        }

        private void DrawingToolsPanelEllipseButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Ellipse;
            _selectionController.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.BrushColor;
        }

        #endregion
    }
}
