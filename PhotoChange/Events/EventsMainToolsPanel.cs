using PhotoChange.Common;
using PhotoChange.Controls;
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
            if (!_selectionController.IsImageCreated) return;

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
            if (!_selectionController.IsImageCreated) return;

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
            if (!_selectionController.IsImageCreated) return;

            if (e.KeyCode == Keys.Enter)
            {
                _selectionController.CurrentLayer.ImageRenderer.ScalePercent = Convert.ToSingle(editScaleMainToolsPanelTextBox.Text);
                UpdateInterface();
            }
        }

        private void CombineLayersMainToolsPanelButton_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            var indexCollection = layersListBox.SelectedIndices;
            List<Bitmap> images = new List<Bitmap>();

            foreach (int index in indexCollection)
            {
                images.Add(new Bitmap(_layers[index].ImageRenderer.OriginalImage));

                int i = images.IndexOf(images.Last());
                if (images[i].Width < images[i].Height)
                {
                    images[i] = ImageHelper.RotateImage(images[index], 270);
                }
            }

            List<Bitmap> sortedImages = images.OrderBy(image => image.Width).ToList();
            Bitmap newImage = new Bitmap(sortedImages.First().Width, sortedImages.First().Height);

            for (int i = 0; i < sortedImages.Count; i++)
            {
                sortedImages[i] = ImageHelper.ResizeImage(sortedImages[i], newImage.Width, newImage.Height);
                ImageHelper.CombineImage(newImage, sortedImages[i]);
            }

            _layers.Add(new Layer(
                new ImageRenderer(newImage),
                new ImageDrawing(),
                new ImageInfo()
                ));
            _selectionController.IsImageCreated = true;
            _selectionController.CurrentLayer = _layers.Last();
            _selectionController.CurrentLayerNumber = _layers.LastIndexOf(_selectionController.CurrentLayer);
            _selectionController.CurrentLayer.ImageRenderer.CalculateScaleFactor(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            _selectionController.CurrentLayer.ImageRenderer.CalculateRetreat(pictureBoxCanvas.Width, pictureBoxCanvas.Height);

            layersListBox.Items.Add("new_layer");
            UpdateInterface();
        }

        private void GlueImagesMainToolsPanelButton_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            var indexCollection = layersListBox.SelectedIndices;
            if (indexCollection.Count != 2) 
            {
                MessageBox.Show("Enter 2 images!", "Message");
                return;
            }

            List<Bitmap> images = new List<Bitmap>();
            foreach (int index in indexCollection)
            {
                images.Add(new Bitmap(_layers[index].ImageRenderer.OriginalImage));
            }
            Bitmap firstImage = images[0];
            Bitmap secondImage = images[1];

            GlueImagesHelper glueImagesHelper = new GlueImagesHelper();
            GlueImagesForm glueImagesForm = new GlueImagesForm(glueImagesHelper, firstImage, secondImage);
            glueImagesForm.ShowDialog();

            if (glueImagesHelper.IsChanged)
            {
                Bitmap resultImage;
                if (glueImagesHelper.SecondImageOnTop)
                {
                    Bitmap temp = ImageHelper.ResizeImage(secondImage, (int)(secondImage.Width / glueImagesHelper.ScaleFactor.X), (int)(secondImage.Height / glueImagesHelper.ScaleFactor.Y));
                    resultImage = new Bitmap(firstImage);
                    ImageHelper.GlueImage(resultImage, temp, glueImagesHelper.GlueLocation);
                }
                else
                {
                    Bitmap temp = ImageHelper.ResizeImage(firstImage, (int)(firstImage.Width * glueImagesHelper.ScaleFactor.X), (int)(firstImage.Height * glueImagesHelper.ScaleFactor.Y));
                    resultImage = new Bitmap(secondImage);
                    ImageHelper.GlueImage(resultImage, temp, glueImagesHelper.GlueLocation);
                }

                _layers.Add(new Layer(
                new ImageRenderer(resultImage),
                new ImageDrawing(),
                new ImageInfo()
                ));
                _selectionController.IsImageCreated = true;
                _selectionController.CurrentLayer = _layers.Last();
                _selectionController.CurrentLayerNumber = _layers.LastIndexOf(_selectionController.CurrentLayer);
                _selectionController.CurrentLayer.ImageRenderer.CalculateScaleFactor(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                _selectionController.CurrentLayer.ImageRenderer.CalculateRetreat(pictureBoxCanvas.Width, pictureBoxCanvas.Height);

                layersListBox.Items.Add("new_layer");
                UpdateInterface();
            }         
        }

        #endregion
    }
}
