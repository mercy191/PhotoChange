
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
            mainFormStyle = new MainFormStyle(components);
            contextMenuIcon = new ContextMenuStrip(components);
            mainToolsPanel = new ToolStrip();
            mainToolsPanelHomeButton = new ToolStripButton();
            mainToolsPanelSeparator1 = new ToolStripSeparator();
            mainToolsPanelBrushPaletteButton = new ToolStripButton();
            mainToolsPanelSeparator2 = new ToolStripSeparator();
            mainToolsPanelBrushSizeButton = new ToolStripButton();
            drawingToolsPanel = new ToolStrip();
            drawingToolsPanelBrushButton = new ToolStripButton();
            drawingToolsPanelEraserButton = new ToolStripButton();
            drawingToolsPanelPipetteButton = new ToolStripButton();
            drawingToolsPanelFillingButton = new ToolStripButton();
            splitContainer = new SplitContainer();
            pictureBox = new PictureBox();
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
            cancelMainMenuItem = new ToolStripMenuItem();
            returnMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator4 = new ToolStripSeparator();
            copyMainMenuItem = new ToolStripMenuItem();
            pasteMainMenuItem = new ToolStripMenuItem();
            deleteImageMainMenuItem = new ToolStripMenuItem();
            imageMainMenuItem = new ToolStripMenuItem();
            imagePropertiesMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator5 = new ToolStripSeparator();
            createNewImageMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator6 = new ToolStripSeparator();
            rotateLeftMainMenuItem = new ToolStripMenuItem();
            rotateRightMainMenuItem = new ToolStripMenuItem();
            rotateMainMenuItem = new ToolStripMenuItem();
            flipVerticallyMainMenuItem = new ToolStripMenuItem();
            flipHorizontallyMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator7 = new ToolStripSeparator();
            editImageSizeMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator8 = new ToolStripSeparator();
            increaseColorDepthMainMenuItem = new ToolStripMenuItem();
            reduceColorDepthMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator9 = new ToolStripSeparator();
            inShadesOfGreyMainMenuItem = new ToolStripMenuItem();
            showChannelMainMenuItem = new ToolStripMenuItem();
            redChannelMainMenuItem = new ToolStripMenuItem();
            greenChannelMainMenuItem = new ToolStripMenuItem();
            blueChannelMainMenuItem = new ToolStripMenuItem();
            invertNegativeMainMenuItem = new ToolStripMenuItem();
            allChannelToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator13 = new ToolStripSeparator();
            redToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            colorCorrectionMainMenuItem = new ToolStripMenuItem();
            histogramMainMenuItem = new ToolStripMenuItem();
            replaceColorMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator10 = new ToolStripSeparator();
            autoColorCorrectionMainMenuItem = new ToolStripMenuItem();
            increaseSharpnessMainMenuItem = new ToolStripMenuItem();
            mainMenuSeparator11 = new ToolStripSeparator();
            switchColorChannelMainMenuItem = new ToolStripMenuItem();
            RGBtoRBGMainMenuItem = new ToolStripMenuItem();
            RGBtoBGRMainMenuItem = new ToolStripMenuItem();
            RGBtoBRGMainMenuItem = new ToolStripMenuItem();
            RGBtoGRBMainMenuItem = new ToolStripMenuItem();
            RGBtoGBRMainMenuItem = new ToolStripMenuItem();
            paletteMainMenuItem = new ToolStripMenuItem();
            helpMainMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();
            colorDialog = new ColorDialog();
            mainToolsPanel.SuspendLayout();
            drawingToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormStyle
            // 
            mainFormStyle.AllowUserResize = true;
            mainFormStyle.BackColor = Color.Gray;
            mainFormStyle.BorderColor = Color.Gray;
            mainFormStyle.BorderWidth = 4;
            mainFormStyle.ContextMenuForm = contextMenuIcon;
            mainFormStyle.ControlBoxButtonsWidth = 40;
            mainFormStyle.Form = this;
            mainFormStyle.FormStyle = MainFormStyle.Style.None;
            mainFormStyle.HeaderColor = Color.Gray;
            mainFormStyle.HeaderHeight = 28;
            mainFormStyle.HeaderTextColor = Color.White;
            mainFormStyle.HeaderTextFont = new Font("Arial", 8.75F);
            mainFormStyle.IconImage = null;
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
            mainToolsPanel.Items.AddRange(new ToolStripItem[] { mainToolsPanelHomeButton, mainToolsPanelSeparator1, mainToolsPanelBrushPaletteButton, mainToolsPanelSeparator2, mainToolsPanelBrushSizeButton });
            mainToolsPanel.Location = new Point(0, 24);
            mainToolsPanel.Name = "mainToolsPanel";
            mainToolsPanel.Size = new Size(1113, 25);
            mainToolsPanel.TabIndex = 0;
            mainToolsPanel.Text = "toolStrip1";
            // 
            // mainToolsPanelHomeButton
            // 
            mainToolsPanelHomeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            mainToolsPanelHomeButton.ImageTransparentColor = Color.Magenta;
            mainToolsPanelHomeButton.Name = "mainToolsPanelHomeButton";
            mainToolsPanelHomeButton.Size = new Size(23, 22);
            mainToolsPanelHomeButton.Text = "toolStripButton1";
            mainToolsPanelHomeButton.ToolTipText = "Home Button";
            // 
            // mainToolsPanelSeparator1
            // 
            mainToolsPanelSeparator1.Name = "mainToolsPanelSeparator1";
            mainToolsPanelSeparator1.Size = new Size(6, 25);
            // 
            // mainToolsPanelBrushPaletteButton
            // 
            mainToolsPanelBrushPaletteButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            mainToolsPanelBrushPaletteButton.ImageTransparentColor = Color.Magenta;
            mainToolsPanelBrushPaletteButton.Name = "mainToolsPanelBrushPaletteButton";
            mainToolsPanelBrushPaletteButton.Size = new Size(23, 22);
            mainToolsPanelBrushPaletteButton.Text = "Palette";
            // 
            // mainToolsPanelSeparator2
            // 
            mainToolsPanelSeparator2.Name = "mainToolsPanelSeparator2";
            mainToolsPanelSeparator2.Size = new Size(6, 25);
            // 
            // mainToolsPanelBrushSizeButton
            // 
            mainToolsPanelBrushSizeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            mainToolsPanelBrushSizeButton.ImageTransparentColor = Color.Magenta;
            mainToolsPanelBrushSizeButton.Name = "mainToolsPanelBrushSizeButton";
            mainToolsPanelBrushSizeButton.Size = new Size(23, 22);
            mainToolsPanelBrushSizeButton.Text = "Brush Size";
            // 
            // drawingToolsPanel
            // 
            drawingToolsPanel.BackColor = SystemColors.Control;
            drawingToolsPanel.Dock = DockStyle.Left;
            drawingToolsPanel.ImageScalingSize = new Size(20, 20);
            drawingToolsPanel.Items.AddRange(new ToolStripItem[] { drawingToolsPanelBrushButton, drawingToolsPanelEraserButton, drawingToolsPanelPipetteButton, drawingToolsPanelFillingButton });
            drawingToolsPanel.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            drawingToolsPanel.Location = new Point(0, 49);
            drawingToolsPanel.Name = "drawingToolsPanel";
            drawingToolsPanel.Size = new Size(25, 545);
            drawingToolsPanel.TabIndex = 1;
            drawingToolsPanel.Text = "toolStrip2";
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
            // splitContainer
            // 
            splitContainer.BorderStyle = BorderStyle.Fixed3D;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(25, 49);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(pictureBox);
            splitContainer.Size = new Size(1088, 545);
            splitContainer.SplitterDistance = 809;
            splitContainer.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(805, 541);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += PictureBox_MouseDown;
            // 
            // mainMenu
            // 
            mainMenu.BackColor = SystemColors.Control;
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileMainMenuItem, editMainMenuItem, imageMainMenuItem, helpMainMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1113, 24);
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
            editMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cancelMainMenuItem, returnMainMenuItem, mainMenuSeparator4, copyMainMenuItem, pasteMainMenuItem, deleteImageMainMenuItem });
            editMainMenuItem.Name = "editMainMenuItem";
            editMainMenuItem.Size = new Size(39, 20);
            editMainMenuItem.Text = "Edit";
            // 
            // cancelMainMenuItem
            // 
            cancelMainMenuItem.Name = "cancelMainMenuItem";
            cancelMainMenuItem.Size = new Size(143, 22);
            cancelMainMenuItem.Text = "Cancel";
            cancelMainMenuItem.Click += CancelMainMenuItem_Click;
            // 
            // returnMainMenuItem
            // 
            returnMainMenuItem.Name = "returnMainMenuItem";
            returnMainMenuItem.Size = new Size(143, 22);
            returnMainMenuItem.Text = "Return";
            returnMainMenuItem.Click += ReturnMainMenuItem_Click;
            // 
            // mainMenuSeparator4
            // 
            mainMenuSeparator4.Name = "mainMenuSeparator4";
            mainMenuSeparator4.Size = new Size(140, 6);
            // 
            // copyMainMenuItem
            // 
            copyMainMenuItem.Name = "copyMainMenuItem";
            copyMainMenuItem.Size = new Size(143, 22);
            copyMainMenuItem.Text = "Copy";
            copyMainMenuItem.Click += CopyMainMenuItem_Click;
            // 
            // pasteMainMenuItem
            // 
            pasteMainMenuItem.Name = "pasteMainMenuItem";
            pasteMainMenuItem.Size = new Size(143, 22);
            pasteMainMenuItem.Text = "Paste";
            pasteMainMenuItem.Click += PasteMainMenuItem_Click;
            // 
            // deleteImageMainMenuItem
            // 
            deleteImageMainMenuItem.Name = "deleteImageMainMenuItem";
            deleteImageMainMenuItem.Size = new Size(143, 22);
            deleteImageMainMenuItem.Text = "Delete image";
            deleteImageMainMenuItem.Click += DeleteImageMainMenuItem_Click;
            // 
            // imageMainMenuItem
            // 
            imageMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imagePropertiesMainMenuItem, mainMenuSeparator5, createNewImageMainMenuItem, mainMenuSeparator6, rotateLeftMainMenuItem, rotateRightMainMenuItem, rotateMainMenuItem, flipVerticallyMainMenuItem, flipHorizontallyMainMenuItem, mainMenuSeparator7, editImageSizeMainMenuItem, mainMenuSeparator8, increaseColorDepthMainMenuItem, reduceColorDepthMainMenuItem, mainMenuSeparator9, inShadesOfGreyMainMenuItem, showChannelMainMenuItem, invertNegativeMainMenuItem, colorCorrectionMainMenuItem, histogramMainMenuItem, replaceColorMainMenuItem, mainMenuSeparator10, autoColorCorrectionMainMenuItem, increaseSharpnessMainMenuItem, mainMenuSeparator11, switchColorChannelMainMenuItem, paletteMainMenuItem });
            imageMainMenuItem.Name = "imageMainMenuItem";
            imageMainMenuItem.Size = new Size(52, 20);
            imageMainMenuItem.Text = "Image";
            // 
            // imagePropertiesMainMenuItem
            // 
            imagePropertiesMainMenuItem.Name = "imagePropertiesMainMenuItem";
            imagePropertiesMainMenuItem.Size = new Size(210, 22);
            imagePropertiesMainMenuItem.Text = "Image properties...";
            // 
            // mainMenuSeparator5
            // 
            mainMenuSeparator5.Name = "mainMenuSeparator5";
            mainMenuSeparator5.Size = new Size(207, 6);
            // 
            // createNewImageMainMenuItem
            // 
            createNewImageMainMenuItem.Name = "createNewImageMainMenuItem";
            createNewImageMainMenuItem.Size = new Size(210, 22);
            createNewImageMainMenuItem.Text = "Create new image...";
            // 
            // mainMenuSeparator6
            // 
            mainMenuSeparator6.Name = "mainMenuSeparator6";
            mainMenuSeparator6.Size = new Size(207, 6);
            // 
            // rotateLeftMainMenuItem
            // 
            rotateLeftMainMenuItem.Name = "rotateLeftMainMenuItem";
            rotateLeftMainMenuItem.Size = new Size(210, 22);
            rotateLeftMainMenuItem.Text = "Rotate 90 to the left";
            // 
            // rotateRightMainMenuItem
            // 
            rotateRightMainMenuItem.Name = "rotateRightMainMenuItem";
            rotateRightMainMenuItem.Size = new Size(210, 22);
            rotateRightMainMenuItem.Text = "Rotate 90 to the right";
            // 
            // rotateMainMenuItem
            // 
            rotateMainMenuItem.Name = "rotateMainMenuItem";
            rotateMainMenuItem.Size = new Size(210, 22);
            rotateMainMenuItem.Text = "Rotate...";
            // 
            // flipVerticallyMainMenuItem
            // 
            flipVerticallyMainMenuItem.Name = "flipVerticallyMainMenuItem";
            flipVerticallyMainMenuItem.Size = new Size(210, 22);
            flipVerticallyMainMenuItem.Text = "Flip vertically";
            // 
            // flipHorizontallyMainMenuItem
            // 
            flipHorizontallyMainMenuItem.Name = "flipHorizontallyMainMenuItem";
            flipHorizontallyMainMenuItem.Size = new Size(210, 22);
            flipHorizontallyMainMenuItem.Text = "Flip horizontally";
            // 
            // mainMenuSeparator7
            // 
            mainMenuSeparator7.Name = "mainMenuSeparator7";
            mainMenuSeparator7.Size = new Size(207, 6);
            // 
            // editImageSizeMainMenuItem
            // 
            editImageSizeMainMenuItem.Name = "editImageSizeMainMenuItem";
            editImageSizeMainMenuItem.Size = new Size(210, 22);
            editImageSizeMainMenuItem.Text = "Edit image size...";
            // 
            // mainMenuSeparator8
            // 
            mainMenuSeparator8.Name = "mainMenuSeparator8";
            mainMenuSeparator8.Size = new Size(207, 6);
            // 
            // increaseColorDepthMainMenuItem
            // 
            increaseColorDepthMainMenuItem.Name = "increaseColorDepthMainMenuItem";
            increaseColorDepthMainMenuItem.Size = new Size(210, 22);
            increaseColorDepthMainMenuItem.Text = "Increase the color depth...";
            // 
            // reduceColorDepthMainMenuItem
            // 
            reduceColorDepthMainMenuItem.Name = "reduceColorDepthMainMenuItem";
            reduceColorDepthMainMenuItem.Size = new Size(210, 22);
            reduceColorDepthMainMenuItem.Text = "Reduce the color depth...";
            // 
            // mainMenuSeparator9
            // 
            mainMenuSeparator9.Name = "mainMenuSeparator9";
            mainMenuSeparator9.Size = new Size(207, 6);
            // 
            // inShadesOfGreyMainMenuItem
            // 
            inShadesOfGreyMainMenuItem.Name = "inShadesOfGreyMainMenuItem";
            inShadesOfGreyMainMenuItem.Size = new Size(210, 22);
            inShadesOfGreyMainMenuItem.Text = "In shades of grey";
            // 
            // showChannelMainMenuItem
            // 
            showChannelMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redChannelMainMenuItem, greenChannelMainMenuItem, blueChannelMainMenuItem });
            showChannelMainMenuItem.Name = "showChannelMainMenuItem";
            showChannelMainMenuItem.Size = new Size(210, 22);
            showChannelMainMenuItem.Text = "Show the channel";
            // 
            // redChannelMainMenuItem
            // 
            redChannelMainMenuItem.Name = "redChannelMainMenuItem";
            redChannelMainMenuItem.Size = new Size(105, 22);
            redChannelMainMenuItem.Text = "Red";
            // 
            // greenChannelMainMenuItem
            // 
            greenChannelMainMenuItem.Name = "greenChannelMainMenuItem";
            greenChannelMainMenuItem.Size = new Size(105, 22);
            greenChannelMainMenuItem.Text = "Green";
            // 
            // blueChannelMainMenuItem
            // 
            blueChannelMainMenuItem.Name = "blueChannelMainMenuItem";
            blueChannelMainMenuItem.Size = new Size(105, 22);
            blueChannelMainMenuItem.Text = "Blue";
            // 
            // invertNegativeMainMenuItem
            // 
            invertNegativeMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allChannelToolStripMenuItem, toolStripSeparator13, redToolStripMenuItem, greenToolStripMenuItem, blueToolStripMenuItem });
            invertNegativeMainMenuItem.Name = "invertNegativeMainMenuItem";
            invertNegativeMainMenuItem.Size = new Size(210, 22);
            invertNegativeMainMenuItem.Text = "Invert (to the negative)";
            // 
            // allChannelToolStripMenuItem
            // 
            allChannelToolStripMenuItem.Name = "allChannelToolStripMenuItem";
            allChannelToolStripMenuItem.Size = new Size(133, 22);
            allChannelToolStripMenuItem.Text = "All channel";
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new Size(130, 6);
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(133, 22);
            redToolStripMenuItem.Text = "Red";
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(133, 22);
            greenToolStripMenuItem.Text = "Green";
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(133, 22);
            blueToolStripMenuItem.Text = "Blue";
            // 
            // colorCorrectionMainMenuItem
            // 
            colorCorrectionMainMenuItem.Name = "colorCorrectionMainMenuItem";
            colorCorrectionMainMenuItem.Size = new Size(210, 22);
            colorCorrectionMainMenuItem.Text = "Color correction...";
            // 
            // histogramMainMenuItem
            // 
            histogramMainMenuItem.Name = "histogramMainMenuItem";
            histogramMainMenuItem.Size = new Size(210, 22);
            histogramMainMenuItem.Text = "Histogram...";
            // 
            // replaceColorMainMenuItem
            // 
            replaceColorMainMenuItem.Name = "replaceColorMainMenuItem";
            replaceColorMainMenuItem.Size = new Size(210, 22);
            replaceColorMainMenuItem.Text = "Replace the color";
            // 
            // mainMenuSeparator10
            // 
            mainMenuSeparator10.Name = "mainMenuSeparator10";
            mainMenuSeparator10.Size = new Size(207, 6);
            // 
            // autoColorCorrectionMainMenuItem
            // 
            autoColorCorrectionMainMenuItem.Name = "autoColorCorrectionMainMenuItem";
            autoColorCorrectionMainMenuItem.Size = new Size(210, 22);
            autoColorCorrectionMainMenuItem.Text = "Auto color correction";
            // 
            // increaseSharpnessMainMenuItem
            // 
            increaseSharpnessMainMenuItem.Name = "increaseSharpnessMainMenuItem";
            increaseSharpnessMainMenuItem.Size = new Size(210, 22);
            increaseSharpnessMainMenuItem.Text = "Increase the sharpness";
            // 
            // mainMenuSeparator11
            // 
            mainMenuSeparator11.Name = "mainMenuSeparator11";
            mainMenuSeparator11.Size = new Size(207, 6);
            // 
            // switchColorChannelMainMenuItem
            // 
            switchColorChannelMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RGBtoRBGMainMenuItem, RGBtoBGRMainMenuItem, RGBtoBRGMainMenuItem, RGBtoGRBMainMenuItem, RGBtoGBRMainMenuItem });
            switchColorChannelMainMenuItem.Name = "switchColorChannelMainMenuItem";
            switchColorChannelMainMenuItem.Size = new Size(210, 22);
            switchColorChannelMainMenuItem.Text = "Switch color channel";
            // 
            // RGBtoRBGMainMenuItem
            // 
            RGBtoRBGMainMenuItem.Name = "RGBtoRBGMainMenuItem";
            RGBtoRBGMainMenuItem.Size = new Size(137, 22);
            RGBtoRBGMainMenuItem.Text = "RGB -> RBG";
            // 
            // RGBtoBGRMainMenuItem
            // 
            RGBtoBGRMainMenuItem.Name = "RGBtoBGRMainMenuItem";
            RGBtoBGRMainMenuItem.Size = new Size(137, 22);
            RGBtoBGRMainMenuItem.Text = "RGB -> BGR";
            // 
            // RGBtoBRGMainMenuItem
            // 
            RGBtoBRGMainMenuItem.Name = "RGBtoBRGMainMenuItem";
            RGBtoBRGMainMenuItem.Size = new Size(137, 22);
            RGBtoBRGMainMenuItem.Text = "RGB -> BRG";
            // 
            // RGBtoGRBMainMenuItem
            // 
            RGBtoGRBMainMenuItem.Name = "RGBtoGRBMainMenuItem";
            RGBtoGRBMainMenuItem.Size = new Size(137, 22);
            RGBtoGRBMainMenuItem.Text = "RGB -> GRB";
            // 
            // RGBtoGBRMainMenuItem
            // 
            RGBtoGBRMainMenuItem.Name = "RGBtoGBRMainMenuItem";
            RGBtoGBRMainMenuItem.Size = new Size(137, 22);
            RGBtoGBRMainMenuItem.Text = "RGB -> GBR";
            // 
            // paletteMainMenuItem
            // 
            paletteMainMenuItem.Name = "paletteMainMenuItem";
            paletteMainMenuItem.Size = new Size(210, 22);
            paletteMainMenuItem.Text = "Palette";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 594);
            Controls.Add(splitContainer);
            Controls.Add(drawingToolsPanel);
            Controls.Add(mainToolsPanel);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhotoChange";
            mainToolsPanel.ResumeLayout(false);
            mainToolsPanel.PerformLayout();
            drawingToolsPanel.ResumeLayout(false);
            drawingToolsPanel.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MainFormStyle mainFormStyle;
        private SplitContainer splitContainer;
        private PictureBox pictureBox;

        private ContextMenuStrip contextMenuIcon;
        private ToolStrip mainToolsPanel;
        private ToolStrip drawingToolsPanel;
        private MenuStrip mainMenu;

        private ToolStripButton mainToolsPanelHomeButton;
        private ToolStripButton mainToolsPanelBrushPaletteButton;
        private ToolStripButton mainToolsPanelBrushSizeButton;
        private ToolStripButton drawingToolsPanelEraserButton;
        private ToolStripButton drawingToolsPanelPipetteButton;
        private ToolStripButton drawingToolsPanelFillingButton;
        private ToolStripButton drawingToolsPanelBrushButton;

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
        private ToolStripMenuItem cancelMainMenuItem;
        private ToolStripMenuItem returnMainMenuItem;
        private ToolStripMenuItem copyMainMenuItem;
        private ToolStripMenuItem pasteMainMenuItem;
        private ToolStripMenuItem deleteImageMainMenuItem;
        private ToolStripMenuItem imagePropertiesMainMenuItem;
        private ToolStripMenuItem createNewImageMainMenuItem;
        private ToolStripMenuItem rotateLeftMainMenuItem;
        private ToolStripMenuItem rotateRightMainMenuItem;
        private ToolStripMenuItem rotateMainMenuItem;
        private ToolStripMenuItem flipVerticallyMainMenuItem;
        private ToolStripMenuItem flipHorizontallyMainMenuItem;
        private ToolStripMenuItem editImageSizeMainMenuItem;
        private ToolStripMenuItem increaseColorDepthMainMenuItem;
        private ToolStripMenuItem reduceColorDepthMainMenuItem;
        private ToolStripMenuItem inShadesOfGreyMainMenuItem;
        private ToolStripMenuItem showChannelMainMenuItem;
        private ToolStripMenuItem redChannelMainMenuItem;
        private ToolStripMenuItem greenChannelMainMenuItem;
        private ToolStripMenuItem blueChannelMainMenuItem;
        private ToolStripMenuItem invertNegativeMainMenuItem;
        private ToolStripMenuItem allChannelToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem colorCorrectionMainMenuItem;
        private ToolStripMenuItem histogramMainMenuItem;
        private ToolStripMenuItem replaceColorMainMenuItem;
        private ToolStripMenuItem autoColorCorrectionMainMenuItem;
        private ToolStripMenuItem increaseSharpnessMainMenuItem;
        private ToolStripMenuItem switchColorChannelMainMenuItem;
        private ToolStripMenuItem RGBtoRBGMainMenuItem;
        private ToolStripMenuItem RGBtoBGRMainMenuItem;
        private ToolStripMenuItem RGBtoBRGMainMenuItem;
        private ToolStripMenuItem RGBtoGRBMainMenuItem;
        private ToolStripMenuItem RGBtoGBRMainMenuItem;
        private ToolStripMenuItem paletteMainMenuItem;
        private ToolStripMenuItem helpMainMenuItem;

        private ToolStripSeparator mainToolsPanelSeparator1;
        private ToolStripSeparator mainToolsPanelSeparator2;
        private ToolStripSeparator mainMenuSeparator1;
        private ToolStripSeparator mainMenuSeparator2;
        private ToolStripSeparator mainMenuSeparator3;
        private ToolStripSeparator mainMenuSeparator4;
        private ToolStripSeparator mainMenuSeparator5;
        private ToolStripSeparator mainMenuSeparator6;
        private ToolStripSeparator mainMenuSeparator7;
        private ToolStripSeparator mainMenuSeparator8;
        private ToolStripSeparator mainMenuSeparator9;
        private ToolStripSeparator mainMenuSeparator10;
        private ToolStripSeparator mainMenuSeparator11;
        private ToolStripSeparator toolStripSeparator13;

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private ColorDialog colorDialog;
    }
}