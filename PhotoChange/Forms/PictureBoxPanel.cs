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
        public Bitmap? Layer { get; set; } = null;
        public Graphics? LayerGraphics { get; set; } = null;
        public Graphics? VisualGraphics { get; set; } = null;
        public float ScaleImage { get; set; } = 1;
        public float StepWidthImage { get; set; } = 0;
        public float StepHeightImage { get; set; } = 0;

        #endregion

        #region -- Picture Box Panel Events --

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {         
            if (pictureBox.BackgroundImage != null)
            {
                mainToolsPanelSizeModeSplitButton.Text = pictureBox.BackgroundImageLayout.ToString();

                switch (pictureBox.BackgroundImageLayout)
                {
                    case ImageLayout.Zoom:
                        ScaleImage = ((float)pictureBox.BackgroundImage.Width / pictureBox.Width > (float)pictureBox.BackgroundImage.Height / pictureBox.Height)
                            ? (float)pictureBox.BackgroundImage.Width / pictureBox.Width : (float)pictureBox.BackgroundImage.Height / pictureBox.Height;

                        StepWidthImage = (pictureBox.Width - pictureBox.BackgroundImage.Width / ScaleImage) / 2;
                        StepHeightImage = (pictureBox.Height - pictureBox.BackgroundImage.Height / ScaleImage) / 2;
                        break;

                    case ImageLayout.Tile:
                        ScaleImage = 1;
                        StepWidthImage = 0;
                        StepHeightImage = 0;
                        break;
                }
            }
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Image != null && !IsDrawing)
            {               
                if (Tool == DrawingTools.Pipette)
                {
                    Layer = new Bitmap(Image);
                    PipetteColor = Layer.GetPixel((int)((e.Location.X - StepWidthImage) * ScaleImage), (int)((e.Location.Y - StepHeightImage) * ScaleImage));
                    mainToolsPanelColorButton.BackColor = PipetteColor;
                    Layer?.Dispose();
                }
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Image != null && IsDrawing)
            {
                IsMousePrressed = true;

                Layer = new Bitmap(Image.Width, Image.Height); // Create new layer for drawing
                LayerGraphics = Graphics.FromImage(Layer);
                VisualGraphics = pictureBox.CreateGraphics();
            }                      
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            cursorPosition.Text = string.Format("{0}, {1}", (e.Location.X - StepWidthImage) * ScaleImage, (e.Location.Y - StepHeightImage) * ScaleImage);
            
            if (IsMousePrressed)
            {                
                switch (Tool)
                {
                    case DrawingTools.Cursor:
                        break;

                    case DrawingTools.Brush:                       
                        LayerGraphics?.DrawEllipse(new Pen(BrushColor, BrushSize), (e.Location.X - StepWidthImage) * ScaleImage, (e.Location.Y - StepHeightImage) * ScaleImage, BrushSize, BrushSize);
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

            if (Layer != null && Image != null && LayersList != null && IsDrawing)
            {
                Graphics g = Graphics.FromImage(Image); // Add new layer on current Image
                g.DrawImage(Layer, 0, 0);
                g.Dispose();

                if (LayersList.Count != 0)
                {
                    Bitmap lastLayout = new Bitmap(LayersList[^1]); // Add current layer on last layer
                    g = Graphics.FromImage(lastLayout);
                    g.DrawImage(Layer, 0, 0);
                    g.Dispose();

                    LayersList?.Add(lastLayout); // Add new layer 
                }
                else
                {
                    LayersList?.Add(new Bitmap(Layer)); // Add new layer from bitmap
                }
                               
                LayersListIterator += 1;
                VisualGraphics?.Dispose();
                LayerGraphics?.Dispose();              
                Layer?.Dispose();
                
                pictureBox.BackgroundImage = Image; // View current image on Background                          
            }           
        }

        #endregion
    }
}
