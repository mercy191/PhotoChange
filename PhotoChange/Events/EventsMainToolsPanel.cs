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
                if (_selectionController.CurrentLayer.ImageDrawing.Tool == ImageDrawing.DrawingTools.Brush 
                    || _selectionController.CurrentLayer.ImageDrawing.Tool == ImageDrawing.DrawingTools.Line
                    || _selectionController.CurrentLayer.ImageDrawing.Tool == ImageDrawing.DrawingTools.Ellipse)
                {
                    _selectionController.CurrentLayer.ImageDrawing.BrushColor = colorDialog.Color;
                    mainToolsPanelColorButton.BackColor = colorDialog.Color;
                }
                
                if (_selectionController.CurrentLayer.ImageDrawing.Tool == ImageDrawing.DrawingTools.Filling)
                {
                    _selectionController.CurrentLayer.ImageDrawing.FillingColor = colorDialog.Color;
                    mainToolsPanelColorButton.BackColor = colorDialog.Color;
                }
            }
        }

        private void SizeMainToolsPanelItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (_selectionController.CurrentLayer.ImageDrawing.Tool == ImageDrawing.DrawingTools.Brush
                    || _selectionController.CurrentLayer.ImageDrawing.Tool == ImageDrawing.DrawingTools.Line
                    || _selectionController.CurrentLayer.ImageDrawing.Tool == ImageDrawing.DrawingTools.Ellipse)
            {
                _selectionController.CurrentLayer.ImageDrawing.BrushSize = Convert.ToSingle(item.Text);
                mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.BrushSize.ToString();
            }

            else if (_selectionController.CurrentLayer.ImageDrawing.Tool == ImageDrawing.DrawingTools.Eraser)
            {
                _selectionController.CurrentLayer.ImageDrawing.ErazerSize = Convert.ToSingle(item.Text);
                mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.ErazerSize.ToString();
            }

            else
            {
                mainToolsPanelSizeSplitButton.Text = "0";
            }
        }

        private void EditScaleMainToolsPanelTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _selectionController.CurrentLayer.ImageRenderer.ScalePercent = Convert.ToSingle(editScaleMainToolsPanelTextBox.Text);
                UpdateInterface();
            }
        }

        #endregion
    }
}
