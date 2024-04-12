using PhotoChange.Entities;

namespace PhotoChange
{
    public partial class MainForm
    {

        #region -- Main Tools Panel Events --

        private void MainToolsPanelHomeButton_Click(object sender, EventArgs e)
        {

        }

        private void MainToolsPanelColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (_draw.Tool == Draw.DrawingTools.Brush 
                    || _draw.Tool == Draw.DrawingTools.Line
                    || _draw.Tool == Draw.DrawingTools.Ellipse)
                {
                    _draw.BrushColor = colorDialog.Color;
                    mainToolsPanelColorButton.BackColor = colorDialog.Color;
                }
                
                if (_draw.Tool == Draw.DrawingTools.Filling)
                {
                    _draw.FillingColor = colorDialog.Color;
                    mainToolsPanelColorButton.BackColor = colorDialog.Color;
                }
            }
        }

        private void TileMainToolsPanelItem_Click(object sender, EventArgs e)
        {
            pictureBoxCanvas.BackgroundImageLayout = ImageLayout.Tile;
            mainToolsPanelSizeModeSplitButton.Text = ImageLayout.Tile.ToString();
        }

        private void ZoomMainToolsPanelItem_Click(object sender, EventArgs e)
        {
            pictureBoxCanvas.BackgroundImageLayout = ImageLayout.Zoom;
            mainToolsPanelSizeModeSplitButton.Text = ImageLayout.Zoom.ToString();
        }

        private void Size3MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (_draw.Tool == Draw.DrawingTools.Brush
                    || _draw.Tool == Draw.DrawingTools.Line
                    || _draw.Tool == Draw.DrawingTools.Ellipse)
            {
                _draw.BrushSize = Convert.ToSingle(size3MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _draw.BrushSize.ToString();
            }

            else if (_draw.Tool == Draw.DrawingTools.Eraser)
            {
                _draw.ErazerSize = Convert.ToSingle(size3MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _draw.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size4MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (_draw.Tool == Draw.DrawingTools.Brush
                    || _draw.Tool == Draw.DrawingTools.Line
                    || _draw.Tool == Draw.DrawingTools.Ellipse)
            {
                _draw.BrushSize = Convert.ToSingle(size4MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _draw.BrushSize.ToString();
            }

            else if (_draw.Tool == Draw.DrawingTools.Eraser)
            {
                _draw.ErazerSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _draw.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size5MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (_draw.Tool == Draw.DrawingTools.Brush
                    || _draw.Tool == Draw.DrawingTools.Line
                    || _draw.Tool == Draw.DrawingTools.Ellipse)
            {
                _draw.BrushSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _draw.BrushSize.ToString();
            }

            else if (_draw.Tool == Draw.DrawingTools.Eraser)
            {
                _draw.ErazerSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _draw.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size20MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (_draw.Tool == Draw.DrawingTools.Brush
                    || _draw.Tool == Draw.DrawingTools.Line
                    || _draw.Tool == Draw.DrawingTools.Ellipse)
            {
                _draw.BrushSize = Convert.ToSingle(size20MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _draw.BrushSize.ToString();
            }

            else if (_draw.Tool == Draw.DrawingTools.Eraser)
            {
                _draw.ErazerSize = Convert.ToSingle(size20MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _draw.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        #endregion
    }
}
