using PhotoChange.Renderer;
using PhotoChange.Controllers;

namespace PhotoChange
{
    public partial class MainForm : Form
    {
        ImageRenderer _imageRenderer;
        ImageDrawing _imageDrawing;

        SelectionController _selectionController;

        static public string _newName;
        static public string _newExpansion;

        public MainForm()
        {
            InitializeComponent();
            _imageRenderer = new ImageRenderer();
            _imageDrawing = new ImageDrawing();
            _selectionController = new SelectionController();

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
