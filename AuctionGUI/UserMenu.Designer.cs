
namespace AuctionGUI
{
    partial class UserMenu
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
            this.lblUserMenu = new System.Windows.Forms.Label();
            this.lblPunchLine = new System.Windows.Forms.Label();
            this.lblAuction = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTImeDate = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnPlaceBid = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserMenu
            // 
            this.lblUserMenu.AutoSize = true;
            this.lblUserMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMenu.Location = new System.Drawing.Point(590, 144);
            this.lblUserMenu.Name = "lblUserMenu";
            this.lblUserMenu.Size = new System.Drawing.Size(185, 33);
            this.lblUserMenu.TabIndex = 13;
            this.lblUserMenu.Text = "USER MENU";
            // 
            // lblPunchLine
            // 
            this.lblPunchLine.AutoSize = true;
            this.lblPunchLine.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchLine.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPunchLine.Location = new System.Drawing.Point(499, 97);
            this.lblPunchLine.Name = "lblPunchLine";
            this.lblPunchLine.Size = new System.Drawing.Size(359, 35);
            this.lblPunchLine.TabIndex = 12;
            this.lblPunchLine.Text = "Welcome to the Worlds First Online Auctions System  ";
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(360, 53);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 11;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(858, 541);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 47);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTImeDate
            // 
            this.btnTImeDate.BackColor = System.Drawing.Color.White;
            this.btnTImeDate.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTImeDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTImeDate.Location = new System.Drawing.Point(746, 197);
            this.btnTImeDate.Name = "btnTImeDate";
            this.btnTImeDate.Size = new System.Drawing.Size(338, 52);
            this.btnTImeDate.TabIndex = 27;
            this.btnTImeDate.Text = "View Time and Date of Auction";
            this.btnTImeDate.UseVisualStyleBackColor = false;
            this.btnTImeDate.Click += new System.EventHandler(this.btnTImeDate_Click);
            // 
            // btnReview
            // 
            this.btnReview.BackColor = System.Drawing.Color.White;
            this.btnReview.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReview.Location = new System.Drawing.Point(816, 433);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(216, 47);
            this.btnReview.TabIndex = 26;
            this.btnReview.Text = "Write a Review";
            this.btnReview.UseVisualStyleBackColor = false;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.White;
            this.btnPayment.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayment.Location = new System.Drawing.Point(816, 368);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(216, 59);
            this.btnPayment.TabIndex = 25;
            this.btnPayment.Text = "Payment Panel ";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.BackColor = System.Drawing.Color.White;
            this.btnViewProducts.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewProducts.Location = new System.Drawing.Point(816, 255);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(216, 49);
            this.btnViewProducts.TabIndex = 24;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = false;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnPlaceBid
            // 
            this.btnPlaceBid.BackColor = System.Drawing.Color.White;
            this.btnPlaceBid.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlaceBid.Location = new System.Drawing.Point(786, 316);
            this.btnPlaceBid.Name = "btnPlaceBid";
            this.btnPlaceBid.Size = new System.Drawing.Size(268, 46);
            this.btnPlaceBid.TabIndex = 23;
            this.btnPlaceBid.Text = " Place Bid on An Item";
            this.btnPlaceBid.UseVisualStyleBackColor = false;
            this.btnPlaceBid.Click += new System.EventHandler(this.btnPlaceBid_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangePassword.Location = new System.Drawing.Point(816, 486);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(216, 47);
            this.btnChangePassword.TabIndex = 29;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionGUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(173, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 344);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTImeDate);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnPlaceBid);
            this.Controls.Add(this.lblUserMenu);
            this.Controls.Add(this.lblPunchLine);
            this.Controls.Add(this.lblAuction);
            this.Name = "UserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserMenu;
        private System.Windows.Forms.Label lblPunchLine;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTImeDate;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnPlaceBid;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}