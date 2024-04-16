using PhotoChange.Renderer;
using PhotoChange.Common;

namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Main Menu File Events --

        private void OpenMainMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageRenderer imageRenderer = new ImageRenderer(openFileDialog.FileName);
                ImageDrawing imageDrawing = new ImageDrawing();
                ImageInfo imageInfo = new ImageInfo(imageRenderer);
                _layers.Add(new Layer
                    (
                    imageRenderer,
                    imageDrawing, 
                    imageInfo));
                _selectionController.CurrentLayer = _layers.Last();
                _selectionController.CurrentLayerNumber = _layers.LastIndexOf(_selectionController.CurrentLayer);

                pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;            
            }
        }

        private void RenameMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            RenameForm renameForm = new()
            { };

            if (renameForm.ShowDialog() == DialogResult.OK)
            {
                string newPath = string.Concat(_selectionController.CurrentLayer.ImageRenderer.Path.AsSpan(0, _selectionController.CurrentLayer.ImageRenderer.Path.LastIndexOf('\\') + 1), _newName, ".", _newExpansion);

                _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
                pictureBoxCanvas.BackgroundImage.Dispose();
                pictureBoxCanvas.BackgroundImage = null;

                File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
                _selectionController.CurrentLayer.ImageRenderer.Image.Save(_selectionController.CurrentLayer.ImageRenderer.Path);
                File.Move(_selectionController.CurrentLayer.ImageRenderer.Path, newPath);

                _selectionController.CurrentLayer.ImageRenderer.Path = newPath;
                pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            }
        }

        private void MoveFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", _selectionController.CurrentLayer.ImageRenderer.Path.Substring(_selectionController.CurrentLayer.ImageRenderer.Path.LastIndexOf('\\') + 1));

                _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
                pictureBoxCanvas.BackgroundImage.Dispose();
                pictureBoxCanvas.BackgroundImage = null;

                File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
                _selectionController.CurrentLayer.ImageRenderer.Image.Save(_selectionController.CurrentLayer.ImageRenderer.Path);
                File.Move(_selectionController.CurrentLayer.ImageRenderer.Path, newPath);

                _selectionController.CurrentLayer.ImageRenderer.Path = newPath;
                pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            }
        }


        private void CopyFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", _selectionController.CurrentLayer.ImageRenderer.Path.Substring(_selectionController.CurrentLayer.ImageRenderer.Path.LastIndexOf('\\') + 1));

                _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
                pictureBoxCanvas.BackgroundImage.Dispose();
                pictureBoxCanvas.BackgroundImage = null;

                File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
                _selectionController.CurrentLayer.ImageRenderer.Image.Save(_selectionController.CurrentLayer.ImageRenderer.Path);
                File.Copy(_selectionController.CurrentLayer.ImageRenderer.Path, newPath);

                pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
            }
        }

        private void DeleteFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            pictureBoxCanvas.BackgroundImage.Dispose();
            pictureBoxCanvas.BackgroundImage = null;
            File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
        }

        private void SaveMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            else if (_selectionController.CurrentLayer.ImageRenderer.Path == null)
            {
                SaveAsMainMenuItem_Click(sender, e);
                return;
            }

            _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
            pictureBoxCanvas.BackgroundImage.Dispose();
            pictureBoxCanvas.BackgroundImage = null;

            File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
            _selectionController.CurrentLayer.ImageRenderer.Image.Save(_selectionController.CurrentLayer.ImageRenderer.Path, _selectionController.CurrentLayer.ImageRenderer.Image.RawFormat);

            pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
        }

        private void SaveAsMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    _selectionController.CurrentLayer.ImageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
                    pictureBoxCanvas.BackgroundImage.Dispose();
                    pictureBoxCanvas.BackgroundImage = null;


                    if (_selectionController.CurrentLayer.ImageRenderer.Path != null)
                        File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
                    _selectionController.CurrentLayer.ImageRenderer.Image.Save(saveFileDialog.FileName, _selectionController.CurrentLayer.ImageRenderer.Image.RawFormat);

                    pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.Image;
                }
            }
        }

        private void ExitMainMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to get out?",
                "Message",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        #endregion
    }
}
