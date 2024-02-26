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
        public string ai = "";
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

        private void aiPlayer(string player)
        {
            Random random = new Random();

            int grid = random.Next(1, 10);
            
            lblTemp.Text = grid.ToString();

            if (player == "X")
            {
                ai = "O";
            }
            else if (player == "O")
            {
                ai = "X";
            }

            switch (grid)
            {
                case 1:
                    if (btnGrid1.Text == null) 
                    {
                        btnGrid1.Text = ai;
                    }
                    break;

                case 2:
                    if (btnGrid2.Text == null)
                    {
                        btnGrid2.Text = ai;
                    }
                    break;

                case 3:
                    if (btnGrid3.Text == null)
                    {
                        btnGrid3.Text = ai;
                    }
                    break;

                case 4:
                    if (btnGrid4.Text == null)
                    {
                        btnGrid4.Text = ai;
                    }
                    break;

                case 5:
                    if (btnGrid5.Text == null)
                    {
                        btnGrid5.Text = ai;
                    }
                    break;

                case 6:
                    if (btnGrid6.Text == null)
                    {
                        btnGrid6.Text = ai;
                    }
                    break;

                case 7:
                    if (btnGrid7.Text == null)
                    {
                        btnGrid7.Text = ai;
                    }
                    break;

                case 8:
                    if (btnGrid8.Text == null)
                    {
                        btnGrid8.Text = ai;
                    }
                    break;

                case 9:
                    if (btnGrid9.Text == null)
                    {
                        btnGrid9.Text = ai;
                    }
                    break;
            }
        }

        //----------------------------------------------------------------------------------------//
        /// <summary>
        /// This is the button controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnGrid1_Click(object sender, EventArgs e)
        {
            btnGrid1.Text = player;
            aiPlayer(player);
        }

        private void btnGrid2_Click(object sender, EventArgs e)
        {
            btnGrid2.Text = player;
        }

        private void btnGrid3_Click(object sender, EventArgs e)
        {
            btnGrid3.Text = player;
        }

        private void btnGrid4_Click(object sender, EventArgs e)
        {
            btnGrid4.Text = player;
        }

        private void btnGrid5_Click(object sender, EventArgs e)
        {
            btnGrid5.Text = player;
        }

        private void btnGrid6_Click(object sender, EventArgs e)
        {
            btnGrid6.Text = player;
        }

        private void btnGrid7_Click(object sender, EventArgs e)
        {
            btnGrid7.Text = player;
        }

        private void btnGrid8_Click(object sender, EventArgs e)
        {
            btnGrid8.Text = player;
        }

        private void btnGrid9_Click(object sender, EventArgs e)
        {
            btnGrid9.Text = player;
        }
    }
}
