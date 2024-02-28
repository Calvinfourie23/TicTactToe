using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TicTactToe
{
    public partial class Form1 : Form
    {
        public int count = 0;
        public string player = "";
        public Form1()
        {
            InitializeComponent();
            DisableGame();
        }

        private void WinCheck(string player)
        {
            string winner = "";

            //Horizontal WinCheck
            if (this.btnGrid1.Text == this.btnGrid2.Text && this.btnGrid2.Text == this.btnGrid3.Text && this.btnGrid1.Text != "")
            {
                winner = this.btnGrid1.Text;
            }
            else if (this.btnGrid4.Text == this.btnGrid5.Text && this.btnGrid5.Text == this.btnGrid6.Text && this.btnGrid4.Text != "")
            {
                winner = this.btnGrid4.Text;
            }
            else if (this.btnGrid7.Text == this.btnGrid8.Text && this.btnGrid8.Text == this.btnGrid9.Text && this.btnGrid7.Text != "")
            {
                winner = this.btnGrid7.Text;
            }

            //Vertical WinCheck
            else if (this.btnGrid1.Text == this.btnGrid4.Text && this.btnGrid4.Text == this.btnGrid7.Text && this.btnGrid1.Text != "")
            {
                winner = this.btnGrid1.Text;
            }
            else if (this.btnGrid2.Text == this.btnGrid5.Text && this.btnGrid5.Text == this.btnGrid8.Text && this.btnGrid2.Text != "")
            {
                winner = this.btnGrid2.Text;
            }
            else if (this.btnGrid3.Text == this.btnGrid6.Text && this.btnGrid6.Text == this.btnGrid9.Text && this.btnGrid3.Text != "")
            {
                winner = this.btnGrid3.Text;
            }

            //Diagonal WinCheck
            else if (this.btnGrid1.Text == this.btnGrid5.Text && this.btnGrid5.Text == this.btnGrid9.Text && this.btnGrid1.Text != "")
            {
                winner = this.btnGrid1.Text;
            }
            else if (this.btnGrid3.Text == this.btnGrid5.Text && this.btnGrid5.Text == this.btnGrid7.Text && this.btnGrid3.Text != "")
            {
                winner = this.btnGrid3.Text;
            }

            if (winner != "")
            {
                Restart restart = new Restart();
                restart.WinnerText = winner;
                restart.Show();
            }
        }

        private void aiPlay(string player)
        {
            count++;
            string ai = "X";

            if (player == "X")
            {
                ai = "O";
            }

            for (int i = 0; i < 1; i --)
            {
                if(count == 5)
                {
                    WinCheck(player);
                    return;
                }

                Random random = new Random();

                int gridNum = random.Next(1, 9);

                switch (gridNum)
                {
                    case 1:
                        if (this.btnGrid1.Text == "")
                        {
                            this.btnGrid1.Text = ai;
                            this.btnGrid1.Image = ImgAdd(ai);
                            return;
                        }
                        break;

                    case 2:
                        if (this.btnGrid2.Text == "")
                        {
                            this.btnGrid2.Text = ai;
                            this.btnGrid2.Image = ImgAdd(ai);
                            return;
                        }
                        break;

                    case 3:
                        if (this.btnGrid3.Text == "")
                        {
                            this.btnGrid3.Text = ai;
                            this.btnGrid3.Image = ImgAdd(ai);
                            return;
                        }
                        break;

                    case 4:
                        if (this.btnGrid4.Text == "")
                        {
                            this.btnGrid4.Text = ai;
                            this.btnGrid4.Image = ImgAdd(ai);
                            return;
                        }
                        break;

                    case 5:
                        if (this.btnGrid5.Text == "")
                        {
                            this.btnGrid5.Text = ai;
                            this.btnGrid5.Image = ImgAdd(ai);
                            return;
                        }
                        break;

                    case 6:
                        if (this.btnGrid6.Text == "")
                        {
                            this.btnGrid6.Text = ai;
                            this.btnGrid6.Image = ImgAdd(ai);
                            return;
                        }
                        break;

                    case 7:
                        if (this.btnGrid7.Text == "")
                        {
                            this.btnGrid7.Text = ai;
                            this.btnGrid7.Image = ImgAdd(ai);
                            return;
                        }
                        break;

                    case 8:
                        if (this.btnGrid8.Text == "")
                        {
                            this.btnGrid8.Text = ai;
                            this.btnGrid8.Image = ImgAdd(ai);
                            return;
                        }
                        break;

                    case 9:
                        if (this.btnGrid9.Text == "")
                        {
                            this.btnGrid9.Text = ai;
                            this.btnGrid9.Image = ImgAdd(ai);
                            return;
                        }
                        break;
                }
            }
        }

        public Bitmap ImgAdd(string image)
        {
            string relativePath = @"Images\"+image+"Player.png";

            string directory = AppDomain.CurrentDomain.BaseDirectory;

            string imgPath = Path.Combine(directory, relativePath);

            Bitmap b = new Bitmap(Image.FromFile(imgPath));

            int width = 80;
            int height = 80;

            Bitmap n = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(n))
            {
                g.DrawImage(b, 0, 0, width, height);
            }

            return n;
        }

        private void btnGrid1_Click(object sender, EventArgs e)
        {
            btnGrid1.Text = player;
            btnGrid1.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnGrid2_Click(object sender, EventArgs e)
        {
            btnGrid2.Text = player;
            btnGrid2.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnGrid3_Click(object sender, EventArgs e)
        {
            btnGrid3.Text = player;
            btnGrid3.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnGrid4_Click(object sender, EventArgs e)
        {
            btnGrid4.Text = player;
            btnGrid4.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnGrid5_Click(object sender, EventArgs e)
        {
            btnGrid5.Text = player;
            btnGrid5.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnGrid6_Click(object sender, EventArgs e)
        {
            btnGrid6.Text = player;
            btnGrid6.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnGrid7_Click(object sender, EventArgs e)
        {
            btnGrid7.Text = player;
            btnGrid7.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnGrid8_Click(object sender, EventArgs e)
        {
            btnGrid8.Text = player;
            btnGrid8.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnGrid9_Click(object sender, EventArgs e)
        {
            btnGrid9.Text = player;
            btnGrid9.Image = ImgAdd(player);
            aiPlay(player);
            WinCheck(player);
        }

        private void btnXChoice_Click(object sender, EventArgs e)
        {
            player = "X";
            EnableGame();
        }

        private void btnOChoice_Click(object sender, EventArgs e)
        {
            player = "O";
            EnableGame();
        }

        public void DisableGame()
        {
            this.btnGrid1.Enabled = false;
            this.btnGrid2.Enabled = false;
            this.btnGrid3.Enabled = false;
            this.btnGrid4.Enabled = false;
            this.btnGrid5.Enabled = false;
            this.btnGrid6.Enabled = false;
            this.btnGrid7.Enabled = false;
            this.btnGrid8.Enabled = false;
            this.btnGrid9.Enabled = false;
        }

        public void EnableGame()
        {
            this.btnGrid1.Enabled = true;
            this.btnGrid2.Enabled = true;
            this.btnGrid3.Enabled = true;
            this.btnGrid4.Enabled = true;
            this.btnGrid5.Enabled = true;
            this.btnGrid6.Enabled = true;
            this.btnGrid7.Enabled = true;
            this.btnGrid8.Enabled = true;
            this.btnGrid9.Enabled = true;
        }
    }
}
