namespace TicTactToe
{
    partial class CustomDialogBox
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
            this.cstmDialogboxLbl = new System.Windows.Forms.Label();
            this.btnXChoice = new System.Windows.Forms.Button();
            this.btnOChoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cstmDialogboxLbl
            // 
            this.cstmDialogboxLbl.AutoSize = true;
            this.cstmDialogboxLbl.Location = new System.Drawing.Point(124, 38);
            this.cstmDialogboxLbl.Name = "cstmDialogboxLbl";
            this.cstmDialogboxLbl.Size = new System.Drawing.Size(127, 13);
            this.cstmDialogboxLbl.TabIndex = 0;
            this.cstmDialogboxLbl.Text = "What do you want to be?";
            // 
            // btnXChoice
            // 
            this.btnXChoice.Location = new System.Drawing.Point(118, 83);
            this.btnXChoice.Name = "btnXChoice";
            this.btnXChoice.Size = new System.Drawing.Size(65, 38);
            this.btnXChoice.TabIndex = 1;
            this.btnXChoice.Text = "X";
            this.btnXChoice.UseVisualStyleBackColor = true;
            this.btnXChoice.Click += new System.EventHandler(this.btnXChoice_Click);
            // 
            // btnOChoice
            // 
            this.btnOChoice.Location = new System.Drawing.Point(202, 83);
            this.btnOChoice.Name = "btnOChoice";
            this.btnOChoice.Size = new System.Drawing.Size(59, 38);
            this.btnOChoice.TabIndex = 2;
            this.btnOChoice.Text = "O";
            this.btnOChoice.UseVisualStyleBackColor = true;
            this.btnOChoice.Click += new System.EventHandler(this.btnOChoice_Click);
            // 
            // CustomDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 169);
            this.Controls.Add(this.btnOChoice);
            this.Controls.Add(this.btnXChoice);
            this.Controls.Add(this.cstmDialogboxLbl);
            this.Name = "CustomDialogBox";
            this.Text = "CustomDialogBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cstmDialogboxLbl;
        private System.Windows.Forms.Button btnXChoice;
        private System.Windows.Forms.Button btnOChoice;
    }
}