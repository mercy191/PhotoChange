using PhotoChange.Renderer;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Drawing Tools Panel Events --

        private void DrawingToolsPanelCursorButton_Click(object sender, EventArgs e)
        {
            _imageDrawing.Tool = ImageDrawing.DrawingTools.Cursor;
            _selectionController.IsDrawing = false;
            Cursor.Current = Cursors.Default;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = Color.Black;
        }

        private void DrawingToolsPanelBrushButton_Click(object sender, EventArgs e)
        {
            _imageDrawing.Tool = ImageDrawing.DrawingTools.Brush;
            _selectionController.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _imageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _imageDrawing.BrushColor;           
        }

        private void DrawingToolsPanelEraserButton_Click(object sender, EventArgs e)
        {
            _imageDrawing.Tool = ImageDrawing.DrawingTools.Eraser;
            _selectionController.IsDrawing = true;
            _imageDrawing.ErazerColor = pictureBoxCanvas.BackColor;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _imageDrawing.ErazerSize.ToString();
            mainToolsPanelColorButton.BackColor = _imageDrawing.ErazerColor;
        }

        private void DrawingToolsPanelPipetteButton_Click(object sender, EventArgs e)
        {
            _imageDrawing.Tool = ImageDrawing.DrawingTools.Pipette;
            _selectionController.IsDrawing = false;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = _imageDrawing.PipetteColor;
        }

        private void DrawingToolsPanelFillingButton_Click(object sender, EventArgs e)
        {
            _imageDrawing.Tool = ImageDrawing.DrawingTools.Filling;
            _selectionController.IsDrawing = false;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = _imageDrawing.FillingColor;
        }

        private void DrawingToolsPanelLineButton_Click(object sender, EventArgs e)
        {
            _imageDrawing.Tool = ImageDrawing.DrawingTools.Line;
            _selectionController.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _imageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _imageDrawing.BrushColor;
        }

        private void DrawingToolsPanelEllipseButton_Click(object sender, EventArgs e)
        {
            _imageDrawing.Tool = ImageDrawing.DrawingTools.Ellipse;
            _selectionController.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _imageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _imageDrawing.BrushColor;
        }

        #endregion
    }
}
