
namespace AuctionGUI
{
    partial class AdminMenu
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
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.lblPunchLine = new System.Windows.Forms.Label();
            this.lblAuction = new System.Windows.Forms.Label();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnTImeDate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.Location = new System.Drawing.Point(566, 124);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(210, 33);
            this.lblAdminMenu.TabIndex = 13;
            this.lblAdminMenu.Text = "ADMIN MENU";
            this.lblAdminMenu.Click += new System.EventHandler(this.lblAdminMenu_Click);
            // 
            // lblPunchLine
            // 
            this.lblPunchLine.AutoSize = true;
            this.lblPunchLine.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchLine.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPunchLine.Location = new System.Drawing.Point(500, 78);
            this.lblPunchLine.Name = "lblPunchLine";
            this.lblPunchLine.Size = new System.Drawing.Size(359, 35);
            this.lblPunchLine.TabIndex = 12;
            this.lblPunchLine.Text = "Welcome to the Worlds First Online Auctions System  ";
            this.lblPunchLine.Click += new System.EventHandler(this.lblPunchLine_Click);
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(361, 34);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 11;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            this.lblAuction.Click += new System.EventHandler(this.lblAuction_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.White;
            this.btnAddProducts.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProducts.Location = new System.Drawing.Point(769, 176);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(216, 46);
            this.btnAddProducts.TabIndex = 14;
            this.btnAddProducts.Text = "ADD Products";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.BackColor = System.Drawing.Color.White;
            this.btnViewProducts.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewProducts.Location = new System.Drawing.Point(769, 228);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(216, 49);
            this.btnViewProducts.TabIndex = 15;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = false;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.White;
            this.btnSalesReport.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalesReport.Location = new System.Drawing.Point(769, 395);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(216, 59);
            this.btnSalesReport.TabIndex = 17;
            this.btnSalesReport.Text = "View Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnReviews
            // 
            this.btnReviews.BackColor = System.Drawing.Color.White;
            this.btnReviews.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReviews.Location = new System.Drawing.Point(769, 460);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(216, 47);
            this.btnReviews.TabIndex = 18;
            this.btnReviews.Text = "View Reviews";
            this.btnReviews.UseVisualStyleBackColor = false;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // btnTImeDate
            // 
            this.btnTImeDate.BackColor = System.Drawing.Color.White;
            this.btnTImeDate.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTImeDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTImeDate.Location = new System.Drawing.Point(715, 337);
            this.btnTImeDate.Name = "btnTImeDate";
            this.btnTImeDate.Size = new System.Drawing.Size(338, 52);
            this.btnTImeDate.TabIndex = 20;
            this.btnTImeDate.Text = "View Time and Date of Auction";
            this.btnTImeDate.UseVisualStyleBackColor = false;
            this.btnTImeDate.Click += new System.EventHandler(this.btnTImeDate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(811, 565);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 47);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangePassword.Location = new System.Drawing.Point(769, 513);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(216, 46);
            this.btnChangePassword.TabIndex = 22;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(744, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "Edit and Delete Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionGUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(155, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 344);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTImeDate);
            this.Controls.Add(this.btnReviews);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.lblPunchLine);
            this.Controls.Add(this.lblAuction);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Label lblPunchLine;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnTImeDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}