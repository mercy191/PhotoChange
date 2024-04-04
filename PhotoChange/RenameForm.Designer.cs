namespace PhotoChange
{
    partial class RenameForm
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
            newNameLabel = new Label();
            newNameTextBox = new TextBox();
            expansionLabel = new Label();
            NewExpansionTextBox = new TextBox();
            OkCopyFormButton = new Button();
            CancelCopyFormButton = new Button();
            SuspendLayout();
            // 
            // newNameLabel
            // 
            newNameLabel.AutoSize = true;
            newNameLabel.Location = new Point(27, 27);
            newNameLabel.Name = "newNameLabel";
            newNameLabel.Size = new Size(67, 15);
            newNameLabel.TabIndex = 0;
            newNameLabel.Text = "New name:";
            // 
            // newNameTextBox
            // 
            newNameTextBox.Location = new Point(27, 54);
            newNameTextBox.Name = "newNameTextBox";
            newNameTextBox.Size = new Size(435, 23);
            newNameTextBox.TabIndex = 1;
            // 
            // expansionLabel
            // 
            expansionLabel.AutoSize = true;
            expansionLabel.Location = new Point(27, 114);
            expansionLabel.Name = "expansionLabel";
            expansionLabel.Size = new Size(61, 15);
            expansionLabel.TabIndex = 2;
            expansionLabel.Text = "Expansion";
            // 
            // NewExpansionTextBox
            // 
            NewExpansionTextBox.Location = new Point(27, 149);
            NewExpansionTextBox.Name = "NewExpansionTextBox";
            NewExpansionTextBox.Size = new Size(138, 23);
            NewExpansionTextBox.TabIndex = 3;
            // 
            // OkCopyFormButton
            // 
            OkCopyFormButton.Location = new Point(137, 191);
            OkCopyFormButton.Name = "OkCopyFormButton";
            OkCopyFormButton.Size = new Size(75, 23);
            OkCopyFormButton.TabIndex = 4;
            OkCopyFormButton.Text = "OK";
            OkCopyFormButton.UseVisualStyleBackColor = true;
            OkCopyFormButton.Click += OkCopyFormButton_Click;
            // 
            // CancelCopyFormButton
            // 
            CancelCopyFormButton.Location = new Point(257, 191);
            CancelCopyFormButton.Name = "CancelCopyFormButton";
            CancelCopyFormButton.Size = new Size(75, 23);
            CancelCopyFormButton.TabIndex = 5;
            CancelCopyFormButton.Text = "Cancel";
            CancelCopyFormButton.UseVisualStyleBackColor = true;
            CancelCopyFormButton.Click += CancelCopyFormButton_Click;
            // 
            // RenameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 226);
            Controls.Add(CancelCopyFormButton);
            Controls.Add(OkCopyFormButton);
            Controls.Add(NewExpansionTextBox);
            Controls.Add(expansionLabel);
            Controls.Add(newNameTextBox);
            Controls.Add(newNameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RenameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rename";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newNameLabel;
        private TextBox newNameTextBox;
        private Label expansionLabel;
        private TextBox NewExpansionTextBox;
        private Button OkCopyFormButton;
        private Button CancelCopyFormButton;
    }
}