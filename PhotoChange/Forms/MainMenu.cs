

namespace PhotoChange
{   
    public partial class MainForm
    {
        #region -- Main Menu Items --
        public Image? Image { get; set; } = null;
        public List<Image>? ImageEditList { get; set; } = null;
        public int ImageEditListIterator { get; set; } = 0;
        public string? Path { get; set; } = null;
        static public string? NewName { get; set; } = null;
        static public string? NewExpansion { get; set; } = null;

        #endregion

        #region -- File Events --

        private void OpenMainMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog.FileName;
                Image = new Bitmap(openFileDialog.FileName);
                ImageEditList = new List<Image>();
                ImageEditList.Add(new Bitmap(Image));
                pictureBox.Image = Image;
            }
        }

        private void RenameMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            RenameForm renameForm = new()
            { };

            if (renameForm.ShowDialog() == DialogResult.OK)
            {
                if (NewName != null && NewExpansion != null)
                {
                    string newPath = string.Concat(Path.AsSpan(0, Path.LastIndexOf('\\') + 1), NewName, ".", NewExpansion);

                    Image = new Bitmap(pictureBox.Image);
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;

                    File.Delete(Path);
                    Image.Save(Path);
                    File.Move(Path, newPath);

                    Path = newPath;
                    NewName = null;
                    NewExpansion = null;
                    pictureBox.Image = Image;
                }
            }
        }

        private void MoveFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", Path.Substring(Path.LastIndexOf('\\') + 1));

                Image = new Bitmap(pictureBox.Image);
                pictureBox.Image.Dispose();
                pictureBox.Image = null;

                File.Delete(Path);
                Image.Save(Path);
                File.Move(Path, newPath);

                Path = newPath;
                pictureBox.Image = Image;
            }
        }


        private void CopyFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = folderBrowserDialog.SelectedPath + string.Concat("\\", Path.Substring(Path.LastIndexOf('\\') + 1));

                Image = new Bitmap(pictureBox.Image);
                pictureBox.Image.Dispose();
                pictureBox.Image = null;

                File.Delete(Path);
                Image.Save(Path);
                File.Copy(Path, newPath);

                pictureBox.Image = Image;
            }
        }

        private void DeleteFileMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            pictureBox.Image.Dispose();
            pictureBox.Image = null;
            File.Delete(Path);

            Image = null;
            Path = null;
            ImageEditList = null;
        }

        private void SaveMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Image == null) return;

            else if (Path == null)
            {
                SaveAsMainMenuItem_Click(sender, e);
                return;
            }

            Image = new Bitmap(pictureBox.Image);
            pictureBox.Image.Dispose();
            pictureBox.Image = null;

            File.Delete(Path);
            Image.Save(Path, Image.RawFormat);

            pictureBox.Image = Image;
        }

        private void SaveAsMainMenuItem_Click(object sender, EventArgs e)
        {
            if (Image == null) return;

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    Image = new Bitmap(pictureBox.Image);
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;


                    if (Path != null)
                        File.Delete(Path);
                    Image.Save(saveFileDialog.FileName, Image.RawFormat);

                    pictureBox.Image = Image;
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
            if (ImageEditList == null || ImageEditListIterator == 0) return;

            Image = new Bitmap(ImageEditList[--ImageEditListIterator]);
            pictureBox.Image.Dispose();
            pictureBox.Image = Image;
        }

        private void ReturnMainMenuItem_Click(object sender, EventArgs e)
        {
            if (ImageEditList == null || ImageEditListIterator == ImageEditList.Count - 1) return;

            Image = new Bitmap(ImageEditList[++ImageEditListIterator]);
            pictureBox.Image.Dispose();
            pictureBox.Image = Image;
        }

        private void CopyMainMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox.Image);
        }

        private void PasteMainMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Clipboard.GetImage();

            if (pictureBox.Image != null)
                Image = new Bitmap(pictureBox.Image);
        }

        private void DeleteImageMainMenuItem_Click(object sender, EventArgs e)
        {
            Image = null;
            pictureBox.Image.Dispose();
            pictureBox.Image = null;
        }

        #endregion

        #region -- Image Events --

        #endregion
    }
}
