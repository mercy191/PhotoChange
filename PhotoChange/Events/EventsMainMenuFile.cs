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
                _layers.Add(new Layer
                    (
                    imageRenderer,
                    new ImageDrawing(),
                    new ImageInfo(imageRenderer)
                    ));
                _selectionController.IsImageCreated = true;
                _selectionController.CurrentLayer = _layers.Last();
                _selectionController.CurrentLayerNumber = _layers.LastIndexOf(_selectionController.CurrentLayer);
                _selectionController.CurrentLayer.ImageRenderer.CalculateScaleFactor(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                _selectionController.CurrentLayer.ImageRenderer.CalculateRetreat(pictureBoxCanvas.Width, pictureBoxCanvas.Height);

                layersListBox.Items.Add(_layers.Last().LayerName);
                UpdateInterface();             
            }
        }

        private void RenameMainMenuItem_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            RenameForm renameForm = new()
            { };

            if (renameForm.ShowDialog() == DialogResult.OK)
            {
                string newPath = string.Concat(_selectionController.CurrentLayer.ImageRenderer.Path.AsSpan(0, _selectionController.CurrentLayer.ImageRenderer.Path.LastIndexOf('\\') + 1), _newName, ".", _newExpansion);

                Bitmap tempBitmap = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.OriginalImage);
                _selectionController.CurrentLayer.ImageRenderer.OriginalImage.Dispose();

                File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
                tempBitmap.Save(_selectionController.CurrentLayer.ImageRenderer.Path, tempBitmap.RawFormat);
                _selectionController.CurrentLayer.ImageRenderer.OriginalImage = tempBitmap;
                File.Move(_selectionController.CurrentLayer.ImageRenderer.Path, newPath);

                _selectionController.CurrentLayer.ImageRenderer.Path = newPath;
            }
        }

        private void MoveFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", _selectionController.CurrentLayer.ImageRenderer.Path.Substring(_selectionController.CurrentLayer.ImageRenderer.Path.LastIndexOf('\\') + 1));

                Bitmap tempBitmap = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.OriginalImage);
                _selectionController.CurrentLayer.ImageRenderer.OriginalImage.Dispose();

                File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
                tempBitmap.Save(_selectionController.CurrentLayer.ImageRenderer.Path, tempBitmap.RawFormat);
                _selectionController.CurrentLayer.ImageRenderer.OriginalImage = tempBitmap;
                File.Move(_selectionController.CurrentLayer.ImageRenderer.Path, newPath);

                _selectionController.CurrentLayer.ImageRenderer.Path = newPath;
            }
        }


        private void CopyFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", _selectionController.CurrentLayer.ImageRenderer.Path.Substring(_selectionController.CurrentLayer.ImageRenderer.Path.LastIndexOf('\\') + 1));

                Bitmap tempBitmap = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.OriginalImage);
                _selectionController.CurrentLayer.ImageRenderer.OriginalImage.Dispose();

                File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
                tempBitmap.Save(_selectionController.CurrentLayer.ImageRenderer.Path, tempBitmap.RawFormat);
                _selectionController.CurrentLayer.ImageRenderer.OriginalImage = tempBitmap;
                File.Copy(_selectionController.CurrentLayer.ImageRenderer.Path, newPath);
            }
        }

        private void DeleteFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            layersListBox.Items.Remove(_selectionController.CurrentLayer.ImageInfo.FileName);
            _layers.Remove(_selectionController.CurrentLayer);
            _selectionController.IsImageCreated = false;
            _selectionController.CurrentLayer.ImageRenderer.Dispose();
            File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);

            UpdateInterface();
        }

        private void SaveMainMenuItem_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            else if (_selectionController.CurrentLayer.ImageRenderer.Path == string.Empty)
            {
                SaveAsMainMenuItem_Click(sender, e);
                return;
            }

            Bitmap tempBitmap = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.OriginalImage);
            _selectionController.CurrentLayer.ImageRenderer.OriginalImage.Dispose();

            File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
            tempBitmap.Save(_selectionController.CurrentLayer.ImageRenderer.Path, tempBitmap.RawFormat);
            _selectionController.CurrentLayer.ImageRenderer.OriginalImage = tempBitmap;
        }

        private void SaveAsMainMenuItem_Click(object sender, EventArgs e)
        {
            if (!_selectionController.IsImageCreated) return;

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    Bitmap tempBitmap = new Bitmap(_selectionController.CurrentLayer.ImageRenderer.OriginalImage);
                    _selectionController.CurrentLayer.ImageRenderer.OriginalImage.Dispose();

                    if (_selectionController.CurrentLayer.ImageRenderer.Path != string.Empty)
                        File.Delete(_selectionController.CurrentLayer.ImageRenderer.Path);
                    tempBitmap.Save(saveFileDialog.FileName, tempBitmap.RawFormat);
                    _selectionController.CurrentLayer.ImageRenderer.OriginalImage = tempBitmap;
                    _selectionController.CurrentLayer.ImageRenderer.Path = new string(saveFileDialog.FileName);
                    _selectionController.CurrentLayer.ImageInfo = new ImageInfo(_selectionController.CurrentLayer.ImageRenderer);
                }
            }
        }

        private void ExitMainMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to get out?\n" +
                "Unprotected data will be lost.",
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
