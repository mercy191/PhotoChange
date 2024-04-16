using PhotoChange.Renderer;
using PhotoChange.Controllers;
using PhotoChange.Common;

namespace PhotoChange
{
    public partial class MainForm : Form
    {
        List<Layer> _layers;

        SelectionController _selectionController;
        GraphicsController _graphicsController;

        static public string _newName;
        static public string _newExpansion;

        public MainForm()
        {
            InitializeComponent();
            _layers = new List<Layer>();

            _selectionController = new SelectionController();
            _graphicsController = new GraphicsController();

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
