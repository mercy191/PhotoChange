namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Drawing Tools Panel Items --

        public Color BrushColor { get; set; } = Color.White;
        public Color PipetteColor { get; set; } = Color.White;
        public Color FillingColor { get; set; } = Color.White;
        public bool IsBrushSelected { get; set; } = false;
        public bool IsEraserSelected { get; set; } = false;
        public bool IsPipetteSelected { get; set; } = false;
        public bool IsFillingSelected { get; set; } = false;

        #endregion

        #region -- Drawing Tools Panel Events --

        private void DrawingToolsPanelBrushButton_Click(object sender, EventArgs e)
        {
            IsBrushSelected = true;
        }

        private void DrawingToolsPanelEraserButton_Click(object sender, EventArgs e)
        {
            IsEraserSelected = true;
        }

        private void DrawingToolsPanelPipetteButton_Click(object sender, EventArgs e)
        {
            IsPipetteSelected = true;
        }

        private void DrawingToolsPanelFillingButton_Click(object sender, EventArgs e)
        {
            IsFillingSelected = true;
        }

        #endregion
    }
}
