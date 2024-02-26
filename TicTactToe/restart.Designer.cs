namespace TicTactToe
{
    partial class Restart
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
            this.btnExitRestart = new System.Windows.Forms.Button();
            this.btnYesRestart = new System.Windows.Forms.Button();
            this.restartLbl = new System.Windows.Forms.Label();
            this.lblWL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExitRestart
            // 
            this.btnExitRestart.Location = new System.Drawing.Point(181, 76);
            this.btnExitRestart.Name = "btnExitRestart";
            this.btnExitRestart.Size = new System.Drawing.Size(59, 38);
            this.btnExitRestart.TabIndex = 5;
            this.btnExitRestart.Text = "Quit";
            this.btnExitRestart.UseVisualStyleBackColor = true;
            this.btnExitRestart.Click += new System.EventHandler(this.btnExitRestart_Click);
            // 
            // btnYesRestart
            // 
            this.btnYesRestart.Location = new System.Drawing.Point(107, 76);
            this.btnYesRestart.Name = "btnYesRestart";
            this.btnYesRestart.Size = new System.Drawing.Size(65, 38);
            this.btnYesRestart.TabIndex = 4;
            this.btnYesRestart.Text = "Yes";
            this.btnYesRestart.UseVisualStyleBackColor = true;
            this.btnYesRestart.Click += new System.EventHandler(this.btnYesRestart_Click);
            // 
            // restartLbl
            // 
            this.restartLbl.AutoSize = true;
            this.restartLbl.Location = new System.Drawing.Point(104, 46);
            this.restartLbl.Name = "restartLbl";
            this.restartLbl.Size = new System.Drawing.Size(136, 13);
            this.restartLbl.TabIndex = 3;
            this.restartLbl.Text = "Do you want to play again?";
            // 
            // lblWL
            // 
            this.lblWL.AutoSize = true;
            this.lblWL.Location = new System.Drawing.Point(104, 22);
            this.lblWL.Name = "lblWL";
            this.lblWL.Size = new System.Drawing.Size(58, 13);
            this.lblWL.TabIndex = 7;
            this.lblWL.Text = "Temp Text";
            // 
            // Restart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 184);
            this.Controls.Add(this.lblWL);
            this.Controls.Add(this.btnExitRestart);
            this.Controls.Add(this.btnYesRestart);
            this.Controls.Add(this.restartLbl);
            this.Name = "Restart";
            this.Text = "restart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitRestart;
        private System.Windows.Forms.Button btnYesRestart;
        private System.Windows.Forms.Label restartLbl;
        private System.Windows.Forms.Label lblWL;
    }
}