using PhotoChange.Renderer;

namespace PhotoChange
{   
    public partial class MainForm
    {
        #region -- File Events --

        private void OpenMainMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _imageRenderer = new ImageRenderer(openFileDialog.FileName);
                pictureBoxCanvas.BackgroundImage = _imageRenderer.Image;
            }
        }

        private void RenameMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            RenameForm renameForm = new()
            { };

            if (renameForm.ShowDialog() == DialogResult.OK)
            {
                string newPath = string.Concat(_imageRenderer.Path.AsSpan(0, _imageRenderer.Path.LastIndexOf('\\') + 1), _newName, ".", _newExpansion);

                _imageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
                pictureBoxCanvas.BackgroundImage.Dispose();
                pictureBoxCanvas.BackgroundImage = null;

                File.Delete(_imageRenderer.Path);
                _imageRenderer.Image.Save(_imageRenderer.Path);
                File.Move(_imageRenderer.Path, newPath);

                _imageRenderer.Path = newPath;
                pictureBoxCanvas.BackgroundImage = _imageRenderer.Image;
            }
        }

        private void MoveFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", _imageRenderer.Path.Substring(_imageRenderer.Path.LastIndexOf('\\') + 1));

                _imageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
                pictureBoxCanvas.BackgroundImage.Dispose();
                pictureBoxCanvas.BackgroundImage = null;

                File.Delete(_imageRenderer.Path);
                _imageRenderer.Image.Save(_imageRenderer.Path);
                File.Move(_imageRenderer.Path, newPath);

                _imageRenderer.Path = newPath;
                pictureBoxCanvas.BackgroundImage = _imageRenderer.Image;
            }
        }


        private void CopyFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", _imageRenderer.Path.Substring(_imageRenderer.Path.LastIndexOf('\\') + 1));

                _imageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
                pictureBoxCanvas.BackgroundImage.Dispose();
                pictureBoxCanvas.BackgroundImage = null;

                File.Delete(_imageRenderer.Path);
                _imageRenderer.Image.Save(_imageRenderer.Path);
                File.Copy(_imageRenderer.Path, newPath);

                pictureBoxCanvas.BackgroundImage = _imageRenderer.Image;
            }
        }

        private void DeleteFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            pictureBoxCanvas.BackgroundImage.Dispose();
            pictureBoxCanvas.BackgroundImage = null;
            File.Delete(_imageRenderer.Path);
        }

        private void SaveMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            else if (_imageRenderer.Path == null)
            {
                SaveAsMainMenuItem_Click(sender, e);
                return;
            }

            _imageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
            pictureBoxCanvas.BackgroundImage.Dispose();
            pictureBoxCanvas.BackgroundImage = null;

            File.Delete(_imageRenderer.Path);
            _imageRenderer.Image.Save(_imageRenderer.Path, _imageRenderer.Image.RawFormat);

            pictureBoxCanvas.BackgroundImage = _imageRenderer.Image;
        }

        private void SaveAsMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage == null) return;

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    _imageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
                    pictureBoxCanvas.BackgroundImage.Dispose();
                    pictureBoxCanvas.BackgroundImage = null;


                    if (_imageRenderer.Path != null)
                        File.Delete(_imageRenderer.Path);
                    _imageRenderer.Image.Save(saveFileDialog.FileName, _imageRenderer.Image.RawFormat);

                    pictureBoxCanvas.BackgroundImage = _imageRenderer.Image;
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

        #region -- Edit Events --

        private void UndoMainMenuItem_Click(object sender, EventArgs e)
        {
            if (_imageRenderer.EditListIterator == -1 || pictureBoxCanvas.BackgroundImage == null) return;

            _imageRenderer.Image = new Bitmap(_imageRenderer.OriginalImage);

            if (_imageRenderer.EditListIterator != 0)
            {
                Graphics g = Graphics.FromImage(_imageRenderer.Image);
                g.DrawImage(_imageRenderer.EditList[--_imageRenderer.EditListIterator], 0, 0);
                g.Dispose();
            }
            else
            {
                --_imageRenderer.EditListIterator;               
            }

            if (_imageRenderer.EditListIterator == -1)
            {
                undoMainMenuItem.Enabled = false;
                redoMainMenuItem.Enabled = true;
            }
            else
            {
                undoMainMenuItem.Enabled = true;
                redoMainMenuItem.Enabled = true;
            }

            pictureBoxCanvas.BackgroundImage.Dispose();
            pictureBoxCanvas.BackgroundImage = _imageRenderer.Image;
        }

        private void RedoMainMenuItem_Click(object sender, EventArgs e)
        {
            if (_imageRenderer.EditListIterator == _imageRenderer.EditList.Count - 1 || pictureBoxCanvas.BackgroundImage == null) return;

            _imageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);

            Graphics g = Graphics.FromImage(_imageRenderer.Image);
            g.DrawImage(_imageRenderer.EditList[++_imageRenderer.EditListIterator], 0, 0);
            g.Dispose();
            
            if (_imageRenderer.EditListIterator == _imageRenderer.EditList.Count - 1) 
            {
                redoMainMenuItem.Enabled = false;
                undoMainMenuItem.Enabled = true;
            }
            else
            {
                redoMainMenuItem.Enabled = true;
                undoMainMenuItem.Enabled = true;
            }

            pictureBoxCanvas.BackgroundImage.Dispose();
            pictureBoxCanvas.BackgroundImage = _imageRenderer.Image;
        }

        private void CopyMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage != null) 
                Clipboard.SetImage(pictureBoxCanvas.BackgroundImage);
        }

        private void PasteMainMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxCanvas.BackgroundImage = Clipboard.GetImage();

            if (pictureBoxCanvas.BackgroundImage != null)
                _imageRenderer.Image = new Bitmap(pictureBoxCanvas.BackgroundImage);
        }

        private void DeleteImageMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.BackgroundImage != null)
            {
                _imageRenderer.EditList.Clear();
                _imageRenderer.EditListIterator = -1;
                _imageRenderer.Image.Dispose();
                _imageRenderer.OriginalImage.Dispose();
                pictureBoxCanvas.BackgroundImage.Dispose();
                redoMainMenuItem.Enabled = false;
                undoMainMenuItem.Enabled = false;
            }          
        }

        #endregion

        #region -- Image Events --

        #endregion
    }
}
