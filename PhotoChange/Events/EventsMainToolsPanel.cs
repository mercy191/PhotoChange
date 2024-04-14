using PhotoChange.Renderer;

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
                if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Brush 
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Line
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Ellipse)
                {
                    _imageDrawing.BrushColor = colorDialog.Color;
                    mainToolsPanelColorButton.BackColor = colorDialog.Color;
                }
                
                if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Filling)
                {
                    _imageDrawing.FillingColor = colorDialog.Color;
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
            if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Brush
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Line
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Ellipse)
            {
                _imageDrawing.BrushSize = Convert.ToSingle(size3MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _imageDrawing.BrushSize.ToString();
            }

            else if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Eraser)
            {
                _imageDrawing.ErazerSize = Convert.ToSingle(size3MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _imageDrawing.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size4MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Brush
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Line
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Ellipse)
            {
                _imageDrawing.BrushSize = Convert.ToSingle(size4MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _imageDrawing.BrushSize.ToString();
            }

            else if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Eraser)
            {
                _imageDrawing.ErazerSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _imageDrawing.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size5MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Brush
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Line
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Ellipse)
            {
                _imageDrawing.BrushSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _imageDrawing.BrushSize.ToString();
            }

            else if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Eraser)
            {
                _imageDrawing.ErazerSize = Convert.ToSingle(size5MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _imageDrawing.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void Size20MainToolsPanelItem_Click(object sender, EventArgs e)
        {
            if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Brush
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Line
                    || _imageDrawing.Tool == ImageDrawing.DrawingTools.Ellipse)
            {
                _imageDrawing.BrushSize = Convert.ToSingle(size20MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _imageDrawing.BrushSize.ToString();
            }

            else if (_imageDrawing.Tool == ImageDrawing.DrawingTools.Eraser)
            {
                _imageDrawing.ErazerSize = Convert.ToSingle(size20MainToolsPanelItem.Text);
                mainToolsPanelSizeSplitButton.Text = _imageDrawing.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        #endregion
    }
}
