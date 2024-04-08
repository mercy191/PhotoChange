

namespace PhotoChange
{   
    public partial class MainForm
    {
        #region -- Main Menu Items --
        public Bitmap? Image { get; set; } = null;
        public Bitmap? OriginalImage { get; set; } = null;
        public List<Bitmap>? LayersList { get; set; } = null;
        public int LayersListIterator { get; set; } = -1;
        public string? Path { get; set; } = null;
        static public string? NewName { get; set; } = null;
        static public string? NewExpansion { get; set; } = null;

        #endregion


        #region -- MainForm Events --

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                        CancelMainMenuItem_Click(sender, e);
                        break;

                    case Keys.J:
                        ReturnMainMenuItem_Click(sender, e);
                        break;
                }
            }               
        }

        #endregion

        #region -- File Events --

        private void OpenMainMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog.FileName;
                Image = new Bitmap(openFileDialog.FileName);
                OriginalImage = new Bitmap(Image);
                LayersList = new List<Bitmap>();
                pictureBox.BackgroundImage = Image;
            }
        }

        private void RenameMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || pictureBox.BackgroundImage == null) return;

            RenameForm renameForm = new()
            { };

            if (renameForm.ShowDialog() == DialogResult.OK)
            {
                if (NewName != null && NewExpansion != null)
                {
                    string newPath = string.Concat(Path.AsSpan(0, Path.LastIndexOf('\\') + 1), NewName, ".", NewExpansion);

                    Image = new Bitmap(pictureBox.BackgroundImage);
                    pictureBox.BackgroundImage.Dispose();
                    pictureBox.BackgroundImage = null;

                    File.Delete(Path);
                    Image.Save(Path);
                    File.Move(Path, newPath);

                    Path = newPath;
                    NewName = null;
                    NewExpansion = null;
                    pictureBox.BackgroundImage = Image;
                }
            }
        }

        private void MoveFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || pictureBox.BackgroundImage == null) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", Path.Substring(Path.LastIndexOf('\\') + 1));

                Image = new Bitmap(pictureBox.BackgroundImage);
                pictureBox.BackgroundImage.Dispose();
                pictureBox.BackgroundImage = null;

                File.Delete(Path);
                Image.Save(Path);
                File.Move(Path, newPath);

                Path = newPath;
                pictureBox.BackgroundImage = Image;
            }
        }


        private void CopyFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || pictureBox.BackgroundImage == null) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", Path.Substring(Path.LastIndexOf('\\') + 1));

                Image = new Bitmap(pictureBox.BackgroundImage);
                pictureBox.BackgroundImage.Dispose();
                pictureBox.BackgroundImage = null;

                File.Delete(Path);
                Image.Save(Path);
                File.Copy(Path, newPath);

                pictureBox.BackgroundImage = Image;
            }
        }

        private void DeleteFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || pictureBox.BackgroundImage == null) return;

            pictureBox.BackgroundImage.Dispose();
            pictureBox.BackgroundImage = null;
            File.Delete(Path);

            Image = null;
            Path = null;
            LayersList = null;
        }

        private void SaveMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.BackgroundImage == null) return;

            else if (Path == null)
            {
                SaveAsMainMenuItem_Click(sender, e);
                return;
            }

            Image = new Bitmap(pictureBox.BackgroundImage);
            pictureBox.BackgroundImage.Dispose();
            pictureBox.BackgroundImage = null;

            File.Delete(Path);
            Image.Save(Path, Image.RawFormat);

            pictureBox.BackgroundImage = Image;
        }

        private void SaveAsMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.BackgroundImage == null) return;

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    Image = new Bitmap(pictureBox.BackgroundImage);
                    pictureBox.BackgroundImage.Dispose();
                    pictureBox.BackgroundImage = null;


                    if (Path != null)
                        File.Delete(Path);
                    Image.Save(saveFileDialog.FileName, Image.RawFormat);

                    pictureBox.BackgroundImage = Image;
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

        private void CancelMainMenuItem_Click(object sender, EventArgs e)
        {
            if (LayersList == null || LayersListIterator == -1 || pictureBox.BackgroundImage == null || OriginalImage == null) return;

            Image = new Bitmap(OriginalImage);

            if (LayersListIterator != 0)
            {
                Graphics g = Graphics.FromImage(Image);
                g.DrawImage(LayersList[--LayersListIterator], 0, 0);
                g.Dispose();
            }
            else
            {
                --LayersListIterator;
            }
          
            pictureBox.BackgroundImage.Dispose();
            pictureBox.BackgroundImage = Image;
        }

        private void ReturnMainMenuItem_Click(object sender, EventArgs e)
        {
            if (LayersList == null || LayersListIterator == LayersList.Count - 1 || pictureBox.BackgroundImage == null) return;

            Image = new Bitmap(pictureBox.BackgroundImage);

            Graphics g = Graphics.FromImage(Image);
            g.DrawImage(LayersList[++LayersListIterator], 0, 0);
            g.Dispose();         

            pictureBox.BackgroundImage.Dispose();
            pictureBox.BackgroundImage = Image;
        }

        private void CopyMainMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.BackgroundImage != null) 
                Clipboard.SetImage(pictureBox.BackgroundImage);
        }

        private void PasteMainMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = Clipboard.GetImage();

            if (pictureBox.BackgroundImage != null)
                Image = new Bitmap(pictureBox.BackgroundImage);
        }

        private void DeleteImageMainMenuItem_Click(object sender, EventArgs e)
        {
            Image = null;
            if (pictureBox.BackgroundImage != null)
            {
                LayersList?.Clear();
                Image?.Dispose();
                OriginalImage?.Dispose();
                pictureBox.BackgroundImage.Dispose();
            }
           
        }

        #endregion

        #region -- Image Events --

        #endregion
    }
}
