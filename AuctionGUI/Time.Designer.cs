
namespace AuctionGUI
{
    partial class Time
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.lblAuction = new System.Windows.Forms.Label();
            this.lblSetTime = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShoeEndOfAUction = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(426, 97);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(320, 45);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "Ending Time and Date of the Auction";
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAdminMenu.Location = new System.Drawing.Point(493, 75);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(210, 33);
            this.lblAdminMenu.TabIndex = 19;
            this.lblAdminMenu.Text = "ADMIN MENU";
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(271, 31);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 18;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // lblSetTime
            // 
            this.lblSetTime.AutoSize = true;
            this.lblSetTime.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime.Location = new System.Drawing.Point(503, 210);
            this.lblSetTime.Name = "lblSetTime";
            this.lblSetTime.Size = new System.Drawing.Size(604, 33);
            this.lblSetTime.TabIndex = 21;
            this.lblSetTime.Text = "Enter the Number of Days in which Auction will End";
            this.lblSetTime.Click += new System.EventHandler(this.lblSetTime_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(528, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 42);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShoeEndOfAUction
            // 
            this.btnShoeEndOfAUction.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoeEndOfAUction.Location = new System.Drawing.Point(711, 364);
            this.btnShoeEndOfAUction.Name = "btnShoeEndOfAUction";
            this.btnShoeEndOfAUction.Size = new System.Drawing.Size(222, 42);
            this.btnShoeEndOfAUction.TabIndex = 29;
            this.btnShoeEndOfAUction.Text = "Click here";
            this.btnShoeEndOfAUction.UseVisualStyleBackColor = true;
            this.btnShoeEndOfAUction.Click += new System.EventHandler(this.btnShowEndOfAuction_Click);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(685, 284);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(260, 26);
            this.txtDays.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionGUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(34, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 344);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.btnShoeEndOfAUction);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSetTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.lblAuction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            this.Load += new System.EventHandler(this.Time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.Label lblSetTime;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShoeEndOfAUction;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}