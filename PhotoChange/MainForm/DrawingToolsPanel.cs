using PhotoChange.Entities;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Drawing Tools Panel Events --

        private void DrawingToolsPanelCursorButton_Click(object sender, EventArgs e)
        {
            _draw.Tool = Draw.DrawingTools.Cursor;
            _draw.IsDrawing = false;
            Cursor.Current = Cursors.Default;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = Color.Black;
        }

        private void DrawingToolsPanelBrushButton_Click(object sender, EventArgs e)
        {
            _draw.Tool = Draw.DrawingTools.Brush;
            _draw.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _draw.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _draw.BrushColor;           
        }

        private void DrawingToolsPanelEraserButton_Click(object sender, EventArgs e)
        {
            _draw.Tool = Draw.DrawingTools.Eraser;
            _draw.IsDrawing = true;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _draw.ErazerSize.ToString();
            mainToolsPanelColorButton.BackColor = pictureBoxCanvas.BackColor;
        }

        private void DrawingToolsPanelPipetteButton_Click(object sender, EventArgs e)
        {
            _draw.Tool = Draw.DrawingTools.Pipette;
            _draw.IsDrawing = false;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = _draw.PipetteColor;
        }

        private void DrawingToolsPanelFillingButton_Click(object sender, EventArgs e)
        {
            _draw.Tool = Draw.DrawingTools.Filling;
            _draw.IsDrawing = false;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = _draw.FillingColor;
        }

        private void DrawingToolsPanelPointButton_Click(object sender, EventArgs e)
        {
            _draw.Tool = Draw.DrawingTools.Point;
            _draw.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _draw.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _draw.BrushColor;
        }

        private void DrawingToolsPanelLineButton_Click(object sender, EventArgs e)
        {
            _draw.Tool = Draw.DrawingTools.Line;
            _draw.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _draw.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _draw.BrushColor;
        }

        private void DrawingToolsPanelEllipseButton_Click(object sender, EventArgs e)
        {
            _draw.Tool = Draw.DrawingTools.Ellipse;
            _draw.IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = _draw.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _draw.BrushColor;
        }

        #endregion
    }
}
