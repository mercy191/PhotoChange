using PhotoChange.Entities;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Picture Box Panel Items --

        public Bitmap? EditBitmap { get; protected set; } = null;
        public Graphics? BitmapGraphics { get; protected set; } = null;
        public Graphics? VisualGraphics { get; protected set; } = null;
        
        #endregion

        #region -- Picture Box Panel Events --

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
                _draw.IsMousePressed = true;

                if (_draw.IsDrawing)
                {                  
                    EditBitmap = new Bitmap(_imageRenderer.Image.Width, _imageRenderer.Image.Height); // Create new bitmap for drawing
                    BitmapGraphics = Graphics.FromImage(EditBitmap);
                    VisualGraphics = pictureBoxCanvas.CreateGraphics();
                }

                else
                {
                    if (_draw.Tool == Draw.DrawingTools.Pipette)
                    {
                        var bmp = new Bitmap(_imageRenderer.Image);
                        _draw.PipetteColor = bmp.GetPixel((int)((e.Location.X - _imageRenderer.WidthRetreat) * _imageRenderer.ScaleFactor), (int)((e.Location.Y - _imageRenderer.HeightRetreat) * _imageRenderer.ScaleFactor));
                        mainToolsPanelColorButton.BackColor = _draw.PipetteColor;
                    }
                }
            }
        }

        private void PictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            cursorPosition.Text = string.Format("{0}, {1}", (e.Location.X - _imageRenderer.WidthRetreat) * _imageRenderer.ScaleFactor, (e.Location.Y - _imageRenderer.HeightRetreat) * _imageRenderer.ScaleFactor);
            
            if (_draw.IsMousePressed && _draw.IsDrawing)
            {                
                switch (_draw.Tool)
                {
                    case Draw.DrawingTools.Cursor:
                        break;

                    case Draw.DrawingTools.Brush:                       
                        BitmapGraphics?.DrawEllipse
                            (new Pen(_draw.BrushColor, _draw.BrushSize), 
                            (e.Location.X - _imageRenderer.WidthRetreat) * _imageRenderer.ScaleFactor, 
                            (e.Location.Y - _imageRenderer.HeightRetreat) * _imageRenderer.ScaleFactor,
                            _draw.BrushSize,
                            _draw.BrushSize);
                        VisualGraphics?.DrawEllipse
                            (new Pen(_draw.BrushColor, _draw.BrushSize / _imageRenderer.ScaleFactor), 
                            e.Location.X, 
                            e.Location.Y,
                            _draw.BrushSize / _imageRenderer.ScaleFactor,
                            _draw.BrushSize / _imageRenderer.ScaleFactor);
                        break;

                    case Draw.DrawingTools.Eraser:
                        BitmapGraphics?.DrawEllipse
                            (new Pen(pictureBoxCanvas.BackColor, _draw.ErazerSize), 
                            (e.Location.X - _imageRenderer.WidthRetreat) * _imageRenderer.ScaleFactor,
                            (e.Location.Y - _imageRenderer.HeightRetreat) * _imageRenderer.ScaleFactor,
                            _draw.ErazerSize,
                            _draw.ErazerSize);
                        VisualGraphics?.DrawEllipse
                            (new Pen(pictureBoxCanvas.BackColor,
                            _draw.ErazerSize / _imageRenderer.ScaleFactor), 
                            e.Location.X, 
                            e.Location.Y,
                            _draw.ErazerSize / _imageRenderer.ScaleFactor,
                            _draw.ErazerSize / _imageRenderer.ScaleFactor);
                        break;

                    case Draw.DrawingTools.Filling:
                        break;

                    case Draw.DrawingTools.Line:
                        break;

                    case Draw.DrawingTools.Ellipse:
                        break;
                }
            }
        }

        private void PictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            _draw.IsMousePressed = false;

            if (_draw.IsDrawing && EditBitmap != null)
            {
                Graphics g = Graphics.FromImage(_imageRenderer.Image); // Add new bitmap on current Image
                g.DrawImage(EditBitmap, 0, 0);
                g.Dispose();

                if (_imageRenderer.EditList.Count != 0)
                {
                    Bitmap lastBitmap = new Bitmap(_imageRenderer.EditList[^1]); // Add current bitmap on last bitmap
                    g = Graphics.FromImage(lastBitmap);
                    g.DrawImage(EditBitmap, 0, 0);
                    g.Dispose();

                    _imageRenderer.EditList.Add(lastBitmap); // Add new bitmap
                }
                else
                {
                    _imageRenderer.EditList.Add(new Bitmap(EditBitmap)); // Add new bitmap
                }

                _imageRenderer.EditListIterator += 1;
                VisualGraphics?.Dispose();
                BitmapGraphics?.Dispose();
                EditBitmap.Dispose();

                pictureBoxCanvas.BackgroundImage = _imageRenderer.Image; // View current image on Background
                undoMainMenuItem.Enabled = true;
            }
         
        }

        #endregion
    }
}
