using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoChange.Controls
{
    public partial class ImagePropertiesControl : UserControl
    {
        public string FileName { set => fileNameTextBox.Text = value; }

        public string Directory { set => directoryTextBox.Text = value; }

        public string FullPath { set => fullPathTextBox.Text = value; }

        public string ImageSize { set => imageSizeTextBox.Text = value; }

        public string FileSize { set => fileSizeTextBox.Text = value; }

        public string DateTime { set => dateTimeTextBox.Text = value; }

        public ImagePropertiesControl()
        {
            InitializeComponent();
        }

    }
}
