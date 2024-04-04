using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PhotoChange
{
    public partial class MainForm : Form
    {
        public Image? Image { get; set; } = null;
        public string? Path { get; set; } = null;
        static public string? NewName { get; set; } = null;
        static public string? NewExpansion { get; set; } = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region -- File --

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            { };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Path = dialog.FileName;
                Image = Image.FromFile(dialog.FileName);
                pictureBox.Image = Image;
            }
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            RenameForm renameForm = new()
            { };
            renameForm.ShowDialog();

            if (NewName != null && NewExpansion != null)
            {
                string newPath = string.Concat(Path.AsSpan(0, Path.LastIndexOf('\\') + 1), NewName, ".", NewExpansion);

                Image = new Bitmap(pictureBox.Image);
                pictureBox.Image.Dispose();
                pictureBox.Image = null;

                File.Delete(Path);
                Image.Save(Path, Image.RawFormat);
                File.Move(Path, newPath);

                Path = newPath;
                NewName = null;
                NewExpansion = null;
                pictureBox.Image = Image;
            }
        }

        private void MoveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            FolderBrowserDialog dialog = new()
            { };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = dialog.SelectedPath + string.Concat("\\", Path.Substring(Path.LastIndexOf('\\') + 1));

                Image = new Bitmap(pictureBox.Image);
                pictureBox.Image.Dispose();
                pictureBox.Image = null;

                File.Delete(Path);
                Image.Save(Path, Image.RawFormat);
                File.Move(Path, newPath);

                Path = newPath;
                pictureBox.Image = Image;
            }
        }


        private void CopyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            FolderBrowserDialog dialog = new()
            { };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = dialog.SelectedPath + string.Concat("\\", Path.Substring(Path.LastIndexOf('\\') + 1));

                Image = new Bitmap(pictureBox.Image);
                pictureBox.Image.Dispose();
                pictureBox.Image = null;

                File.Delete(Path);
                Image.Save(Path, Image.RawFormat);
                File.Copy(Path, newPath);

                pictureBox.Image = Image;
            }
        }

        private void DeleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            pictureBox.Image.Dispose();
            pictureBox.Image = null;
            File.Delete(Path);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            Image = new Bitmap(pictureBox.Image);
            pictureBox.Image.Dispose();
            pictureBox.Image = null;

            File.Delete(Path);
            Image.Save(Path, Image.RawFormat);

            pictureBox.Image = Image;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == null || Image == null) return;

            SaveFileDialog dialog = new SaveFileDialog()
            { };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (dialog.FileName != "")
                {
                    Image = new Bitmap(pictureBox.Image);
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;

                    File.Delete(Path);
                    Image.Save(dialog.FileName, Image.RawFormat);

                    pictureBox.Image = Image;
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


    }
}
