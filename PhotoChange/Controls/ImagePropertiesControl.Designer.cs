namespace PhotoChange.Controls
{
    partial class ImagePropertiesControl
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
            panel1 = new Panel();
            dateTimeTextBox = new TextBox();
            dateTimeLabel = new Label();
            fileSizeTextBox = new TextBox();
            fileSizeLable = new Label();
            imageSizeTextBox = new TextBox();
            imageSizeLabel = new Label();
            fullPathTextBox = new TextBox();
            fullPathLabel = new Label();
            directoryTextBox = new TextBox();
            directoryLabel = new Label();
            fileNameTextBox = new TextBox();
            fileNameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimeTextBox);
            panel1.Controls.Add(dateTimeLabel);
            panel1.Controls.Add(fileSizeTextBox);
            panel1.Controls.Add(fileSizeLable);
            panel1.Controls.Add(imageSizeTextBox);
            panel1.Controls.Add(imageSizeLabel);
            panel1.Controls.Add(fullPathTextBox);
            panel1.Controls.Add(fullPathLabel);
            panel1.Controls.Add(directoryTextBox);
            panel1.Controls.Add(directoryLabel);
            panel1.Controls.Add(fileNameTextBox);
            panel1.Controls.Add(fileNameLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 199);
            panel1.TabIndex = 0;
            // 
            // dateTimeTextBox
            // 
            dateTimeTextBox.Location = new Point(115, 155);
            dateTimeTextBox.Name = "dateTimeTextBox";
            dateTimeTextBox.ReadOnly = true;
            dateTimeTextBox.Size = new Size(126, 23);
            dateTimeTextBox.TabIndex = 11;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new Point(17, 158);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(84, 15);
            dateTimeLabel.TabIndex = 10;
            dateTimeLabel.Text = "Date and time:";
            // 
            // fileSizeTextBox
            // 
            fileSizeTextBox.Location = new Point(115, 126);
            fileSizeTextBox.Name = "fileSizeTextBox";
            fileSizeTextBox.ReadOnly = true;
            fileSizeTextBox.Size = new Size(126, 23);
            fileSizeTextBox.TabIndex = 9;
            // 
            // fileSizeLable
            // 
            fileSizeLable.AutoSize = true;
            fileSizeLable.Location = new Point(17, 129);
            fileSizeLable.Name = "fileSizeLable";
            fileSizeLable.Size = new Size(50, 15);
            fileSizeLable.TabIndex = 8;
            fileSizeLable.Text = "File size:";
            // 
            // imageSizeTextBox
            // 
            imageSizeTextBox.Location = new Point(115, 97);
            imageSizeTextBox.Name = "imageSizeTextBox";
            imageSizeTextBox.ReadOnly = true;
            imageSizeTextBox.Size = new Size(126, 23);
            imageSizeTextBox.TabIndex = 7;
            // 
            // imageSizeLabel
            // 
            imageSizeLabel.AutoSize = true;
            imageSizeLabel.Location = new Point(17, 100);
            imageSizeLabel.Name = "imageSizeLabel";
            imageSizeLabel.Size = new Size(65, 15);
            imageSizeLabel.TabIndex = 6;
            imageSizeLabel.Text = "Image size:";
            // 
            // fullPathTextBox
            // 
            fullPathTextBox.Location = new Point(115, 68);
            fullPathTextBox.Name = "fullPathTextBox";
            fullPathTextBox.ReadOnly = true;
            fullPathTextBox.Size = new Size(126, 23);
            fullPathTextBox.TabIndex = 5;
            // 
            // fullPathLabel
            // 
            fullPathLabel.AutoSize = true;
            fullPathLabel.Location = new Point(17, 71);
            fullPathLabel.Name = "fullPathLabel";
            fullPathLabel.Size = new Size(56, 15);
            fullPathLabel.TabIndex = 4;
            fullPathLabel.Text = "Full path:";
            // 
            // directoryTextBox
            // 
            directoryTextBox.Location = new Point(115, 39);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.ReadOnly = true;
            directoryTextBox.Size = new Size(126, 23);
            directoryTextBox.TabIndex = 3;
            // 
            // directoryLabel
            // 
            directoryLabel.AutoSize = true;
            directoryLabel.Location = new Point(17, 42);
            directoryLabel.Name = "directoryLabel";
            directoryLabel.Size = new Size(58, 15);
            directoryLabel.TabIndex = 2;
            directoryLabel.Text = "Directory:";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(115, 10);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.ReadOnly = true;
            fileNameTextBox.Size = new Size(126, 23);
            fileNameTextBox.TabIndex = 1;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(17, 13);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(61, 15);
            fileNameLabel.TabIndex = 0;
            fileNameLabel.Text = "File name:";
            // 
            // ImagePropertiesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ImagePropertiesControl";
            Size = new Size(257, 199);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox dateTimeTextBox;
        private Label dateTimeLabel;
        private TextBox fileSizeTextBox;
        private Label fileSizeLable;
        private TextBox imageSizeTextBox;
        private Label imageSizeLabel;
        private TextBox fullPathTextBox;
        private Label fullPathLabel;
        private TextBox directoryTextBox;
        private Label directoryLabel;
        private TextBox fileNameTextBox;
        private Label fileNameLabel;
    }
}
