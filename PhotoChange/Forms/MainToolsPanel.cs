namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Main Tools Panel Items --

        public float BrushSize { get; set; } = 3f;
        public float ErazerSize { get; set; } = 3f;
        public Color BrushColor { get; set; } = Color.Black;
        public Color PipetteColor { get; set; } = Color.Black;
        public Color FillingColor { get; set; } = Color.Black;

        #endregion

        #region -- Main Tools Panel Events --

        private void MainToolsPanelHomeButton_Click(object sender, EventArgs e)
        {

        }

        private void MainToolsPanelColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (Tool == DrawingTools.Brush 
                    || Tool == DrawingTools.Line
                    || Tool == DrawingTools.Ellipse)
                {
                    BrushColor = colorDialog.Color;
                    mainToolsPanelColorButton.BackColor = colorDialog.Color;
                }
                
                if (Tool == DrawingTools.Filling)
                {
                    FillingColor = colorDialog.Color;
                    mainToolsPanelColorButton.BackColor = colorDialog.Color;
                }
            }
        }

        private void TileMainToolsPanelItem_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImageLayout = ImageLayout.Tile;
            mainToolsPanelSizeModeSplitButton.Text = pictureBox.SizeMode.ToString();
        }

        private void ZoomMainToolsPanelItem_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            mainToolsPanelSizeModeSplitButton.Text = pictureBox.SizeMode.ToString();
        }

        private void Size3MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (Tool == DrawingTools.Brush
                    || Tool == DrawingTools.Line
                    || Tool == DrawingTools.Ellipse)
            {
                BrushSize = Convert.ToSingle(size3MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = BrushSize.ToString();
            }

            else if (Tool == DrawingTools.Eraser)
            {
                ErazerSize = Convert.ToSingle(size3MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size4MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (Tool == DrawingTools.Brush
                    || Tool == DrawingTools.Line
                    || Tool == DrawingTools.Ellipse)
            {
                BrushSize = Convert.ToSingle(size4MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = BrushSize.ToString();
            }

            else if (Tool == DrawingTools.Eraser)
            {
                ErazerSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size5MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (Tool == DrawingTools.Brush
                    || Tool == DrawingTools.Line
                    || Tool == DrawingTools.Ellipse)
            {
                BrushSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = BrushSize.ToString();
            }

            else if (Tool == DrawingTools.Eraser)
            {
                ErazerSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size20MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (Tool == DrawingTools.Brush
                    || Tool == DrawingTools.Line
                    || Tool == DrawingTools.Ellipse)
            {
                BrushSize = Convert.ToSingle(size20MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = BrushSize.ToString();
            }

            else if (Tool == DrawingTools.Eraser)
            {
                ErazerSize = Convert.ToSingle(size20MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        #endregion
    }
}
