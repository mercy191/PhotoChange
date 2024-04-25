namespace PhotoChange.Controls
{
    partial class ColorCorrectionForm
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
            oldPictureBox = new PictureBox();
            newPictureBox = new PictureBox();
            brightnessTrackBar = new TrackBar();
            brightnessValueTextBox = new TextBox();
            brightnessGroupBox = new GroupBox();
            contrastGroupBox = new GroupBox();
            contrastValueTextBox = new TextBox();
            contrastTrackBar = new TrackBar();
            gammaGroupBox = new GroupBox();
            gammaValueTextBox = new TextBox();
            gammaTrackBar = new TrackBar();
            saturationGroupBox = new GroupBox();
            saturationValueTextBox = new TextBox();
            saturationTrackBar = new TrackBar();
            colorBalanceGroupBox = new GroupBox();
            BBalanceValueTextBox = new TextBox();
            GBalanceValueTextBox = new TextBox();
            GBalanceTrackBar = new TrackBar();
            RBalanceTrackBar = new TrackBar();
            BBalanceTrackBar = new TrackBar();
            RBalanceValueTextBox = new TextBox();
            OKButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)oldPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brightnessTrackBar).BeginInit();
            brightnessGroupBox.SuspendLayout();
            contrastGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contrastTrackBar).BeginInit();
            gammaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gammaTrackBar).BeginInit();
            saturationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saturationTrackBar).BeginInit();
            colorBalanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GBalanceTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RBalanceTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BBalanceTrackBar).BeginInit();
            SuspendLayout();
            // 
            // oldPictureBox
            // 
            oldPictureBox.BorderStyle = BorderStyle.Fixed3D;
            oldPictureBox.Location = new Point(31, 52);
            oldPictureBox.Name = "oldPictureBox";
            oldPictureBox.Size = new Size(255, 165);
            oldPictureBox.TabIndex = 0;
            oldPictureBox.TabStop = false;
            // 
            // newPictureBox
            // 
            newPictureBox.BorderStyle = BorderStyle.Fixed3D;
            newPictureBox.Location = new Point(307, 52);
            newPictureBox.Name = "newPictureBox";
            newPictureBox.Size = new Size(255, 165);
            newPictureBox.TabIndex = 1;
            newPictureBox.TabStop = false;
            // 
            // brightnessTrackBar
            // 
            brightnessTrackBar.AllowDrop = true;
            brightnessTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            brightnessTrackBar.Location = new Point(6, 16);
            brightnessTrackBar.Maximum = 255;
            brightnessTrackBar.Minimum = -255;
            brightnessTrackBar.Name = "brightnessTrackBar";
            brightnessTrackBar.Size = new Size(198, 45);
            brightnessTrackBar.TabIndex = 2;
            brightnessTrackBar.TickFrequency = 0;
            brightnessTrackBar.TickStyle = TickStyle.None;
            brightnessTrackBar.Scroll += BrightnessTrackBar_Scroll;
            // 
            // brightnessValueTextBox
            // 
            brightnessValueTextBox.Location = new Point(210, 16);
            brightnessValueTextBox.Name = "brightnessValueTextBox";
            brightnessValueTextBox.Size = new Size(31, 23);
            brightnessValueTextBox.TabIndex = 3;
            brightnessValueTextBox.Text = "0";
            // 
            // brightnessGroupBox
            // 
            brightnessGroupBox.Controls.Add(brightnessValueTextBox);
            brightnessGroupBox.Controls.Add(brightnessTrackBar);
            brightnessGroupBox.Location = new Point(31, 236);
            brightnessGroupBox.Name = "brightnessGroupBox";
            brightnessGroupBox.Size = new Size(255, 67);
            brightnessGroupBox.TabIndex = 4;
            brightnessGroupBox.TabStop = false;
            brightnessGroupBox.Text = "Brightness";
            // 
            // contrastGroupBox
            // 
            contrastGroupBox.Controls.Add(contrastValueTextBox);
            contrastGroupBox.Controls.Add(contrastTrackBar);
            contrastGroupBox.Location = new Point(307, 236);
            contrastGroupBox.Name = "contrastGroupBox";
            contrastGroupBox.Size = new Size(255, 67);
            contrastGroupBox.TabIndex = 5;
            contrastGroupBox.TabStop = false;
            contrastGroupBox.Text = "Contrast";
            // 
            // contrastValueTextBox
            // 
            contrastValueTextBox.Location = new Point(210, 16);
            contrastValueTextBox.Name = "contrastValueTextBox";
            contrastValueTextBox.Size = new Size(31, 23);
            contrastValueTextBox.TabIndex = 3;
            contrastValueTextBox.Text = "0";
            // 
            // contrastTrackBar
            // 
            contrastTrackBar.AllowDrop = true;
            contrastTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contrastTrackBar.Location = new Point(6, 16);
            contrastTrackBar.Maximum = 127;
            contrastTrackBar.Minimum = -127;
            contrastTrackBar.Name = "contrastTrackBar";
            contrastTrackBar.Size = new Size(198, 45);
            contrastTrackBar.TabIndex = 3;
            contrastTrackBar.TickFrequency = 0;
            contrastTrackBar.TickStyle = TickStyle.None;
            contrastTrackBar.Scroll += ContrastTrackBar_Scroll;
            // 
            // gammaGroupBox
            // 
            gammaGroupBox.Controls.Add(gammaValueTextBox);
            gammaGroupBox.Controls.Add(gammaTrackBar);
            gammaGroupBox.Location = new Point(307, 317);
            gammaGroupBox.Name = "gammaGroupBox";
            gammaGroupBox.Size = new Size(255, 69);
            gammaGroupBox.TabIndex = 6;
            gammaGroupBox.TabStop = false;
            gammaGroupBox.Text = "Gamma";
            // 
            // gammaValueTextBox
            // 
            gammaValueTextBox.Location = new Point(210, 21);
            gammaValueTextBox.Name = "gammaValueTextBox";
            gammaValueTextBox.Size = new Size(31, 23);
            gammaValueTextBox.TabIndex = 3;
            gammaValueTextBox.Text = "1.00";
            // 
            // gammaTrackBar
            // 
            gammaTrackBar.AllowDrop = true;
            gammaTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gammaTrackBar.Location = new Point(6, 21);
            gammaTrackBar.Maximum = 699;
            gammaTrackBar.Minimum = 1;
            gammaTrackBar.Name = "gammaTrackBar";
            gammaTrackBar.Size = new Size(198, 45);
            gammaTrackBar.TabIndex = 3;
            gammaTrackBar.TickFrequency = 0;
            gammaTrackBar.TickStyle = TickStyle.None;
            gammaTrackBar.Value = 100;
            gammaTrackBar.Scroll += GammaTrackBar_Scroll;
            // 
            // saturationGroupBox
            // 
            saturationGroupBox.Controls.Add(saturationValueTextBox);
            saturationGroupBox.Controls.Add(saturationTrackBar);
            saturationGroupBox.Location = new Point(307, 420);
            saturationGroupBox.Name = "saturationGroupBox";
            saturationGroupBox.Size = new Size(255, 69);
            saturationGroupBox.TabIndex = 7;
            saturationGroupBox.TabStop = false;
            saturationGroupBox.Text = "Saturation";
            // 
            // saturationValueTextBox
            // 
            saturationValueTextBox.Location = new Point(210, 22);
            saturationValueTextBox.Name = "saturationValueTextBox";
            saturationValueTextBox.Size = new Size(31, 23);
            saturationValueTextBox.TabIndex = 3;
            saturationValueTextBox.Text = "0";
            // 
            // saturationTrackBar
            // 
            saturationTrackBar.AllowDrop = true;
            saturationTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saturationTrackBar.Location = new Point(6, 18);
            saturationTrackBar.Maximum = 255;
            saturationTrackBar.Minimum = -255;
            saturationTrackBar.Name = "saturationTrackBar";
            saturationTrackBar.Size = new Size(198, 45);
            saturationTrackBar.TabIndex = 3;
            saturationTrackBar.TickFrequency = 0;
            saturationTrackBar.TickStyle = TickStyle.None;
            saturationTrackBar.Value = 1;
            saturationTrackBar.Scroll += SaturationTrackBar_Scroll;
            // 
            // colorBalanceGroupBox
            // 
            colorBalanceGroupBox.Controls.Add(BBalanceValueTextBox);
            colorBalanceGroupBox.Controls.Add(GBalanceValueTextBox);
            colorBalanceGroupBox.Controls.Add(GBalanceTrackBar);
            colorBalanceGroupBox.Controls.Add(RBalanceTrackBar);
            colorBalanceGroupBox.Controls.Add(BBalanceTrackBar);
            colorBalanceGroupBox.Controls.Add(RBalanceValueTextBox);
            colorBalanceGroupBox.Location = new Point(31, 317);
            colorBalanceGroupBox.Name = "colorBalanceGroupBox";
            colorBalanceGroupBox.Size = new Size(255, 172);
            colorBalanceGroupBox.TabIndex = 8;
            colorBalanceGroupBox.TabStop = false;
            colorBalanceGroupBox.Text = "Color balance";
            // 
            // BBalanceValueTextBox
            // 
            BBalanceValueTextBox.Location = new Point(210, 119);
            BBalanceValueTextBox.Name = "BBalanceValueTextBox";
            BBalanceValueTextBox.Size = new Size(31, 23);
            BBalanceValueTextBox.TabIndex = 9;
            BBalanceValueTextBox.Text = "0";
            // 
            // GBalanceValueTextBox
            // 
            GBalanceValueTextBox.Location = new Point(210, 73);
            GBalanceValueTextBox.Name = "GBalanceValueTextBox";
            GBalanceValueTextBox.Size = new Size(31, 23);
            GBalanceValueTextBox.TabIndex = 9;
            GBalanceValueTextBox.Text = "0";
            // 
            // GBalanceTrackBar
            // 
            GBalanceTrackBar.AllowDrop = true;
            GBalanceTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GBalanceTrackBar.LargeChange = 1;
            GBalanceTrackBar.Location = new Point(6, 73);
            GBalanceTrackBar.Maximum = 255;
            GBalanceTrackBar.Minimum = -255;
            GBalanceTrackBar.Name = "GBalanceTrackBar";
            GBalanceTrackBar.Size = new Size(198, 45);
            GBalanceTrackBar.TabIndex = 9;
            GBalanceTrackBar.TickFrequency = 0;
            GBalanceTrackBar.TickStyle = TickStyle.None;
            GBalanceTrackBar.Scroll += GBalanceTrackBar_Scroll;
            // 
            // RBalanceTrackBar
            // 
            RBalanceTrackBar.AllowDrop = true;
            RBalanceTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RBalanceTrackBar.LargeChange = 1;
            RBalanceTrackBar.Location = new Point(6, 28);
            RBalanceTrackBar.Maximum = 255;
            RBalanceTrackBar.Minimum = -255;
            RBalanceTrackBar.Name = "RBalanceTrackBar";
            RBalanceTrackBar.Size = new Size(198, 45);
            RBalanceTrackBar.TabIndex = 11;
            RBalanceTrackBar.TickFrequency = 0;
            RBalanceTrackBar.TickStyle = TickStyle.None;
            RBalanceTrackBar.Scroll += RBalanceTrackBar_Scroll;
            // 
            // BBalanceTrackBar
            // 
            BBalanceTrackBar.AllowDrop = true;
            BBalanceTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BBalanceTrackBar.LargeChange = 1;
            BBalanceTrackBar.Location = new Point(6, 119);
            BBalanceTrackBar.Maximum = 255;
            BBalanceTrackBar.Minimum = -255;
            BBalanceTrackBar.Name = "BBalanceTrackBar";
            BBalanceTrackBar.Size = new Size(198, 45);
            BBalanceTrackBar.TabIndex = 10;
            BBalanceTrackBar.TickFrequency = 0;
            BBalanceTrackBar.TickStyle = TickStyle.None;
            BBalanceTrackBar.Scroll += BBalanceTrackBar_Scroll;
            // 
            // RBalanceValueTextBox
            // 
            RBalanceValueTextBox.Location = new Point(210, 28);
            RBalanceValueTextBox.Name = "RBalanceValueTextBox";
            RBalanceValueTextBox.Size = new Size(31, 23);
            RBalanceValueTextBox.TabIndex = 12;
            RBalanceValueTextBox.Text = "0";
            // 
            // OKButton
            // 
            OKButton.Location = new Point(206, 518);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(78, 23);
            OKButton.TabIndex = 9;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(313, 518);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(78, 23);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // ColorCorrectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 558);
            Controls.Add(cancelButton);
            Controls.Add(OKButton);
            Controls.Add(colorBalanceGroupBox);
            Controls.Add(saturationGroupBox);
            Controls.Add(gammaGroupBox);
            Controls.Add(contrastGroupBox);
            Controls.Add(brightnessGroupBox);
            Controls.Add(newPictureBox);
            Controls.Add(oldPictureBox);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ColorCorrectionForm";
            Text = "ColorCorrectionForm";
            ((System.ComponentModel.ISupportInitialize)oldPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)newPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)brightnessTrackBar).EndInit();
            brightnessGroupBox.ResumeLayout(false);
            brightnessGroupBox.PerformLayout();
            contrastGroupBox.ResumeLayout(false);
            contrastGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contrastTrackBar).EndInit();
            gammaGroupBox.ResumeLayout(false);
            gammaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gammaTrackBar).EndInit();
            saturationGroupBox.ResumeLayout(false);
            saturationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saturationTrackBar).EndInit();
            colorBalanceGroupBox.ResumeLayout(false);
            colorBalanceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GBalanceTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RBalanceTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BBalanceTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox oldPictureBox;
        private PictureBox newPictureBox;
        private TrackBar brightnessTrackBar;
        private TextBox brightnessValueTextBox;
        private GroupBox brightnessGroupBox;
        private GroupBox contrastGroupBox;
        private TextBox contrastValueTextBox;
        private TrackBar contrastTrackBar;
        private GroupBox gammaGroupBox;
        private TextBox gammaValueTextBox;
        private TrackBar gammaTrackBar;
        private GroupBox saturationGroupBox;
        private TextBox saturationValueTextBox;
        private TrackBar saturationTrackBar;
        private GroupBox colorBalanceGroupBox;
        private TextBox BBalanceValueTextBox;
        private TextBox GBalanceValueTextBox;
        private TextBox RBalanceValueTextBox;
        private TrackBar RBalanceTrackBar;
        private TrackBar BBalanceTrackBar;
        private TrackBar GBalanceTrackBar;
        private Button OKButton;
        private Button cancelButton;
    }
}