
namespace AuctionGUI
{
    partial class LogInPage
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
            this.lblAuction = new System.Windows.Forms.Label();
            this.checkBoxSignIn = new System.Windows.Forms.CheckBox();
            this.checkBoxSignUp = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPunchLine = new System.Windows.Forms.Label();
            this.lblSIgnUp = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(342, 40);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 0;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // checkBoxSignIn
            // 
            this.checkBoxSignIn.AutoSize = true;
            this.checkBoxSignIn.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSignIn.Location = new System.Drawing.Point(849, 204);
            this.checkBoxSignIn.Name = "checkBoxSignIn";
            this.checkBoxSignIn.Size = new System.Drawing.Size(71, 32);
            this.checkBoxSignIn.TabIndex = 4;
            this.checkBoxSignIn.Text = "LOG IN";
            this.checkBoxSignIn.UseVisualStyleBackColor = true;
            // 
            // checkBoxSignUp
            // 
            this.checkBoxSignUp.AutoSize = true;
            this.checkBoxSignUp.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSignUp.Location = new System.Drawing.Point(849, 335);
            this.checkBoxSignUp.Name = "checkBoxSignUp";
            this.checkBoxSignUp.Size = new System.Drawing.Size(78, 32);
            this.checkBoxSignUp.TabIndex = 5;
            this.checkBoxSignUp.Text = "SIGN UP";
            this.checkBoxSignUp.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(831, 465);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPunchLine
            // 
            this.lblPunchLine.AutoSize = true;
            this.lblPunchLine.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchLine.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPunchLine.Location = new System.Drawing.Point(505, 84);
            this.lblPunchLine.Name = "lblPunchLine";
            this.lblPunchLine.Size = new System.Drawing.Size(359, 35);
            this.lblPunchLine.TabIndex = 7;
            this.lblPunchLine.Text = "Welcome to the Worlds First Online Auctions System  ";
            // 
            // lblSIgnUp
            // 
            this.lblSIgnUp.AutoSize = true;
            this.lblSIgnUp.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIgnUp.Location = new System.Drawing.Point(751, 307);
            this.lblSIgnUp.Name = "lblSIgnUp";
            this.lblSIgnUp.Size = new System.Drawing.Size(302, 25);
            this.lblSIgnUp.TabIndex = 9;
            this.lblSIgnUp.Text = "Don\'t Have an Account? Sign Up";
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(804, 176);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(178, 25);
            this.lblSignIn.TabIndex = 10;
            this.lblSignIn.Text = "Start by Logging In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionGUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(196, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 344);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblSIgnUp);
            this.Controls.Add(this.lblPunchLine);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.checkBoxSignUp);
            this.Controls.Add(this.checkBoxSignIn);
            this.Controls.Add(this.lblAuction);
            this.Name = "LogInPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auction Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.CheckBox checkBoxSignIn;
        private System.Windows.Forms.CheckBox checkBoxSignUp;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPunchLine;
        private System.Windows.Forms.Label lblSIgnUp;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

