using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TicTactToe
{
    public partial class Form1 : Form
    {
        public string player = "";
        public Form1()
        {
            InitializeComponent();

            CustomDialogBox customDialogBox = new CustomDialogBox();
            DialogResult dialogResult = customDialogBox.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                player = "X";
            }
            else if (dialogResult == DialogResult.No)
            {
                player = "O";
            }
        }

        private void btnGrid1_Click(object sender, EventArgs e)
        {
            btnGrid1.Text = player;
        }

        private void btnGrid2_Click(object sender, EventArgs e)
        {

        }

        private void btnGrid3_Click(object sender, EventArgs e)
        {

        }

        private void btnGrid4_Click(object sender, EventArgs e)
        {

        }

        private void btnGrid5_Click(object sender, EventArgs e)
        {

        }

        private void btnGrid6_Click(object sender, EventArgs e)
        {

        }

        private void btnGrid7_Click(object sender, EventArgs e)
        {

        }

        private void btnGrid8_Click(object sender, EventArgs e)
        {

        }

        private void btnGrid9_Click(object sender, EventArgs e)
        {

        }
    }
}
