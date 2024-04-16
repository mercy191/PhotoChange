using PhotoChange.Controllers;
using PhotoChange.Renderer;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Drawing Tools Panel Events --

        private void DrawingToolsPanelCursorButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Mode = ImageDrawing.DrawingMode.None;
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Cursor;                    
            UpdateDrawingControls();
            mainToolsPanelColorButton.BackColor = Color.Black;
        }

        private void DrawingToolsPanelBrushButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Mode = ImageDrawing.DrawingMode.Drawing;
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Brush;
            UpdateDrawingControls();
            mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.BrushColor;           
        }

        private void DrawingToolsPanelEraserButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Mode = ImageDrawing.DrawingMode.Drawing;
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Eraser;
            _selectionController.CurrentLayer.ImageDrawing.ErazerColor = pictureBoxCanvas.BackColor;
            UpdateDrawingControls();
            mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.ErazerSize.ToString();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.ErazerColor;
        }

        private void DrawingToolsPanelPipetteButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Mode = ImageDrawing.DrawingMode.None;
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Pipette;
            UpdateDrawingControls();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.PipetteColor;
        }

        private void DrawingToolsPanelFillingButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Mode = ImageDrawing.DrawingMode.Filling;
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Filling;
            UpdateDrawingControls();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.FillingColor;
        }

        private void DrawingToolsPanelLineButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Mode = ImageDrawing.DrawingMode.Drawing;
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Line;
            UpdateDrawingControls();
            mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.BrushColor;
        }

        private void DrawingToolsPanelEllipseButton_Click(object sender, EventArgs e)
        {
            _selectionController.CurrentLayer.ImageDrawing.Mode = ImageDrawing.DrawingMode.Drawing;
            _selectionController.CurrentLayer.ImageDrawing.Tool = ImageDrawing.DrawingTools.Ellipse;
            UpdateDrawingControls();
            mainToolsPanelSizeSplitButton.Text = _selectionController.CurrentLayer.ImageDrawing.BrushSize.ToString();
            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.BrushColor;
        }

        #endregion
    }
}
