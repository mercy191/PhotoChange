namespace PhotoChange.Controls
{
    partial class GlueImagesForm
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
            firstPanel = new Panel();
            firstPictureBox = new PictureBox();
            secondPanel = new Panel();
            secondPictureBox = new PictureBox();
            glueButton = new Button();
            thirdPanel = new Panel();
            thirdPictureBox = new PictureBox();
            leftIncreaseButton = new Button();
            leftReduceButton = new Button();
            rightReduceButton = new Button();
            rightIncreaseButton = new Button();
            downIncreaseButton = new Button();
            downReduceButton = new Button();
            upReduceButton = new Button();
            upIncreaseButton = new Button();
            OKButton = new Button();
            cancelButton = new Button();
            firstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)firstPictureBox).BeginInit();
            secondPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondPictureBox).BeginInit();
            thirdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thirdPictureBox).BeginInit();
            SuspendLayout();
            // 
            // firstPanel
            // 
            firstPanel.AutoScroll = true;
            firstPanel.Controls.Add(firstPictureBox);
            firstPanel.Location = new Point(12, 38);
            firstPanel.Name = "firstPanel";
            firstPanel.Size = new Size(500, 500);
            firstPanel.TabIndex = 0;
            // 
            // firstPictureBox
            // 
            firstPictureBox.Location = new Point(5, 4);
            firstPictureBox.Name = "firstPictureBox";
            firstPictureBox.Size = new Size(490, 490);
            firstPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            firstPictureBox.TabIndex = 0;
            firstPictureBox.TabStop = false;
            firstPictureBox.MouseClick += FirstPictureBox_MouseClick;
            // 
            // secondPanel
            // 
            secondPanel.AutoScroll = true;
            secondPanel.Controls.Add(secondPictureBox);
            secondPanel.Location = new Point(1144, 38);
            secondPanel.Name = "secondPanel";
            secondPanel.Size = new Size(500, 500);
            secondPanel.TabIndex = 1;
            // 
            // secondPictureBox
            // 
            secondPictureBox.Location = new Point(5, 4);
            secondPictureBox.Name = "secondPictureBox";
            secondPictureBox.Size = new Size(490, 490);
            secondPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            secondPictureBox.TabIndex = 1;
            secondPictureBox.TabStop = false;
            secondPictureBox.MouseClick += SecondPictureBox_MouseClick;
            // 
            // glueButton
            // 
            glueButton.Location = new Point(793, 571);
            glueButton.Name = "glueButton";
            glueButton.Size = new Size(75, 23);
            glueButton.TabIndex = 2;
            glueButton.Text = "Glue";
            glueButton.UseVisualStyleBackColor = true;
            glueButton.Click += GlueButton_Click;
            // 
            // thirdPanel
            // 
            thirdPanel.AutoScroll = true;
            thirdPanel.Controls.Add(thirdPictureBox);
            thirdPanel.Location = new Point(578, 38);
            thirdPanel.Name = "thirdPanel";
            thirdPanel.Size = new Size(500, 500);
            thirdPanel.TabIndex = 3;
            // 
            // thirdPictureBox
            // 
            thirdPictureBox.Location = new Point(4, 5);
            thirdPictureBox.Name = "thirdPictureBox";
            thirdPictureBox.Size = new Size(490, 490);
            thirdPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            thirdPictureBox.TabIndex = 1;
            thirdPictureBox.TabStop = false;
            // 
            // leftIncreaseButton
            // 
            leftIncreaseButton.Location = new Point(521, 274);
            leftIncreaseButton.Name = "leftIncreaseButton";
            leftIncreaseButton.Size = new Size(24, 23);
            leftIncreaseButton.TabIndex = 4;
            leftIncreaseButton.Text = "+";
            leftIncreaseButton.UseVisualStyleBackColor = true;
            leftIncreaseButton.Click += HorizontalButton_Click;
            // 
            // leftReduceButton
            // 
            leftReduceButton.Location = new Point(548, 274);
            leftReduceButton.Name = "leftReduceButton";
            leftReduceButton.Size = new Size(24, 23);
            leftReduceButton.TabIndex = 5;
            leftReduceButton.Text = "-";
            leftReduceButton.UseVisualStyleBackColor = true;
            leftReduceButton.Click += HorizontalButton_Click;
            // 
            // rightReduceButton
            // 
            rightReduceButton.Location = new Point(1084, 274);
            rightReduceButton.Name = "rightReduceButton";
            rightReduceButton.Size = new Size(24, 23);
            rightReduceButton.TabIndex = 6;
            rightReduceButton.Text = "-";
            rightReduceButton.UseVisualStyleBackColor = true;
            rightReduceButton.Click += HorizontalButton_Click;
            // 
            // rightIncreaseButton
            // 
            rightIncreaseButton.Location = new Point(1114, 274);
            rightIncreaseButton.Name = "rightIncreaseButton";
            rightIncreaseButton.Size = new Size(24, 23);
            rightIncreaseButton.TabIndex = 7;
            rightIncreaseButton.Text = "+";
            rightIncreaseButton.UseVisualStyleBackColor = true;
            rightIncreaseButton.Click += HorizontalButton_Click;
            // 
            // downIncreaseButton
            // 
            downIncreaseButton.Location = new Point(803, 544);
            downIncreaseButton.Name = "downIncreaseButton";
            downIncreaseButton.Size = new Size(24, 23);
            downIncreaseButton.TabIndex = 8;
            downIncreaseButton.Text = "+";
            downIncreaseButton.UseVisualStyleBackColor = true;
            downIncreaseButton.Click += VerticalButton_Click;
            // 
            // downReduceButton
            // 
            downReduceButton.Location = new Point(833, 544);
            downReduceButton.Name = "downReduceButton";
            downReduceButton.Size = new Size(24, 23);
            downReduceButton.TabIndex = 9;
            downReduceButton.Text = "-";
            downReduceButton.UseVisualStyleBackColor = true;
            downReduceButton.Click += VerticalButton_Click;
            // 
            // upReduceButton
            // 
            upReduceButton.Location = new Point(833, 9);
            upReduceButton.Name = "upReduceButton";
            upReduceButton.Size = new Size(24, 23);
            upReduceButton.TabIndex = 11;
            upReduceButton.Text = "-";
            upReduceButton.UseVisualStyleBackColor = true;
            upReduceButton.Click += VerticalButton_Click;
            // 
            // upIncreaseButton
            // 
            upIncreaseButton.Location = new Point(803, 9);
            upIncreaseButton.Name = "upIncreaseButton";
            upIncreaseButton.Size = new Size(24, 23);
            upIncreaseButton.TabIndex = 10;
            upIncreaseButton.Text = "+";
            upIncreaseButton.UseVisualStyleBackColor = true;
            upIncreaseButton.Click += VerticalButton_Click;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(738, 610);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 12;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(850, 610);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // GlueImagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1656, 645);
            Controls.Add(cancelButton);
            Controls.Add(OKButton);
            Controls.Add(upReduceButton);
            Controls.Add(upIncreaseButton);
            Controls.Add(downReduceButton);
            Controls.Add(downIncreaseButton);
            Controls.Add(rightIncreaseButton);
            Controls.Add(rightReduceButton);
            Controls.Add(leftReduceButton);
            Controls.Add(leftIncreaseButton);
            Controls.Add(thirdPanel);
            Controls.Add(glueButton);
            Controls.Add(secondPanel);
            Controls.Add(firstPanel);
            KeyPreview = true;
            Name = "GlueImagesForm";
            Text = "GlueImagesForm";
            firstPanel.ResumeLayout(false);
            firstPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)firstPictureBox).EndInit();
            secondPanel.ResumeLayout(false);
            secondPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secondPictureBox).EndInit();
            thirdPanel.ResumeLayout(false);
            thirdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thirdPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel firstPanel;
        private Panel secondPanel;
        private PictureBox firstPictureBox;
        private PictureBox secondPictureBox;
        private Button glueButton;
        private Panel thirdPanel;
        private PictureBox thirdPictureBox;
        private Button leftIncreaseButton;
        private Button leftReduceButton;
        private Button rightReduceButton;
        private Button rightIncreaseButton;
        private Button downIncreaseButton;
        private Button downReduceButton;
        private Button upReduceButton;
        private Button upIncreaseButton;
        private Button OKButton;
        private Button cancelButton;
    }
}