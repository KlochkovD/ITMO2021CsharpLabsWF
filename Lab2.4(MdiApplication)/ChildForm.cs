using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._4_MdiApplication_
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toggleForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                ToggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}
