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
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
            this.Text = "End Screen of Death";
        }

        private void btnYesRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExitRestart_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
