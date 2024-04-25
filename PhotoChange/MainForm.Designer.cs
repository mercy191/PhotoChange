
namespace PhotoChange
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            contextMenuIcon = new ContextMenuStrip(components);
            mainToolsPanel = new ToolStrip();
            mainToolsPanelHomeButton = new ToolStripButton();
            mainToolsPanelSeparator1 = new ToolStripSeparator();
            mainToolsPanelSizeSplitButton = new ToolStripSplitButton();
            size3MainToolsPanelItem = new ToolStripMenuItem();
            size4MainToolsPanelItem = new ToolStripMenuItem();
            size5MainToolsPanelItem = new ToolStripMenuItem();
            size20MainToolsPanelItem = new ToolStripMenuItem();
            mainToolsPanelSeparator2 = new ToolStripSeparator();
            mainToolsPanelColorButton = new ToolStripButton();
            mainToolsPanelSeparator3 = new ToolStripSeparator();
            mainToolsPanelSizeModeLabel = new ToolStripLabel();
            mainToolsPanelSeparator4 = new ToolStripSeparator();
            mainToolsPanelEditScaleLabel = new ToolStripLabel();
            editScaleMainToolsPanelTextBox = new ToolStripTextBox();
            mainToolsPanelSeparator5 = new ToolStripSeparator();
            mainToolsPanelCombineLayersButton = new ToolStripButton();
            drawingToolsPanel = new ToolStrip();
            drawingToolsPanelCursorButton = new ToolStripButton();
            drawingToolsPanelBrushButton = new ToolStripButton();
            drawingToolsPanelEraserButton = new ToolStripButton();
            drawingToolsPanelPipetteButton = new ToolStripButton();
            drawingToolsPanelFillingButton = new ToolStripButton();
            drawingToolsPanelLineButton = new ToolStripButton();
            drawingToolsPanelEllipseButton = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            pictureBoxCanvas = new PictureBox();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            layersLayoutPanel = new TableLayoutPanel();
            layersTextBox = new TextBox();
            layersListBox = new ListBox();
            layerPictureBox = new PictureBox();
            cursorPosition = new Label();
            mainMenu = new MenuStrip();
            fileMainMenuItem = new ToolStripMenuItem();
            openMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator1 = new ToolStripSeparator();
            renameMainMenuItem = new ToolStripMenuItem();
            moveFileMainMenuItem = new ToolStripMenuItem();
            copyFileMainMenuItem = new ToolStripMenuItem();
            deleteFileMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator2 = new ToolStripSeparator();
            saveMainMenuItem = new ToolStripMenuItem();
            saveAsMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator3 = new ToolStripSeparator();
            exitMainMenuItem = new ToolStripMenuItem();
            editMainMenuItem = new ToolStripMenuItem();
            undoMainMenuItem = new ToolStripMenuItem();
            redoMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator4 = new ToolStripSeparator();
            copyMainMenuItem = new ToolStripMenuItem();
            pasteMainMenuItem = new ToolStripMenuItem();
            imageMainMenuItem = new ToolStripMenuItem();
            imagePropertiesMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator5 = new ToolStripSeparator();
            rotateLeftMainMenuItem = new ToolStripMenuItem();
            rotateRightMainMenuItem = new ToolStripMenuItem();
            rotateMainMenuItem = new ToolStripMenuItem();
            flipVerticallyMainMenuItem = new ToolStripMenuItem();
            flipHorizontallyMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator6 = new ToolStripSeparator();
            inShadesOfGreyMainMenuItem = new ToolStripMenuItem();
            showChannelMainMenuItem = new ToolStripMenuItem();
            redChannelMainMenuItem = new ToolStripMenuItem();
            greenChannelMainMenuItem = new ToolStripMenuItem();
            blueChannelMainMenuItem = new ToolStripMenuItem();
            invertNegativeMainMenuItem = new ToolStripMenuItem();
            allChannelMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator8 = new ToolStripSeparator();
            redMainMenuItem = new ToolStripMenuItem();
            greenMainMenuItem = new ToolStripMenuItem();
            blueMainMenuItem = new ToolStripMenuItem();
            colorCorrectionMainMenuItem = new ToolStripMenuItem();
            histogramMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator7 = new ToolStripSeparator();
            switchColorChannelMainMenuItem = new ToolStripMenuItem();
            RGBtoRBGMainMenuItem = new ToolStripMenuItem();
            RGBtoBGRMainMenuItem = new ToolStripMenuItem();
            RGBtoBRGMainMenuItem = new ToolStripMenuItem();
            RGBtoGRBMainMenuItem = new ToolStripMenuItem();
            RGBtoGBRMainMenuItem = new ToolStripMenuItem();
            helpMainMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();
            colorDialog = new ColorDialog();
            mainFormStyle = new MainFormStyle(components);
            mainToolsPanel.SuspendLayout();
            drawingToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            layersLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layerPictureBox).BeginInit();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuIcon
            // 
            contextMenuIcon.ImageScalingSize = new Size(20, 20);
            contextMenuIcon.Name = "contextMenuStrip1";
            contextMenuIcon.Size = new Size(61, 4);
            // 
            // mainToolsPanel
            // 
            mainToolsPanel.BackColor = SystemColors.Control;
            mainToolsPanel.ImageScalingSize = new Size(30, 25);
            mainToolsPanel.Items.AddRange(new ToolStripItem[] { mainToolsPanelHomeButton, mainToolsPanelSeparator1, mainToolsPanelSizeSplitButton, mainToolsPanelSeparator2, mainToolsPanelColorButton, mainToolsPanelSeparator3, mainToolsPanelSizeModeLabel, mainToolsPanelSeparator4, mainToolsPanelEditScaleLabel, editScaleMainToolsPanelTextBox, mainToolsPanelSeparator5, mainToolsPanelCombineLayersButton });
            mainToolsPanel.Location = new Point(0, 24);
            mainToolsPanel.Name = "mainToolsPanel";
            mainToolsPanel.Size = new Size(1145, 31);
            mainToolsPanel.TabIndex = 0;
            mainToolsPanel.Text = "toolStrip1";
            // 
            // mainToolsPanelHomeButton
            // 
            mainToolsPanelHomeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            mainToolsPanelHomeButton.Image = (Image)resources.GetObject("mainToolsPanelHomeButton.Image");
            mainToolsPanelHomeButton.ImageScaling = ToolStripItemImageScaling.None;
            mainToolsPanelHomeButton.ImageTransparentColor = Color.Magenta;
            mainToolsPanelHomeButton.Name = "mainToolsPanelHomeButton";
            mainToolsPanelHomeButton.Size = new Size(28, 28);
            mainToolsPanelHomeButton.Text = "toolStripButton1";
            mainToolsPanelHomeButton.ToolTipText = "Home Button";
            mainToolsPanelHomeButton.Click += MainToolsPanelHomeButton_Click;
            // 
            // mainToolsPanelSeparator1
            // 
            mainToolsPanelSeparator1.Name = "mainToolsPanelSeparator1";
            mainToolsPanelSeparator1.Size = new Size(6, 31);
            // 
            // mainToolsPanelSizeSplitButton
            // 
            mainToolsPanelSizeSplitButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mainToolsPanelSizeSplitButton.DropDownItems.AddRange(new ToolStripItem[] { size3MainToolsPanelItem, size4MainToolsPanelItem, size5MainToolsPanelItem, size20MainToolsPanelItem });
            mainToolsPanelSizeSplitButton.Enabled = false;
            mainToolsPanelSizeSplitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mainToolsPanelSizeSplitButton.ImageTransparentColor = Color.Magenta;
            mainToolsPanelSizeSplitButton.Name = "mainToolsPanelSizeSplitButton";
            mainToolsPanelSizeSplitButton.Size = new Size(31, 28);
            mainToolsPanelSizeSplitButton.Text = "0";
            mainToolsPanelSizeSplitButton.TextImageRelation = TextImageRelation.TextAboveImage;
            mainToolsPanelSizeSplitButton.ToolTipText = "Size";
            // 
            // size3MainToolsPanelItem
            // 
            size3MainToolsPanelItem.Name = "size3MainToolsPanelItem";
            size3MainToolsPanelItem.Size = new Size(90, 22);
            size3MainToolsPanelItem.Text = "3";
            size3MainToolsPanelItem.Click += SizeMainToolsPanelItem_Click;
            // 
            // size4MainToolsPanelItem
            // 
            size4MainToolsPanelItem.Name = "size4MainToolsPanelItem";
            size4MainToolsPanelItem.Size = new Size(90, 22);
            size4MainToolsPanelItem.Text = "4";
            size4MainToolsPanelItem.Click += SizeMainToolsPanelItem_Click;
            // 
            // size5MainToolsPanelItem
            // 
            size5MainToolsPanelItem.Name = "size5MainToolsPanelItem";
            size5MainToolsPanelItem.Size = new Size(90, 22);
            size5MainToolsPanelItem.Text = "5";
            size5MainToolsPanelItem.Click += SizeMainToolsPanelItem_Click;
            // 
            // size20MainToolsPanelItem
            // 
            size20MainToolsPanelItem.Name = "size20MainToolsPanelItem";
            size20MainToolsPanelItem.Size = new Size(90, 22);
            size20MainToolsPanelItem.Text = "20";
            size20MainToolsPanelItem.Click += SizeMainToolsPanelItem_Click;
            // 
            // mainToolsPanelSeparator2
            // 
            mainToolsPanelSeparator2.Name = "mainToolsPanelSeparator2";
            mainToolsPanelSeparator2.Size = new Size(6, 31);
            // 
            // mainToolsPanelColorButton
            // 
            mainToolsPanelColorButton.BackColor = SystemColors.ControlText;
            mainToolsPanelColorButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            mainToolsPanelColorButton.Enabled = false;
            mainToolsPanelColorButton.ImageScaling = ToolStripItemImageScaling.None;
            mainToolsPanelColorButton.ImageTransparentColor = Color.Magenta;
            mainToolsPanelColorButton.Name = "mainToolsPanelColorButton";
            mainToolsPanelColorButton.Size = new Size(23, 28);
            mainToolsPanelColorButton.Text = "Color";
            mainToolsPanelColorButton.Click += MainToolsPanelColorButton_Click;
            // 
            // mainToolsPanelSeparator3
            // 
            mainToolsPanelSeparator3.Name = "mainToolsPanelSeparator3";
            mainToolsPanelSeparator3.Size = new Size(6, 31);
            // 
            // mainToolsPanelSizeModeLabel
            // 
            mainToolsPanelSizeModeLabel.Name = "mainToolsPanelSizeModeLabel";
            mainToolsPanelSizeModeLabel.Size = new Size(76, 28);
            mainToolsPanelSizeModeLabel.Text = "Mode: Zoom";
            // 
            // mainToolsPanelSeparator4
            // 
            mainToolsPanelSeparator4.Name = "mainToolsPanelSeparator4";
            mainToolsPanelSeparator4.Size = new Size(6, 31);
            // 
            // mainToolsPanelEditScaleLabel
            // 
            mainToolsPanelEditScaleLabel.Name = "mainToolsPanelEditScaleLabel";
            mainToolsPanelEditScaleLabel.Size = new Size(37, 28);
            mainToolsPanelEditScaleLabel.Text = "Scale:";
            // 
            // editScaleMainToolsPanelTextBox
            // 
            editScaleMainToolsPanelTextBox.AutoSize = false;
            editScaleMainToolsPanelTextBox.Name = "editScaleMainToolsPanelTextBox";
            editScaleMainToolsPanelTextBox.Size = new Size(100, 25);
            editScaleMainToolsPanelTextBox.Text = "100";
            editScaleMainToolsPanelTextBox.KeyUp += EditScaleMainToolsPanelTextBox_KeyUp;
            // 
            // mainToolsPanelSeparator5
            // 
            mainToolsPanelSeparator5.Name = "mainToolsPanelSeparator5";
            mainToolsPanelSeparator5.Size = new Size(6, 31);
            // 
            // mainToolsPanelCombineLayersButton
            // 
            mainToolsPanelCombineLayersButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            mainToolsPanelCombineLayersButton.Image = (Image)resources.GetObject("mainToolsPanelCombineLayersButton.Image");
            mainToolsPanelCombineLayersButton.ImageScaling = ToolStripItemImageScaling.None;
            mainToolsPanelCombineLayersButton.ImageTransparentColor = Color.Magenta;
            mainToolsPanelCombineLayersButton.Name = "mainToolsPanelCombineLayersButton";
            mainToolsPanelCombineLayersButton.Size = new Size(28, 28);
            mainToolsPanelCombineLayersButton.Text = "Combine layers";
            mainToolsPanelCombineLayersButton.Click += CombineLayersMainToolsPanelButton_Click;
            // 
            // drawingToolsPanel
            // 
            drawingToolsPanel.BackColor = SystemColors.Control;
            drawingToolsPanel.Dock = DockStyle.Left;
            drawingToolsPanel.ImageScalingSize = new Size(20, 20);
            drawingToolsPanel.Items.AddRange(new ToolStripItem[] { drawingToolsPanelCursorButton, drawingToolsPanelBrushButton, drawingToolsPanelEraserButton, drawingToolsPanelPipetteButton, drawingToolsPanelFillingButton, drawingToolsPanelLineButton, drawingToolsPanelEllipseButton });
            drawingToolsPanel.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            drawingToolsPanel.Location = new Point(0, 55);
            drawingToolsPanel.Name = "drawingToolsPanel";
            drawingToolsPanel.Size = new Size(25, 575);
            drawingToolsPanel.TabIndex = 1;
            drawingToolsPanel.Text = "toolStrip2";
            // 
            // drawingToolsPanelCursorButton
            // 
            drawingToolsPanelCursorButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            drawingToolsPanelCursorButton.Image = (Image)resources.GetObject("drawingToolsPanelCursorButton.Image");
            drawingToolsPanelCursorButton.ImageTransparentColor = Color.Magenta;
            drawingToolsPanelCursorButton.Name = "drawingToolsPanelCursorButton";
            drawingToolsPanelCursorButton.Size = new Size(22, 24);
            drawingToolsPanelCursorButton.Text = "Cursor";
            drawingToolsPanelCursorButton.Click += DrawingToolsPanelCursorButton_Click;
            // 
            // drawingToolsPanelBrushButton
            // 
            drawingToolsPanelBrushButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            drawingToolsPanelBrushButton.Image = (Image)resources.GetObject("drawingToolsPanelBrushButton.Image");
            drawingToolsPanelBrushButton.ImageTransparentColor = Color.Magenta;
            drawingToolsPanelBrushButton.Name = "drawingToolsPanelBrushButton";
            drawingToolsPanelBrushButton.Size = new Size(22, 24);
            drawingToolsPanelBrushButton.Text = "Brush";
            drawingToolsPanelBrushButton.Click += DrawingToolsPanelBrushButton_Click;
            // 
            // drawingToolsPanelEraserButton
            // 
            drawingToolsPanelEraserButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            drawingToolsPanelEraserButton.Image = (Image)resources.GetObject("drawingToolsPanelEraserButton.Image");
            drawingToolsPanelEraserButton.ImageTransparentColor = Color.Magenta;
            drawingToolsPanelEraserButton.Name = "drawingToolsPanelEraserButton";
            drawingToolsPanelEraserButton.Size = new Size(22, 24);
            drawingToolsPanelEraserButton.Text = "Eraser";
            drawingToolsPanelEraserButton.Click += DrawingToolsPanelEraserButton_Click;
            // 
            // drawingToolsPanelPipetteButton
            // 
            drawingToolsPanelPipetteButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            drawingToolsPanelPipetteButton.Image = (Image)resources.GetObject("drawingToolsPanelPipetteButton.Image");
            drawingToolsPanelPipetteButton.ImageTransparentColor = Color.Magenta;
            drawingToolsPanelPipetteButton.Name = "drawingToolsPanelPipetteButton";
            drawingToolsPanelPipetteButton.Size = new Size(22, 24);
            drawingToolsPanelPipetteButton.Text = "Pipette";
            drawingToolsPanelPipetteButton.Click += DrawingToolsPanelPipetteButton_Click;
            // 
            // drawingToolsPanelFillingButton
            // 
            drawingToolsPanelFillingButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            drawingToolsPanelFillingButton.Image = (Image)resources.GetObject("drawingToolsPanelFillingButton.Image");
            drawingToolsPanelFillingButton.ImageTransparentColor = Color.Magenta;
            drawingToolsPanelFillingButton.Name = "drawingToolsPanelFillingButton";
            drawingToolsPanelFillingButton.Size = new Size(22, 24);
            drawingToolsPanelFillingButton.Text = "Filling";
            drawingToolsPanelFillingButton.Click += DrawingToolsPanelFillingButton_Click;
            // 
            // drawingToolsPanelLineButton
            // 
            drawingToolsPanelLineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            drawingToolsPanelLineButton.Image = (Image)resources.GetObject("drawingToolsPanelLineButton.Image");
            drawingToolsPanelLineButton.ImageTransparentColor = Color.Magenta;
            drawingToolsPanelLineButton.Name = "drawingToolsPanelLineButton";
            drawingToolsPanelLineButton.Size = new Size(22, 24);
            drawingToolsPanelLineButton.Text = "Line";
            drawingToolsPanelLineButton.Click += DrawingToolsPanelLineButton_Click;
            // 
            // drawingToolsPanelEllipseButton
            // 
            drawingToolsPanelEllipseButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            drawingToolsPanelEllipseButton.Image = (Image)resources.GetObject("drawingToolsPanelEllipseButton.Image");
            drawingToolsPanelEllipseButton.ImageTransparentColor = Color.Magenta;
            drawingToolsPanelEllipseButton.Name = "drawingToolsPanelEllipseButton";
            drawingToolsPanelEllipseButton.Size = new Size(22, 24);
            drawingToolsPanelEllipseButton.Text = "Ellipse";
            drawingToolsPanelEllipseButton.Click += DrawingToolsPanelEllipseButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(25, 55);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBoxCanvas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Controls.Add(cursorPosition);
            splitContainer1.Size = new Size(1120, 575);
            splitContainer1.SplitterDistance = 824;
            splitContainer1.TabIndex = 2;
            // 
            // pictureBoxCanvas
            // 
            pictureBoxCanvas.BackColor = Color.Transparent;
            pictureBoxCanvas.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxCanvas.Dock = DockStyle.Fill;
            pictureBoxCanvas.Location = new Point(0, 0);
            pictureBoxCanvas.Name = "pictureBoxCanvas";
            pictureBoxCanvas.Size = new Size(820, 571);
            pictureBoxCanvas.TabIndex = 0;
            pictureBoxCanvas.TabStop = false;
            pictureBoxCanvas.Paint += PictureBoxCanvas_Paint;
            pictureBoxCanvas.MouseDown += PictureBoxCanvas_MouseDown;
            pictureBoxCanvas.MouseMove += PictureBoxCanvas_MouseMove;
            pictureBoxCanvas.MouseUp += PictureBoxCanvas_MouseUp;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = SystemColors.Window;
            splitContainer2.Size = new Size(292, 575);
            splitContainer2.SplitterDistance = 345;
            splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.Fixed3D;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(layersLayoutPanel);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(layerPictureBox);
            splitContainer3.Size = new Size(292, 345);
            splitContainer3.SplitterDistance = 254;
            splitContainer3.SplitterWidth = 1;
            splitContainer3.TabIndex = 0;
            // 
            // layersLayoutPanel
            // 
            layersLayoutPanel.ColumnCount = 1;
            layersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layersLayoutPanel.Controls.Add(layersTextBox, 0, 0);
            layersLayoutPanel.Controls.Add(layersListBox, 0, 1);
            layersLayoutPanel.Dock = DockStyle.Fill;
            layersLayoutPanel.Location = new Point(0, 0);
            layersLayoutPanel.Margin = new Padding(0);
            layersLayoutPanel.Name = "layersLayoutPanel";
            layersLayoutPanel.RowCount = 2;
            layersLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.328125F));
            layersLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 88.671875F));
            layersLayoutPanel.Size = new Size(288, 250);
            layersLayoutPanel.TabIndex = 0;
            // 
            // layersTextBox
            // 
            layersTextBox.Dock = DockStyle.Fill;
            layersTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            layersTextBox.Location = new Point(3, 3);
            layersTextBox.Name = "layersTextBox";
            layersTextBox.Size = new Size(282, 29);
            layersTextBox.TabIndex = 1;
            layersTextBox.Text = "Layers:";
            // 
            // layersListBox
            // 
            layersListBox.Dock = DockStyle.Fill;
            layersListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            layersListBox.FormattingEnabled = true;
            layersListBox.ItemHeight = 25;
            layersListBox.Location = new Point(3, 31);
            layersListBox.Name = "layersListBox";
            layersListBox.SelectionMode = SelectionMode.MultiExtended;
            layersListBox.Size = new Size(282, 216);
            layersListBox.TabIndex = 0;
            layersListBox.MouseDoubleClick += LayersListBox_MouseDoubleClick;
            layersListBox.MouseDown += LayersListBox_MouseDown;
            // 
            // layerPictureBox
            // 
            layerPictureBox.BackColor = SystemColors.Window;
            layerPictureBox.Dock = DockStyle.Fill;
            layerPictureBox.Location = new Point(0, 0);
            layerPictureBox.Name = "layerPictureBox";
            layerPictureBox.Size = new Size(288, 86);
            layerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            layerPictureBox.TabIndex = 0;
            layerPictureBox.TabStop = false;
            // 
            // cursorPosition
            // 
            cursorPosition.AutoSize = true;
            cursorPosition.Location = new Point(41, 367);
            cursorPosition.Name = "cursorPosition";
            cursorPosition.Size = new Size(0, 15);
            cursorPosition.TabIndex = 0;
            // 
            // mainMenu
            // 
            mainMenu.BackColor = SystemColors.Control;
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileMainMenuItem, editMainMenuItem, imageMainMenuItem, helpMainMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1145, 24);
            mainMenu.TabIndex = 3;
            mainMenu.Text = "menuStrip1";
            // 
            // fileMainMenuItem
            // 
            fileMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMainMenuItem, mainMenuSeparator1, renameMainMenuItem, moveFileMainMenuItem, copyFileMainMenuItem, deleteFileMainMenuItem, mainMenuSeparator2, saveMainMenuItem, saveAsMainMenuItem, mainMenuSeparator3, exitMainMenuItem });
            fileMainMenuItem.Name = "fileMainMenuItem";
            fileMainMenuItem.Size = new Size(37, 20);
            fileMainMenuItem.Text = "FIle";
            // 
            // openMainMenuItem
            // 
            openMainMenuItem.Name = "openMainMenuItem";
            openMainMenuItem.Size = new Size(145, 22);
            openMainMenuItem.Text = "Open...";
            openMainMenuItem.Click += OpenMainMenuItem_Click;
            // 
            // mainMenuSeparator1
            // 
            mainMenuSeparator1.Name = "mainMenuSeparator1";
            mainMenuSeparator1.Size = new Size(142, 6);
            // 
            // renameMainMenuItem
            // 
            renameMainMenuItem.Name = "renameMainMenuItem";
            renameMainMenuItem.Size = new Size(145, 22);
            renameMainMenuItem.Text = "Rename file...";
            renameMainMenuItem.Click += RenameMainMenuItem_Click;
            // 
            // moveFileMainMenuItem
            // 
            moveFileMainMenuItem.Name = "moveFileMainMenuItem";
            moveFileMainMenuItem.Size = new Size(145, 22);
            moveFileMainMenuItem.Text = "Move file...";
            moveFileMainMenuItem.Click += MoveFileMainMenuItem_Click;
            // 
            // copyFileMainMenuItem
            // 
            copyFileMainMenuItem.Name = "copyFileMainMenuItem";
            copyFileMainMenuItem.Size = new Size(145, 22);
            copyFileMainMenuItem.Text = "Copy file...";
            copyFileMainMenuItem.Click += CopyFileMainMenuItem_Click;
            // 
            // deleteFileMainMenuItem
            // 
            deleteFileMainMenuItem.Name = "deleteFileMainMenuItem";
            deleteFileMainMenuItem.Size = new Size(145, 22);
            deleteFileMainMenuItem.Text = "Delete file...";
            deleteFileMainMenuItem.Click += DeleteFileMainMenuItem_Click;
            // 
            // mainMenuSeparator2
            // 
            mainMenuSeparator2.Name = "mainMenuSeparator2";
            mainMenuSeparator2.Size = new Size(142, 6);
            // 
            // saveMainMenuItem
            // 
            saveMainMenuItem.Name = "saveMainMenuItem";
            saveMainMenuItem.Size = new Size(145, 22);
            saveMainMenuItem.Text = "Save";
            saveMainMenuItem.Click += SaveMainMenuItem_Click;
            // 
            // saveAsMainMenuItem
            // 
            saveAsMainMenuItem.Name = "saveAsMainMenuItem";
            saveAsMainMenuItem.Size = new Size(145, 22);
            saveAsMainMenuItem.Text = "Save as...";
            saveAsMainMenuItem.Click += SaveAsMainMenuItem_Click;
            // 
            // mainMenuSeparator3
            // 
            mainMenuSeparator3.Name = "mainMenuSeparator3";
            mainMenuSeparator3.Size = new Size(142, 6);
            // 
            // exitMainMenuItem
            // 
            exitMainMenuItem.Name = "exitMainMenuItem";
            exitMainMenuItem.Size = new Size(145, 22);
            exitMainMenuItem.Text = "Exit";
            exitMainMenuItem.Click += ExitMainMenuItem_Click;
            // 
            // editMainMenuItem
            // 
            editMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoMainMenuItem, redoMainMenuItem, mainMenuSeparator4, copyMainMenuItem, pasteMainMenuItem });
            editMainMenuItem.Name = "editMainMenuItem";
            editMainMenuItem.Size = new Size(39, 20);
            editMainMenuItem.Text = "Edit";
            // 
            // undoMainMenuItem
            // 
            undoMainMenuItem.Enabled = false;
            undoMainMenuItem.Name = "undoMainMenuItem";
            undoMainMenuItem.Size = new Size(110, 22);
            undoMainMenuItem.Text = "Cancel";
            undoMainMenuItem.Click += UndoRedoMainMenuItem_Click;
            // 
            // redoMainMenuItem
            // 
            redoMainMenuItem.Enabled = false;
            redoMainMenuItem.Name = "redoMainMenuItem";
            redoMainMenuItem.Size = new Size(110, 22);
            redoMainMenuItem.Text = "Return";
            redoMainMenuItem.Click += UndoRedoMainMenuItem_Click;
            // 
            // mainMenuSeparator4
            // 
            mainMenuSeparator4.Name = "mainMenuSeparator4";
            mainMenuSeparator4.Size = new Size(107, 6);
            // 
            // copyMainMenuItem
            // 
            copyMainMenuItem.Name = "copyMainMenuItem";
            copyMainMenuItem.Size = new Size(110, 22);
            copyMainMenuItem.Text = "Copy";
            copyMainMenuItem.Click += CopyPasteMainMenuItem_Click;
            // 
            // pasteMainMenuItem
            // 
            pasteMainMenuItem.Name = "pasteMainMenuItem";
            pasteMainMenuItem.Size = new Size(110, 22);
            pasteMainMenuItem.Text = "Paste";
            pasteMainMenuItem.Click += CopyPasteMainMenuItem_Click;
            // 
            // imageMainMenuItem
            // 
            imageMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imagePropertiesMainMenuItem, mainMenuSeparator5, rotateLeftMainMenuItem, rotateRightMainMenuItem, rotateMainMenuItem, flipVerticallyMainMenuItem, flipHorizontallyMainMenuItem, mainMenuSeparator6, inShadesOfGreyMainMenuItem, showChannelMainMenuItem, invertNegativeMainMenuItem, colorCorrectionMainMenuItem, histogramMainMenuItem, mainMenuSeparator7, switchColorChannelMainMenuItem });
            imageMainMenuItem.Name = "imageMainMenuItem";
            imageMainMenuItem.Size = new Size(52, 20);
            imageMainMenuItem.Text = "Image";
            // 
            // imagePropertiesMainMenuItem
            // 
            imagePropertiesMainMenuItem.Name = "imagePropertiesMainMenuItem";
            imagePropertiesMainMenuItem.Size = new Size(194, 22);
            imagePropertiesMainMenuItem.Text = "Image properties...";
            imagePropertiesMainMenuItem.Click += ImagePropertiesMainMenuItem_Click;
            // 
            // mainMenuSeparator5
            // 
            mainMenuSeparator5.Name = "mainMenuSeparator5";
            mainMenuSeparator5.Size = new Size(191, 6);
            // 
            // rotateLeftMainMenuItem
            // 
            rotateLeftMainMenuItem.Name = "rotateLeftMainMenuItem";
            rotateLeftMainMenuItem.Size = new Size(194, 22);
            rotateLeftMainMenuItem.Text = "Rotate 90 to the left";
            rotateLeftMainMenuItem.Click += RotateMainMenuItem_Click;
            // 
            // rotateRightMainMenuItem
            // 
            rotateRightMainMenuItem.Name = "rotateRightMainMenuItem";
            rotateRightMainMenuItem.Size = new Size(194, 22);
            rotateRightMainMenuItem.Text = "Rotate 90 to the right";
            rotateRightMainMenuItem.Click += RotateMainMenuItem_Click;
            // 
            // rotateMainMenuItem
            // 
            rotateMainMenuItem.Name = "rotateMainMenuItem";
            rotateMainMenuItem.Size = new Size(194, 22);
            rotateMainMenuItem.Text = "Rotate...";
            rotateMainMenuItem.Click += RotateMainMenuItem_Click;
            // 
            // flipVerticallyMainMenuItem
            // 
            flipVerticallyMainMenuItem.Name = "flipVerticallyMainMenuItem";
            flipVerticallyMainMenuItem.Size = new Size(194, 22);
            flipVerticallyMainMenuItem.Text = "Flip vertically";
            flipVerticallyMainMenuItem.Click += FlipMainMenuItem_Click;
            // 
            // flipHorizontallyMainMenuItem
            // 
            flipHorizontallyMainMenuItem.Name = "flipHorizontallyMainMenuItem";
            flipHorizontallyMainMenuItem.Size = new Size(194, 22);
            flipHorizontallyMainMenuItem.Text = "Flip horizontally";
            flipHorizontallyMainMenuItem.Click += FlipMainMenuItem_Click;
            // 
            // mainMenuSeparator6
            // 
            mainMenuSeparator6.Name = "mainMenuSeparator6";
            mainMenuSeparator6.Size = new Size(191, 6);
            // 
            // inShadesOfGreyMainMenuItem
            // 
            inShadesOfGreyMainMenuItem.Name = "inShadesOfGreyMainMenuItem";
            inShadesOfGreyMainMenuItem.Size = new Size(194, 22);
            inShadesOfGreyMainMenuItem.Text = "In shades of grey";
            inShadesOfGreyMainMenuItem.Click += InShadesOfGrayMainMenuItem_Click;
            // 
            // showChannelMainMenuItem
            // 
            showChannelMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redChannelMainMenuItem, greenChannelMainMenuItem, blueChannelMainMenuItem });
            showChannelMainMenuItem.Name = "showChannelMainMenuItem";
            showChannelMainMenuItem.Size = new Size(194, 22);
            showChannelMainMenuItem.Text = "Show the channel";
            // 
            // redChannelMainMenuItem
            // 
            redChannelMainMenuItem.Name = "redChannelMainMenuItem";
            redChannelMainMenuItem.Size = new Size(105, 22);
            redChannelMainMenuItem.Text = "Red";
            redChannelMainMenuItem.Click += ShowChannelMainMenuItem_Click;
            // 
            // greenChannelMainMenuItem
            // 
            greenChannelMainMenuItem.Name = "greenChannelMainMenuItem";
            greenChannelMainMenuItem.Size = new Size(105, 22);
            greenChannelMainMenuItem.Text = "Green";
            greenChannelMainMenuItem.Click += ShowChannelMainMenuItem_Click;
            // 
            // blueChannelMainMenuItem
            // 
            blueChannelMainMenuItem.Name = "blueChannelMainMenuItem";
            blueChannelMainMenuItem.Size = new Size(105, 22);
            blueChannelMainMenuItem.Text = "Blue";
            blueChannelMainMenuItem.Click += ShowChannelMainMenuItem_Click;
            // 
            // invertNegativeMainMenuItem
            // 
            invertNegativeMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allChannelMainMenuItem, mainMenuSeparator8, redMainMenuItem, greenMainMenuItem, blueMainMenuItem });
            invertNegativeMainMenuItem.Name = "invertNegativeMainMenuItem";
            invertNegativeMainMenuItem.Size = new Size(194, 22);
            invertNegativeMainMenuItem.Text = "Invert (to the negative)";
            // 
            // allChannelMainMenuItem
            // 
            allChannelMainMenuItem.Name = "allChannelMainMenuItem";
            allChannelMainMenuItem.Size = new Size(133, 22);
            allChannelMainMenuItem.Text = "All channel";
            allChannelMainMenuItem.Click += InvertMainMenuItem_Click;
            // 
            // mainMenuSeparator8
            // 
            mainMenuSeparator8.Name = "mainMenuSeparator8";
            mainMenuSeparator8.Size = new Size(130, 6);
            // 
            // redMainMenuItem
            // 
            redMainMenuItem.Name = "redMainMenuItem";
            redMainMenuItem.Size = new Size(133, 22);
            redMainMenuItem.Text = "Red";
            redMainMenuItem.Click += InvertMainMenuItem_Click;
            // 
            // greenMainMenuItem
            // 
            greenMainMenuItem.Name = "greenMainMenuItem";
            greenMainMenuItem.Size = new Size(133, 22);
            greenMainMenuItem.Text = "Green";
            greenMainMenuItem.Click += InvertMainMenuItem_Click;
            // 
            // blueMainMenuItem
            // 
            blueMainMenuItem.Name = "blueMainMenuItem";
            blueMainMenuItem.Size = new Size(133, 22);
            blueMainMenuItem.Text = "Blue";
            blueMainMenuItem.Click += InvertMainMenuItem_Click;
            // 
            // colorCorrectionMainMenuItem
            // 
            colorCorrectionMainMenuItem.Name = "colorCorrectionMainMenuItem";
            colorCorrectionMainMenuItem.Size = new Size(194, 22);
            colorCorrectionMainMenuItem.Text = "Color correction...";
            colorCorrectionMainMenuItem.Click += ColorCorrectionMainMenuItem_Click;
            // 
            // histogramMainMenuItem
            // 
            histogramMainMenuItem.Name = "histogramMainMenuItem";
            histogramMainMenuItem.Size = new Size(194, 22);
            histogramMainMenuItem.Text = "Histogram...";
            histogramMainMenuItem.Click += HistogramMainMenuItem_Click;
            // 
            // mainMenuSeparator7
            // 
            mainMenuSeparator7.Name = "mainMenuSeparator7";
            mainMenuSeparator7.Size = new Size(191, 6);
            // 
            // switchColorChannelMainMenuItem
            // 
            switchColorChannelMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RGBtoRBGMainMenuItem, RGBtoBGRMainMenuItem, RGBtoBRGMainMenuItem, RGBtoGRBMainMenuItem, RGBtoGBRMainMenuItem });
            switchColorChannelMainMenuItem.Name = "switchColorChannelMainMenuItem";
            switchColorChannelMainMenuItem.Size = new Size(194, 22);
            switchColorChannelMainMenuItem.Text = "Switch color channel";
            // 
            // RGBtoRBGMainMenuItem
            // 
            RGBtoRBGMainMenuItem.Name = "RGBtoRBGMainMenuItem";
            RGBtoRBGMainMenuItem.Size = new Size(137, 22);
            RGBtoRBGMainMenuItem.Text = "RGB -> RBG";
            RGBtoRBGMainMenuItem.Click += SwitchColorChannelMainMenuItem_Click;
            // 
            // RGBtoBGRMainMenuItem
            // 
            RGBtoBGRMainMenuItem.Name = "RGBtoBGRMainMenuItem";
            RGBtoBGRMainMenuItem.Size = new Size(137, 22);
            RGBtoBGRMainMenuItem.Text = "RGB -> BGR";
            RGBtoBGRMainMenuItem.Click += SwitchColorChannelMainMenuItem_Click;
            // 
            // RGBtoBRGMainMenuItem
            // 
            RGBtoBRGMainMenuItem.Name = "RGBtoBRGMainMenuItem";
            RGBtoBRGMainMenuItem.Size = new Size(137, 22);
            RGBtoBRGMainMenuItem.Text = "RGB -> BRG";
            RGBtoBRGMainMenuItem.Click += SwitchColorChannelMainMenuItem_Click;
            // 
            // RGBtoGRBMainMenuItem
            // 
            RGBtoGRBMainMenuItem.Name = "RGBtoGRBMainMenuItem";
            RGBtoGRBMainMenuItem.Size = new Size(137, 22);
            RGBtoGRBMainMenuItem.Text = "RGB -> GRB";
            RGBtoGRBMainMenuItem.Click += SwitchColorChannelMainMenuItem_Click;
            // 
            // RGBtoGBRMainMenuItem
            // 
            RGBtoGBRMainMenuItem.Name = "RGBtoGBRMainMenuItem";
            RGBtoGBRMainMenuItem.Size = new Size(137, 22);
            RGBtoGBRMainMenuItem.Text = "RGB -> GBR";
            RGBtoGBRMainMenuItem.Click += SwitchColorChannelMainMenuItem_Click;
            // 
            // helpMainMenuItem
            // 
            helpMainMenuItem.Name = "helpMainMenuItem";
            helpMainMenuItem.Size = new Size(44, 20);
            helpMainMenuItem.Text = "Help";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "Images|*.bmp;*.jpg;*.png";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Images|*.bmp;*.jpg;*.png";
            // 
            // mainFormStyle
            // 
            mainFormStyle.AllowUserResize = true;
            mainFormStyle.BackColor = Color.Gray;
            mainFormStyle.BorderColor = Color.Gray;
            mainFormStyle.BorderWidth = 4;
            mainFormStyle.ContextMenuForm = null;
            mainFormStyle.ControlBoxButtonsWidth = 40;
            mainFormStyle.Form = this;
            mainFormStyle.FormStyle = MainFormStyle.Style.None;
            mainFormStyle.HeaderColor = Color.Gray;
            mainFormStyle.HeaderHeight = 28;
            mainFormStyle.HeaderTextColor = Color.White;
            mainFormStyle.HeaderTextFont = new Font("Arial", 8.75F);
            mainFormStyle.IconImage = null;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 630);
            Controls.Add(splitContainer1);
            Controls.Add(drawingToolsPanel);
            Controls.Add(mainToolsPanel);
            Controls.Add(mainMenu);
            KeyPreview = true;
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhotoChange";
            KeyDown += MainForm_KeyDown;
            mainToolsPanel.ResumeLayout(false);
            mainToolsPanel.PerformLayout();
            drawingToolsPanel.ResumeLayout(false);
            drawingToolsPanel.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            layersLayoutPanel.ResumeLayout(false);
            layersLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)layerPictureBox).EndInit();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MainFormStyle mainFormStyle;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private TableLayoutPanel layersLayoutPanel;
        private ListBox layersListBox;
        private TextBox layersTextBox;
        private PictureBox layerPictureBox;
        private PictureBox pictureBoxCanvas;

        private ContextMenuStrip contextMenuIcon;
        private ToolStrip mainToolsPanel;
        private ToolStrip drawingToolsPanel;
        private MenuStrip mainMenu;

        private ToolStripButton mainToolsPanelHomeButton;
        private ToolStripButton mainToolsPanelColorButton;
        private ToolStripButton mainToolsPanelCombineLayersButton;
        private ToolStripSplitButton mainToolsPanelSizeSplitButton;
        private ToolStripButton drawingToolsPanelEraserButton;
        private ToolStripButton drawingToolsPanelPipetteButton;
        private ToolStripButton drawingToolsPanelFillingButton;
        private ToolStripButton drawingToolsPanelBrushButton;
        private ToolStripButton drawingToolsPanelLineButton;
        private ToolStripButton drawingToolsPanelEllipseButton;
        private ToolStripButton drawingToolsPanelCursorButton;

        private ToolStripMenuItem fileMainMenuItem;
        private ToolStripMenuItem editMainMenuItem;
        private ToolStripMenuItem imageMainMenuItem;
        private ToolStripMenuItem openMainMenuItem;       
        private ToolStripMenuItem renameMainMenuItem;
        private ToolStripMenuItem moveFileMainMenuItem;
        private ToolStripMenuItem copyFileMainMenuItem;
        private ToolStripMenuItem deleteFileMainMenuItem;
        private ToolStripMenuItem saveMainMenuItem;
        private ToolStripMenuItem saveAsMainMenuItem;
        private ToolStripMenuItem exitMainMenuItem;
        private ToolStripMenuItem undoMainMenuItem;
        private ToolStripMenuItem redoMainMenuItem;
        private ToolStripMenuItem copyMainMenuItem;
        private ToolStripMenuItem pasteMainMenuItem;
        private ToolStripMenuItem imagePropertiesMainMenuItem;
        private ToolStripMenuItem rotateLeftMainMenuItem;
        private ToolStripMenuItem rotateRightMainMenuItem;
        private ToolStripMenuItem rotateMainMenuItem;
        private ToolStripMenuItem flipVerticallyMainMenuItem;
        private ToolStripMenuItem flipHorizontallyMainMenuItem;
        private ToolStripMenuItem inShadesOfGreyMainMenuItem;
        private ToolStripMenuItem showChannelMainMenuItem;
        private ToolStripMenuItem redChannelMainMenuItem;
        private ToolStripMenuItem greenChannelMainMenuItem;
        private ToolStripMenuItem blueChannelMainMenuItem;
        private ToolStripMenuItem invertNegativeMainMenuItem;
        private ToolStripMenuItem allChannelMainMenuItem;
        private ToolStripMenuItem redMainMenuItem;
        private ToolStripMenuItem greenMainMenuItem;
        private ToolStripMenuItem blueMainMenuItem;
        private ToolStripMenuItem colorCorrectionMainMenuItem;
        private ToolStripMenuItem histogramMainMenuItem;
        private ToolStripMenuItem switchColorChannelMainMenuItem;
        private ToolStripMenuItem RGBtoRBGMainMenuItem;
        private ToolStripMenuItem RGBtoBGRMainMenuItem;
        private ToolStripMenuItem RGBtoBRGMainMenuItem;
        private ToolStripMenuItem RGBtoGRBMainMenuItem;
        private ToolStripMenuItem RGBtoGBRMainMenuItem;
        private ToolStripMenuItem helpMainMenuItem;
        private ToolStripMenuItem size3MainToolsPanelItem;
        private ToolStripMenuItem size4MainToolsPanelItem;
        private ToolStripMenuItem size5MainToolsPanelItem;
        private ToolStripMenuItem size20MainToolsPanelItem;
        private ToolStripTextBox editScaleMainToolsPanelTextBox;

        private ToolStripSeparator mainToolsPanelSeparator1;
        private ToolStripSeparator mainToolsPanelSeparator2;
        private ToolStripSeparator mainToolsPanelSeparator3;
        private ToolStripSeparator mainToolsPanelSeparator4;
        private ToolStripSeparator mainToolsPanelSeparator5;
        private ToolStripSeparator mainMenuSeparator1;
        private ToolStripSeparator mainMenuSeparator2;
        private ToolStripSeparator mainMenuSeparator3;
        private ToolStripSeparator mainMenuSeparator4;
        private ToolStripSeparator mainMenuSeparator5;
        private ToolStripSeparator mainMenuSeparator6;
        private ToolStripSeparator mainMenuSeparator7;
        private ToolStripSeparator mainMenuSeparator8;

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private ColorDialog colorDialog;

        private Label cursorPosition;        
        private ToolStripLabel mainToolsPanelSizeModeLabel;
        private ToolStripLabel mainToolsPanelEditScaleLabel;
    }
}