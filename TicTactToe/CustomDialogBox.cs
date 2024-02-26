using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTactToe
{
    public partial class CustomDialogBox : Form
    {
        public CustomDialogBox()
        {
            InitializeComponent();
            this.Text = "Life Threatening Decision!!";
        }

        private void btnXChoice_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnOChoice_Click(object sender, EventArgs e)
        {
            this.DialogResult |= DialogResult.No;
        }
    }
}
