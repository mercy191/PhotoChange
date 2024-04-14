using PhotoChange.Renderer;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Picture Box Canvas Panel Events --

        private void PictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {         
            if (pictureBoxCanvas.BackgroundImage != null)
            {
                mainToolsPanelSizeModeSplitButton.Text = pictureBoxCanvas.BackgroundImageLayout.ToString();

                switch (pictureBoxCanvas.BackgroundImageLayout)
                {
                    case ImageLayout.Zoom:
                        _imageRenderer.CalculateScaleFactor(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                        _imageRenderer.CalculateRetreat(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                        break;

                    case ImageLayout.Tile:
                        _imageRenderer.ScaleFactor = 1;
                        _imageRenderer.WidthRetreat = 0;
                        _imageRenderer.HeightRetreat = 0;
                        break;
                }
            }
        }

        private void PictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {              
                if (_selectionController.IsDrawing)
                {
                    _graphicsController.EditBitmap = new Bitmap(_imageRenderer.Image.Width, _imageRenderer.Image.Height); // Create new bitmap for drawing
                    _graphicsController.BitmapGraphics = Graphics.FromImage(_graphicsController.EditBitmap);
                    _graphicsController.VisualGraphics = pictureBoxCanvas.CreateGraphics();

                    switch (_imageDrawing.Tool)
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
                            switch(_selectionController.MouseClickNum)
                            {
                                case 1:
                                    _selectionController.MouseLastDownPosition = new PointF(e.Location.X, e.Location.Y);
                                    _selectionController.MouseClickNum = 2;
                                    break;
                                case 2:
                                    _graphicsController.BitmapGraphics.DrawLine
                                        (
                                        new Pen(_imageDrawing.BrushColor, _imageDrawing.BrushSize),
                                        _imageRenderer.ConvertToProportions(_selectionController.MouseLastDownPosition),
                                        _imageRenderer.ConvertToProportions(e.Location)
                                        );
                                    _graphicsController.VisualGraphics.DrawLine
                                        (
                                        new Pen(_imageDrawing.BrushColor, _imageDrawing.BrushSize / _imageRenderer.ScaleFactor),
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
                                        new Pen(_imageDrawing.BrushColor, _imageDrawing.BrushSize),
                                        new RectangleF
                                            (
                                            _imageRenderer.ConvertXToProportions(_selectionController.MouseLastDownPosition.X),
                                            _imageRenderer.ConvertYToProportions(_selectionController.MouseLastDownPosition.Y),
                                            _imageRenderer.ConvertXToProportions(e.Location.X) - _imageRenderer.ConvertXToProportions(_selectionController.MouseLastDownPosition.X),
                                            _imageRenderer.ConvertYToProportions(e.Location.Y) - _imageRenderer.ConvertYToProportions(_selectionController.MouseLastDownPosition.Y)   
                                            )
                                        );
                                    _graphicsController.VisualGraphics.DrawEllipse
                                        (
                                        new Pen(_imageDrawing.BrushColor, _imageDrawing.BrushSize / _imageRenderer.ScaleFactor),
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
                    switch (_imageDrawing.Tool)
                    {
                        case ImageDrawing.DrawingTools.Pipette:
                            var bmp = new Bitmap(_imageRenderer.Image);
                            _imageDrawing.PipetteColor = bmp.GetPixel((int)_imageRenderer.ConvertXToProportions(e.Location.X), (int)_imageRenderer.ConvertYToProportions(e.Location.Y));
                            mainToolsPanelColorButton.BackColor = _imageDrawing.PipetteColor;
                            break;
                    }
                }
            }
        }

        private void PictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            cursorPosition.Text = string.Format("{0}, {1}", _imageRenderer.ConvertXToProportions(e.Location.X), _imageRenderer.ConvertYToProportions(e.Location.Y));
            
            if (_selectionController.IsDrawing && _selectionController.IsMouseDown)
            {                
                switch (_imageDrawing.Tool)
                {
                    case ImageDrawing.DrawingTools.Brush:                       
                        _graphicsController.BitmapGraphics.DrawEllipse
                            (
                            new Pen(_imageDrawing.BrushColor, _imageDrawing.BrushSize), 
                            _imageRenderer.ConvertXToProportions(e.Location.X),
                            _imageRenderer.ConvertYToProportions(e.Location.Y),
                            _imageDrawing.BrushSize,
                            _imageDrawing.BrushSize
                            );
                        _graphicsController.VisualGraphics.DrawEllipse
                            (
                            new Pen(_imageDrawing.BrushColor, _imageDrawing.BrushSize / _imageRenderer.ScaleFactor), 
                            e.Location.X, 
                            e.Location.Y,
                            _imageDrawing.BrushSize / _imageRenderer.ScaleFactor,
                            _imageDrawing.BrushSize / _imageRenderer.ScaleFactor
                            );
                        break;

                    case ImageDrawing.DrawingTools.Eraser:
                        _graphicsController.BitmapGraphics.DrawEllipse
                            (
                            new Pen(_imageDrawing.ErazerColor, _imageDrawing.ErazerSize),
                            _imageRenderer.ConvertXToProportions(e.Location.X),
                            _imageRenderer.ConvertYToProportions(e.Location.Y),
                            _imageDrawing.ErazerSize,
                            _imageDrawing.ErazerSize
                            );
                        _graphicsController.VisualGraphics.DrawEllipse
                            (
                            new Pen(pictureBoxCanvas.BackColor, _imageDrawing.ErazerSize / _imageRenderer.ScaleFactor), 
                            e.Location.X, 
                            e.Location.Y,
                            _imageDrawing.ErazerSize / _imageRenderer.ScaleFactor,
                            _imageDrawing.ErazerSize / _imageRenderer.ScaleFactor
                            );
                        break;
                }
            }
        }

        private void PictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (_selectionController.IsDrawing && _selectionController.IsMouseDown)
            {
                Graphics g = Graphics.FromImage(_imageRenderer.Image); // Add new bitmap on current Image
                g.DrawImage(_graphicsController.EditBitmap, 0, 0);
                g.Dispose();

                if (_imageRenderer.EditList.Count != 0)
                {
                    Bitmap lastBitmap = new Bitmap(_imageRenderer.EditList[^1]); // Add current bitmap on last bitmap
                    g = Graphics.FromImage(lastBitmap);
                    g.DrawImage(_graphicsController.EditBitmap, 0, 0);
                    g.Dispose();

                    _imageRenderer.EditList.Add(lastBitmap); // Add new bitmap
                }
                else
                {
                    _imageRenderer.EditList.Add(new Bitmap(_graphicsController.EditBitmap)); // Add new bitmap
                }
               
                _selectionController.IsMouseDown = false;
                _imageRenderer.EditListIterator += 1;

                pictureBoxCanvas.BackgroundImage = _imageRenderer.Image; // View current image on Background
                undoMainMenuItem.Enabled = true;
            }
        }

        #endregion
    }
}
