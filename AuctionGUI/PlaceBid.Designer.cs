
namespace AuctionGUI
{
    partial class PlaceBid
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
            this.txtBid = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblBid = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblEnterBidDetails = new System.Windows.Forms.Label();
            this.btnPlaceBid = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserMenu
            // 
            this.lblUserMenu.AutoSize = true;
            this.lblUserMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMenu.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblUserMenu.Location = new System.Drawing.Point(574, 82);
            this.lblUserMenu.Name = "lblUserMenu";
            this.lblUserMenu.Size = new System.Drawing.Size(185, 33);
            this.lblUserMenu.TabIndex = 16;
            this.lblUserMenu.Text = "USER MENU";
            // 
            // lblPunchLine
            // 
            this.lblPunchLine.AutoSize = true;
            this.lblPunchLine.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchLine.Location = new System.Drawing.Point(588, 115);
            this.lblPunchLine.Name = "lblPunchLine";
            this.lblPunchLine.Size = new System.Drawing.Size(154, 35);
            this.lblPunchLine.TabIndex = 15;
            this.lblPunchLine.Text = "Place Your Bid Here  ";
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(358, 38);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 14;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // txtBid
            // 
            this.txtBid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBid.Location = new System.Drawing.Point(976, 337);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(259, 35);
            this.txtBid.TabIndex = 31;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(976, 263);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(259, 35);
            this.txtProductName.TabIndex = 30;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.Location = new System.Drawing.Point(684, 340);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(215, 27);
            this.lblBid.TabIndex = 29;
            this.lblBid.Text = "Your Bid on the Item";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(684, 271);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(151, 27);
            this.lblProductName.TabIndex = 28;
            this.lblProductName.Text = "Product Name";
            // 
            // lblEnterBidDetails
            // 
            this.lblEnterBidDetails.AutoSize = true;
            this.lblEnterBidDetails.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterBidDetails.Location = new System.Drawing.Point(755, 194);
            this.lblEnterBidDetails.Name = "lblEnterBidDetails";
            this.lblEnterBidDetails.Size = new System.Drawing.Size(402, 35);
            this.lblEnterBidDetails.TabIndex = 32;
            this.lblEnterBidDetails.Text = "Enter the name of item you want to buy and enter the Bid ";
            // 
            // btnPlaceBid
            // 
            this.btnPlaceBid.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBid.Location = new System.Drawing.Point(915, 499);
            this.btnPlaceBid.Name = "btnPlaceBid";
            this.btnPlaceBid.Size = new System.Drawing.Size(145, 42);
            this.btnPlaceBid.TabIndex = 34;
            this.btnPlaceBid.Text = "Place my Bid";
            this.btnPlaceBid.UseVisualStyleBackColor = true;
            this.btnPlaceBid.Click += new System.EventHandler(this.btnPlaceBid_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(385, 499);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 42);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionGUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(120, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 344);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // PlaceBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlaceBid);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEnterBidDetails);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblBid);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblUserMenu);
            this.Controls.Add(this.lblPunchLine);
            this.Controls.Add(this.lblAuction);
            this.Name = "PlaceBid";
            this.Text = "PlaceBid";
            this.Load += new System.EventHandler(this.PlaceBid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserMenu;
        private System.Windows.Forms.Label lblPunchLine;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblEnterBidDetails;
        private System.Windows.Forms.Button btnPlaceBid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}