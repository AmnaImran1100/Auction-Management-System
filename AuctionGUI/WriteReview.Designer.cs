
namespace AuctionGUI
{
    partial class WriteReview
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
            this.lblReview = new System.Windows.Forms.Label();
            this.lblUserMenu = new System.Windows.Forms.Label();
            this.lblAuction = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.lblWriteReviewHere = new System.Windows.Forms.Label();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(545, 111);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(241, 35);
            this.lblReview.TabIndex = 20;
            this.lblReview.Text = "Your Review about your Experience";
            // 
            // lblUserMenu
            // 
            this.lblUserMenu.AutoSize = true;
            this.lblUserMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMenu.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblUserMenu.Location = new System.Drawing.Point(577, 78);
            this.lblUserMenu.Name = "lblUserMenu";
            this.lblUserMenu.Size = new System.Drawing.Size(185, 33);
            this.lblUserMenu.TabIndex = 19;
            this.lblUserMenu.Text = "USER MENU";
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(350, 34);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 18;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // txtReview
            // 
            this.txtReview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReview.Location = new System.Drawing.Point(653, 233);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(648, 35);
            this.txtReview.TabIndex = 24;
            this.txtReview.TextChanged += new System.EventHandler(this.txtReview_TextChanged);
            // 
            // lblWriteReviewHere
            // 
            this.lblWriteReviewHere.AutoSize = true;
            this.lblWriteReviewHere.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteReviewHere.Location = new System.Drawing.Point(648, 183);
            this.lblWriteReviewHere.Name = "lblWriteReviewHere";
            this.lblWriteReviewHere.Size = new System.Drawing.Size(248, 27);
            this.lblWriteReviewHere.TabIndex = 23;
            this.lblWriteReviewHere.Text = "Write your Review Here";
            // 
            // btnAddReview
            // 
            this.btnAddReview.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReview.Location = new System.Drawing.Point(888, 479);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(99, 42);
            this.btnAddReview.TabIndex = 27;
            this.btnAddReview.Text = "Add Review";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(358, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 42);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionGUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(115, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 344);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // WriteReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.lblWriteReviewHere);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lblUserMenu);
            this.Controls.Add(this.lblAuction);
            this.Name = "WriteReview";
            this.Text = "WriteReview";
            this.Load += new System.EventHandler(this.WriteReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblUserMenu;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Label lblWriteReviewHere;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}