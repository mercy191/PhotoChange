using PhotoChange.Entities;

namespace PhotoChange
{
    public partial class MainForm : Form
    {
        ImageRenderer _imageRenderer;
        Draw _draw;

        static public string _newName;
        static public string _newExpansion;

        public MainForm()
        {
            InitializeComponent();
            _imageRenderer = new ImageRenderer();
            _draw = new Draw();

            _newName = "";
            _newExpansion = "";
        }

        #region -- MainForm Events --

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                        UndoMainMenuItem_Click(sender, e);
                        break;

                    case Keys.J:
                        RedoMainMenuItem_Click(sender, e);
                        break;
                }
            }
        }

        #endregion
    }
}
