using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Picture Box Panel Items --

        public bool IsMousePrressed { get; set; } = false;
        public Bitmap? Bitmap { get; set; } = null;
        public Graphics? BitmapGraphics { get; set; } = null;
        public Graphics? VisualGraphics { get; set; } = null;
        public float ScaleImage { get; set; } = 1;
        public float StepWidthImage { get; set; } = 0;
        public float StepHeightImage { get; set; } = 0;

        #endregion

        #region -- Picture Box Panel Events --

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            mainToolsPanelSizeModeSplitButton.Text = pictureBox.SizeMode.ToString();

            if (pictureBox.Image != null)
            {
                switch (pictureBox.SizeMode)
                {
                    case PictureBoxSizeMode.Zoom:
                        ScaleImage = ((float)pictureBox.Image.Width / pictureBox.Width > (float)pictureBox.Image.Height / pictureBox.Height)
                            ? (float)pictureBox.Image.Width / pictureBox.Width : (float)pictureBox.Image.Height / pictureBox.Height;

                        StepWidthImage = (pictureBox.Width - pictureBox.Image.Width / ScaleImage) / 2;
                        StepHeightImage = (pictureBox.Height - pictureBox.Image.Height / ScaleImage) / 2;
                        break;

                    case PictureBoxSizeMode.Normal:
                        ScaleImage = 1;
                        StepWidthImage = 0;
                        StepHeightImage = 0;
                        break;
                }
            }
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && pictureBox.Image != null && !IsDrawing)
            {               
                if (Tool == DrawingTools.Pipette)
                {
                    Bitmap = (Bitmap)pictureBox.Image;
                    PipetteColor = Bitmap.GetPixel((int)((e.Location.X - StepWidthImage) * ScaleImage), (int)((e.Location.Y - StepHeightImage) * ScaleImage));
                    mainToolsPanelColorButton.BackColor = PipetteColor;
                    Bitmap = null;
                }
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && pictureBox.Image != null && IsDrawing)
            {
                IsMousePrressed = true;

                Bitmap = new Bitmap(pictureBox.Image);
                pictureBox.Image.Dispose();
                pictureBox.Image = Bitmap;
                BitmapGraphics = Graphics.FromImage(Bitmap);
                VisualGraphics = pictureBox.CreateGraphics();
            }                      
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            cursorPosition.Text = string.Format("{0}, {1}", (e.Location.X - StepWidthImage) * ScaleImage, (e.Location.Y - StepHeightImage) * ScaleImage);
            
            if (IsMousePrressed && pictureBox.Image != null)
            {                
                switch (Tool)
                {
                    case DrawingTools.Cursor:
                        break;

                    case DrawingTools.Brush:                       
                        BitmapGraphics?.DrawEllipse(new Pen(BrushColor, BrushSize), (e.Location.X - StepWidthImage) * ScaleImage, (e.Location.Y - StepHeightImage) * ScaleImage, BrushSize, BrushSize);
                        VisualGraphics?.DrawEllipse(new Pen(BrushColor, BrushSize / ScaleImage), e.Location.X, e.Location.Y, BrushSize / ScaleImage, BrushSize / ScaleImage);
                        break;

                    case DrawingTools.Eraser:
                        break;

                    case DrawingTools.Filling:
                        break;

                    case DrawingTools.Line:
                        break;

                    case DrawingTools.Ellipse:
                        break;
                }
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            IsMousePrressed = false;

            if (pictureBox.Image != null && IsDrawing)
            {
                Image = pictureBox.Image;
                BitmapGraphics?.Dispose();

                LayoutList?.Add(new Bitmap(Image));
                LayoutListIterator += 1;
            }           
        }

        #endregion
    }
}
