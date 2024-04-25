using PhotoChange.Renderer;

namespace PhotoChange
{  
    public partial class MainForm
    {
        #region -- Picture Box Canvas Events --

        private void PictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;
            
            _selectionController.CurrentLayer.ImageRenderer.CalculateRetreat(pictureBoxCanvas.Width, pictureBoxCanvas.Height);                     
        }

        private void PictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            if (e.Button == MouseButtons.Left)
            {
                if (_selectionController.IsDrawing)
                {
                    _graphicsController.EditBitmap = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.OriginalImage); // Create new bitmap for drawing
                    _graphicsController.BitmapGraphics = Graphics.FromImage(_graphicsController.EditBitmap);
                    _graphicsController.VisualGraphics = pictureBoxCanvas.CreateGraphics();

                    switch (_selectionController.CurrentLayer.ImageDrawing.Tool)
                    {
                        case ImageDrawing.DrawingTools.Brush:
                            _selectionController.IsMouseDown = true;
                            break;

                        case ImageDrawing.DrawingTools.Eraser:
                            _selectionController.IsMouseDown = true;
                            break;

                        case ImageDrawing.DrawingTools.Filling:
                            _selectionController.IsMouseDown = true;
                            break;

                        case ImageDrawing.DrawingTools.Line:
                            switch (_selectionController.MouseClickNum)
                            {
                                case 1:
                                    _selectionController.MouseLastDownPosition = new PointF(e.Location.X, e.Location.Y);
                                    _selectionController.MouseClickNum = 2;
                                    break;
                                case 2:
                                    _graphicsController.BitmapGraphics.DrawLine
                                        (
                                        new Pen(_selectionController.CurrentLayer.ImageDrawing.BrushColor, _selectionController.CurrentLayer.ImageDrawing.BrushSize),
                                        _selectionController.CurrentLayer.ImageRenderer.ConvertToProportions(_selectionController.MouseLastDownPosition),
                                       _selectionController.CurrentLayer.ImageRenderer.ConvertToProportions(e.Location)
                                        );
                                    _graphicsController.VisualGraphics.DrawLine
                                        (
                                        new Pen(_selectionController.CurrentLayer.ImageDrawing.BrushColor, _selectionController.CurrentLayer.ImageDrawing.BrushSize / _selectionController.CurrentLayer.ImageRenderer.ScaleFactor),
                                        _selectionController.MouseLastDownPosition,
                                        e.Location
                                        );

                                    _selectionController.IsMouseDown = true;
                                    _selectionController.MouseClickNum = 1;
                                    break;
                            }
                            break;

                        case ImageDrawing.DrawingTools.Ellipse:
                            switch (_selectionController.MouseClickNum)
                            {
                                case 1:
                                    _selectionController.MouseLastDownPosition = new PointF(e.Location.X, e.Location.Y);
                                    _selectionController.MouseClickNum = 2;
                                    break;
                                case 2:
                                    _graphicsController.BitmapGraphics.DrawEllipse
                                        (
                                        new Pen(_selectionController.CurrentLayer.ImageDrawing.BrushColor, _selectionController.CurrentLayer.ImageDrawing.BrushSize),
                                        new RectangleF
                                            (
                                            _selectionController.CurrentLayer.ImageRenderer.ConvertXToProportions(_selectionController.MouseLastDownPosition.X),
                                            _selectionController.CurrentLayer.ImageRenderer.ConvertYToProportions(_selectionController.MouseLastDownPosition.Y),
                                            _selectionController.CurrentLayer.ImageRenderer.ConvertXToProportions(e.Location.X) - _selectionController.CurrentLayer.ImageRenderer.ConvertXToProportions(_selectionController.MouseLastDownPosition.X),
                                            _selectionController.CurrentLayer.ImageRenderer.ConvertYToProportions(e.Location.Y) - _selectionController.CurrentLayer.ImageRenderer.ConvertYToProportions(_selectionController.MouseLastDownPosition.Y)
                                            )
                                        );
                                    _graphicsController.VisualGraphics.DrawEllipse
                                        (
                                        new Pen(_selectionController.CurrentLayer.ImageDrawing.BrushColor, _selectionController.CurrentLayer.ImageDrawing.BrushSize / _selectionController.CurrentLayer.ImageRenderer.ScaleFactor),
                                        new RectangleF
                                            (
                                            _selectionController.MouseLastDownPosition.X,
                                            _selectionController.MouseLastDownPosition.Y,
                                            e.Location.X - _selectionController.MouseLastDownPosition.X,
                                            e.Location.Y - _selectionController.MouseLastDownPosition.Y
                                            )
                                        );

                                    _selectionController.IsMouseDown = true;
                                    _selectionController.MouseClickNum = 1;
                                    break;
                            }
                            break;
                    }
                }

                else
                {
                    switch (_selectionController.CurrentLayer.ImageDrawing.Tool)
                    {
                        case ImageDrawing.DrawingTools.Pipette:
                            var bmp = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.OriginalImage);
                            _selectionController.CurrentLayer.ImageDrawing.PipetteColor = bmp.GetPixel(
                                (int)_selectionController.CurrentLayer.ImageRenderer.ConvertXToProportions(e.Location.X),
                                (int)_selectionController.CurrentLayer.ImageRenderer.ConvertYToProportions(e.Location.Y)
                                );
                            mainToolsPanelColorButton.BackColor = _selectionController.CurrentLayer.ImageDrawing.PipetteColor;
                            break;
                    }
                }
            }
        }

        private void PictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            if (_selectionController.IsDrawing && _selectionController.IsMouseDown)
            {
                switch (_selectionController.CurrentLayer.ImageDrawing.Tool)
                {
                    case ImageDrawing.DrawingTools.Brush:
                        _graphicsController.BitmapGraphics.DrawEllipse
                            (
                            new Pen(_selectionController.CurrentLayer.ImageDrawing.BrushColor, _selectionController.CurrentLayer.ImageDrawing.BrushSize),
                            _selectionController.CurrentLayer.ImageRenderer.ConvertXToProportions(e.Location.X),
                            _selectionController.CurrentLayer.ImageRenderer.ConvertYToProportions(e.Location.Y),
                            _selectionController.CurrentLayer.ImageDrawing.BrushSize,
                            _selectionController.CurrentLayer.ImageDrawing.BrushSize
                            );
                        _graphicsController.VisualGraphics.DrawEllipse
                            (
                            new Pen(_selectionController.CurrentLayer.ImageDrawing.BrushColor, _selectionController.CurrentLayer.ImageDrawing.BrushSize / _selectionController.CurrentLayer.ImageRenderer.ScaleFactor),
                            e.Location.X,
                            e.Location.Y,
                            _selectionController.CurrentLayer.ImageDrawing.BrushSize / _selectionController.CurrentLayer.ImageRenderer.ScaleFactor,
                            _selectionController.CurrentLayer.ImageDrawing.BrushSize / _selectionController.CurrentLayer.ImageRenderer.ScaleFactor
                            );
                        break;

                    case ImageDrawing.DrawingTools.Eraser:
                        _graphicsController.BitmapGraphics.DrawEllipse
                            (
                            new Pen(_selectionController.CurrentLayer.ImageDrawing.ErazerColor, _selectionController.CurrentLayer.ImageDrawing.ErazerSize),
                            _selectionController.CurrentLayer.ImageRenderer.ConvertXToProportions(e.Location.X),
                            _selectionController.CurrentLayer.ImageRenderer.ConvertYToProportions(e.Location.Y),
                            _selectionController.CurrentLayer.ImageDrawing.ErazerSize,
                            _selectionController.CurrentLayer.ImageDrawing.ErazerSize
                            );
                        _graphicsController.VisualGraphics.DrawEllipse
                            (
                            new Pen(pictureBoxCanvas.BackColor, _selectionController.CurrentLayer.ImageDrawing.ErazerSize / _selectionController.CurrentLayer.ImageRenderer.ScaleFactor),
                            e.Location.X,
                            e.Location.Y,
                            _selectionController.CurrentLayer.ImageDrawing.ErazerSize / _selectionController.CurrentLayer.ImageRenderer.ScaleFactor,
                            _selectionController.CurrentLayer.ImageDrawing.ErazerSize / _selectionController.CurrentLayer.ImageRenderer.ScaleFactor
                            );
                        break;
                }
            }
        }

        private void PictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            if (_selectionController.IsDrawing && _selectionController.IsMouseDown)
            {
                _selectionController.CurrentLayer.ImageRenderer.OriginalImage = new Bitmap(_graphicsController.EditBitmap);               
                _selectionController.CurrentLayer.ImageRenderer.EditList.Add(new Bitmap(_graphicsController.EditBitmap));
                _selectionController.IsImageCreated = true;
                _selectionController.IsMouseDown = false;
                _selectionController.CurrentLayer.ImageRenderer.EditListIterator += 1;

                UpdateInterface();
            }
        }

        #endregion
    }
}
