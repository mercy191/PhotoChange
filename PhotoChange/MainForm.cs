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

        static public string? _newName;
        static public string? _newExpansion;

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
                        UndoRedoMainMenuItem_Click(sender, e);
                        break;

                    case Keys.J:
                        UndoRedoMainMenuItem_Click(sender, e);
                        break;
                }
            }
        }

        private void UpdateInterface()
        {
            if (_selectionController.CurrentLayer.ImageRenderer.EditList.Count == 1)
            {
                undoMainMenuItem.Enabled = false;
                redoMainMenuItem.Enabled = false;
            }
            else if (_selectionController.CurrentLayer.ImageRenderer.EditListIterator == 0)
            {
                undoMainMenuItem.Enabled = false;
                redoMainMenuItem.Enabled = true;
            }
            else if (_selectionController.CurrentLayer.ImageRenderer.EditListIterator == _selectionController.CurrentLayer.ImageRenderer.EditList.Count - 1)
            {
                undoMainMenuItem.Enabled = true;
                redoMainMenuItem.Enabled = false;
            }
            else
            {
                undoMainMenuItem.Enabled = true;
                redoMainMenuItem.Enabled = true;
            }

            if (_selectionController.IsImageCreated)
            {
                _selectionController.CurrentLayer.ImageRenderer.EditScale();
                editScaleMainToolsPanelTextBox.Text = _selectionController.CurrentLayer.ImageRenderer.ScalePercent.ToString();
                splitContainer2.Panel2.Controls.Clear();
                pictureBoxCanvas.BackgroundImage = _selectionController.CurrentLayer.ImageRenderer.ScaleImage;
            }
            else
            {
                splitContainer2.Panel2.Controls.Clear();
                pictureBoxCanvas.BackgroundImage = null;
            }
        }

        private void UpdateDrawingControls()
        {
            switch (_selectionController.CurrentLayer.ImageDrawing.Mode)
            {
                case ImageDrawing.DrawingMode.None:
                    Cursor.Current = Cursors.Default;
                    _selectionController.IsDrawing = false;
                    mainToolsPanelColorButton.Enabled = false;
                    mainToolsPanelSizeSplitButton.Enabled = false;
                    mainToolsPanelSizeSplitButton.Text = "0";
                    break;

                case ImageDrawing.DrawingMode.Drawing:
                    Cursor.Current = Cursors.Cross;
                    _selectionController.IsDrawing = true;
                    mainToolsPanelColorButton.Enabled = true;
                    mainToolsPanelSizeSplitButton.Enabled = true;
                    break;

                case ImageDrawing.DrawingMode.Filling:
                    Cursor.Current = Cursors.Hand;
                    _selectionController.IsDrawing = false;
                    mainToolsPanelColorButton.Enabled = true;
                    mainToolsPanelSizeSplitButton.Enabled = true;
                    mainToolsPanelSizeSplitButton.Text = "0";
                    break;
            }
        }

        #endregion


    }
}
