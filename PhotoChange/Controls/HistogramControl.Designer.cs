namespace PhotoChange.Controls
{
    partial class HistogramControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            histogramPictureBox = new PictureBox();
            blueNumbersLabel = new Label();
            greenNumbersLabel = new Label();
            redNumbersLabel = new Label();
            grayNumbersLabel = new Label();
            blueLabel = new Label();
            greenLabel = new Label();
            redLabel = new Label();
            grayLabel = new Label();
            pixelsLabel = new Label();
            totalPixelsNumbersLabel = new Label();
            totalPixelsLabel = new Label();
            indexNumberLabel = new Label();
            indexLabel = new Label();
            grayCheckBox = new CheckBox();
            blueCheckBox = new CheckBox();
            greenCheckBox = new CheckBox();
            redCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)histogramPictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(histogramPictureBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(blueNumbersLabel);
            splitContainer.Panel2.Controls.Add(greenNumbersLabel);
            splitContainer.Panel2.Controls.Add(redNumbersLabel);
            splitContainer.Panel2.Controls.Add(grayNumbersLabel);
            splitContainer.Panel2.Controls.Add(blueLabel);
            splitContainer.Panel2.Controls.Add(greenLabel);
            splitContainer.Panel2.Controls.Add(redLabel);
            splitContainer.Panel2.Controls.Add(grayLabel);
            splitContainer.Panel2.Controls.Add(pixelsLabel);
            splitContainer.Panel2.Controls.Add(totalPixelsNumbersLabel);
            splitContainer.Panel2.Controls.Add(totalPixelsLabel);
            splitContainer.Panel2.Controls.Add(indexNumberLabel);
            splitContainer.Panel2.Controls.Add(indexLabel);
            splitContainer.Panel2.Controls.Add(grayCheckBox);
            splitContainer.Panel2.Controls.Add(blueCheckBox);
            splitContainer.Panel2.Controls.Add(greenCheckBox);
            splitContainer.Panel2.Controls.Add(redCheckBox);
            splitContainer.Size = new Size(260, 225);
            splitContainer.SplitterDistance = 110;
            splitContainer.TabIndex = 0;
            // 
            // histogramPictureBox
            // 
            histogramPictureBox.Dock = DockStyle.Fill;
            histogramPictureBox.Location = new Point(0, 0);
            histogramPictureBox.Name = "histogramPictureBox";
            histogramPictureBox.Size = new Size(260, 110);
            histogramPictureBox.TabIndex = 0;
            histogramPictureBox.TabStop = false;
            histogramPictureBox.MouseMove += HistogramPictureBox_MouseMove;
            // 
            // blueNumbersLabel
            // 
            blueNumbersLabel.AutoSize = true;
            blueNumbersLabel.Location = new Point(198, 90);
            blueNumbersLabel.Name = "blueNumbersLabel";
            blueNumbersLabel.Size = new Size(0, 15);
            blueNumbersLabel.TabIndex = 16;
            // 
            // greenNumbersLabel
            // 
            greenNumbersLabel.AutoSize = true;
            greenNumbersLabel.Location = new Point(149, 90);
            greenNumbersLabel.Name = "greenNumbersLabel";
            greenNumbersLabel.Size = new Size(0, 15);
            greenNumbersLabel.TabIndex = 15;
            // 
            // redNumbersLabel
            // 
            redNumbersLabel.AutoSize = true;
            redNumbersLabel.Location = new Point(107, 89);
            redNumbersLabel.Name = "redNumbersLabel";
            redNumbersLabel.Size = new Size(0, 15);
            redNumbersLabel.TabIndex = 14;
            // 
            // grayNumbersLabel
            // 
            grayNumbersLabel.AutoSize = true;
            grayNumbersLabel.Location = new Point(61, 89);
            grayNumbersLabel.Name = "grayNumbersLabel";
            grayNumbersLabel.Size = new Size(0, 15);
            grayNumbersLabel.TabIndex = 13;
            // 
            // blueLabel
            // 
            blueLabel.AutoSize = true;
            blueLabel.Location = new Point(193, 60);
            blueLabel.Name = "blueLabel";
            blueLabel.Size = new Size(30, 15);
            blueLabel.TabIndex = 12;
            blueLabel.Text = "Blue";
            // 
            // greenLabel
            // 
            greenLabel.AutoSize = true;
            greenLabel.Location = new Point(149, 60);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new Size(38, 15);
            greenLabel.TabIndex = 11;
            greenLabel.Text = "Green";
            // 
            // redLabel
            // 
            redLabel.AutoSize = true;
            redLabel.Location = new Point(107, 60);
            redLabel.Name = "redLabel";
            redLabel.Size = new Size(27, 15);
            redLabel.TabIndex = 10;
            redLabel.Text = "Red";
            // 
            // grayLabel
            // 
            grayLabel.AutoSize = true;
            grayLabel.Location = new Point(61, 60);
            grayLabel.Name = "grayLabel";
            grayLabel.Size = new Size(31, 15);
            grayLabel.TabIndex = 9;
            grayLabel.Text = "Gray";
            // 
            // pixelsLabel
            // 
            pixelsLabel.AutoSize = true;
            pixelsLabel.Location = new Point(15, 60);
            pixelsLabel.Name = "pixelsLabel";
            pixelsLabel.Size = new Size(40, 15);
            pixelsLabel.TabIndex = 8;
            pixelsLabel.Text = "Pixels:";
            // 
            // totalPixelsNumbersLabel
            // 
            totalPixelsNumbersLabel.AutoSize = true;
            totalPixelsNumbersLabel.Location = new Point(178, 35);
            totalPixelsNumbersLabel.Name = "totalPixelsNumbersLabel";
            totalPixelsNumbersLabel.Size = new Size(0, 15);
            totalPixelsNumbersLabel.TabIndex = 7;
            // 
            // totalPixelsLabel
            // 
            totalPixelsLabel.AutoSize = true;
            totalPixelsLabel.Location = new Point(95, 35);
            totalPixelsLabel.Name = "totalPixelsLabel";
            totalPixelsLabel.Size = new Size(68, 15);
            totalPixelsLabel.TabIndex = 6;
            totalPixelsLabel.Text = "Total pixels:";
            // 
            // indexNumberLabel
            // 
            indexNumberLabel.AutoSize = true;
            indexNumberLabel.Location = new Point(60, 35);
            indexNumberLabel.Name = "indexNumberLabel";
            indexNumberLabel.Size = new Size(0, 15);
            indexNumberLabel.TabIndex = 5;
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Location = new Point(15, 35);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new Size(39, 15);
            indexLabel.TabIndex = 4;
            indexLabel.Text = "Index:";
            // 
            // grayCheckBox
            // 
            grayCheckBox.AutoSize = true;
            grayCheckBox.Location = new Point(202, 13);
            grayCheckBox.Name = "grayCheckBox";
            grayCheckBox.Size = new Size(50, 19);
            grayCheckBox.TabIndex = 3;
            grayCheckBox.Text = "Gray";
            grayCheckBox.UseVisualStyleBackColor = true;
            grayCheckBox.Click += GrayCheckBox_Click;
            // 
            // blueCheckBox
            // 
            blueCheckBox.AutoSize = true;
            blueCheckBox.Location = new Point(147, 13);
            blueCheckBox.Name = "blueCheckBox";
            blueCheckBox.Size = new Size(49, 19);
            blueCheckBox.TabIndex = 2;
            blueCheckBox.Text = "Blue";
            blueCheckBox.UseVisualStyleBackColor = true;
            blueCheckBox.Click += BlueCheckBox_Click;
            // 
            // greenCheckBox
            // 
            greenCheckBox.AutoSize = true;
            greenCheckBox.Location = new Point(84, 13);
            greenCheckBox.Name = "greenCheckBox";
            greenCheckBox.Size = new Size(57, 19);
            greenCheckBox.TabIndex = 1;
            greenCheckBox.Text = "Green";
            greenCheckBox.UseVisualStyleBackColor = true;
            greenCheckBox.Click += GreenCheckBox_Click;
            // 
            // redCheckBox
            // 
            redCheckBox.AutoSize = true;
            redCheckBox.Location = new Point(32, 13);
            redCheckBox.Name = "redCheckBox";
            redCheckBox.Size = new Size(46, 19);
            redCheckBox.TabIndex = 0;
            redCheckBox.Text = "Red";
            redCheckBox.UseVisualStyleBackColor = true;
            redCheckBox.Click += RedCheckBox_Click;
            // 
            // HistogramControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(splitContainer);
            DoubleBuffered = true;
            Name = "HistogramControl";
            Size = new Size(260, 225);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)histogramPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private PictureBox histogramPictureBox;
        private CheckBox grayCheckBox;
        private CheckBox blueCheckBox;
        private CheckBox greenCheckBox;
        private CheckBox redCheckBox;
        private Label indexLabel;
        private Label indexNumberLabel;
        private Label totalPixelsLabel;
        private Label totalPixelsNumbersLabel;
        private Label blueLabel;
        private Label greenLabel;
        private Label redLabel;
        private Label grayLabel;
        private Label pixelsLabel;
        private Label redNumbersLabel;
        private Label grayNumbersLabel;
        private Label blueNumbersLabel;
        private Label greenNumbersLabel;
    }
}
