namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Drawing Tools Panel Items --

        public bool IsDrawing { get; set; } = false;
        public DrawingTools Tool { get; set; } = DrawingTools.Cursor;
        public enum DrawingTools
        {
            Cursor,
            Brush,
            Eraser,
            Pipette,
            Filling,
            Line,
            Ellipse
        }

        #endregion

        #region -- Drawing Tools Panel Events --

        private void DrawingToolsPanelCursorButton_Click(object sender, EventArgs e)
        {
            Tool = DrawingTools.Cursor;
            IsDrawing = false;
            Cursor.Current = Cursors.Default;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = Color.Black;
        }

        private void DrawingToolsPanelBrushButton_Click(object sender, EventArgs e)
        {
            Tool = DrawingTools.Brush;
            IsDrawing = true;
            Cursor.Current = Cursors.Cross;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = BrushColor;           
        }

        private void DrawingToolsPanelEraserButton_Click(object sender, EventArgs e)
        {
            Tool = DrawingTools.Eraser;
            IsDrawing = true;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = ErazerSize.ToString();
            mainToolsPanelColorButton.BackColor = Color.Black;
        }

        private void DrawingToolsPanelPipetteButton_Click(object sender, EventArgs e)
        {
            Tool = DrawingTools.Pipette;
            IsDrawing = false;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = PipetteColor;
        }

        private void DrawingToolsPanelFillingButton_Click(object sender, EventArgs e)
        {
            Tool = DrawingTools.Filling;
            IsDrawing = false;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelColorButton.BackColor = FillingColor;
        }

        private void DrawingToolsPanelLineButton_Click(object sender, EventArgs e)
        {
            Tool = DrawingTools.Line;
            IsDrawing = true;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = BrushColor;
        }

        private void DrawingToolsPanelEllipseButton_Click(object sender, EventArgs e)
        {
            Tool = DrawingTools.Ellipse;
            IsDrawing = true;
            mainToolsPanelColorButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Enabled = true;
            mainToolsPanelSizeSplitButton.Text = BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = BrushColor;
        }

        #endregion
    }
}
