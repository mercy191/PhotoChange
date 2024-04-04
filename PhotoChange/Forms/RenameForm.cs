using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoChange
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        private void OkCopyFormButton_Click(object? sender, EventArgs e)
        { 
            MainForm.NewName = newNameTextBox.Text;
            MainForm.NewExpansion = NewExpansionTextBox.Text;
            Close();
        }

        private void CancelCopyFormButton_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
