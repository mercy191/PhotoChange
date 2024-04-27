namespace PhotoChange
{
    public partial class MainForm
    {
        #region -- Layers Panel Events --

        private void LayersListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = layersListBox.IndexFromPoint(e.Location);
            if (index > -1 && index < _layers.Count)
            {
                _selectionController.CurrentLayer = _layers[index];
                _selectionController.IsImageCreated = true;
                UpdateInterface();
            }
        }

        private void LayersListBox_MouseDown(object sender, MouseEventArgs e)
        {
            int index = layersListBox.IndexFromPoint(e.Location);

            if (e.Button == MouseButtons.Left)
            {
                if (index > -1 && index < _layers.Count)
                {
                    _selectionController.CurrentLayer = _layers[index];
                    _selectionController.IsImageCreated = true;
                    layerPictureBox.Image = _selectionController.CurrentLayer.ImageRenderer.OriginalImage;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (index > -1 && index < _layers.Count)
                {
                    _selectionController.CurrentLayer = _layers[index];
                    _selectionController.CurrentLayer.ImageRenderer.Dispose();
                    _selectionController.IsImageCreated = false;
                    _layers.RemoveAt(index);
                    layersListBox.Items.RemoveAt(index);
                    layerPictureBox.Image = null;

                    UpdateInterface();
                }
            }
        }

        #endregion
    }
}
