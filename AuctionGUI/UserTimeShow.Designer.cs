
namespace AuctionGUI
{
    partial class UserTimeShow
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
            this.lblUserTime = new System.Windows.Forms.Label();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.lblAuction = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserTime
            // 
            this.lblUserTime.AutoSize = true;
            this.lblUserTime.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTime.Location = new System.Drawing.Point(538, 110);
            this.lblUserTime.Name = "lblUserTime";
            this.lblUserTime.Size = new System.Drawing.Size(245, 45);
            this.lblUserTime.TabIndex = 23;
            this.lblUserTime.Text = "Time when Auction will End";
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAdminMenu.Location = new System.Drawing.Point(550, 77);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(210, 33);
            this.lblAdminMenu.TabIndex = 22;
            this.lblAdminMenu.Text = "ADMIN MENU";
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(350, 33);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 21;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(597, 549);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 45);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(593, 264);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(144, 44);
            this.txtDays.TabIndex = 26;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(624, 371);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(71, 33);
            this.lblDays.TabIndex = 27;
            this.lblDays.Text = "Days";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(885, 371);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(82, 33);
            this.lblHours.TabIndex = 28;
            this.lblHours.Text = "Hours";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(1110, 371);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(107, 33);
            this.lblMinutes.TabIndex = 29;
            this.lblMinutes.Text = "Minutes";
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(854, 264);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(138, 44);
            this.txtHours.TabIndex = 30;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutes.Location = new System.Drawing.Point(1095, 264);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(139, 44);
            this.txtMinutes.TabIndex = 31;
            this.txtMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionGUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(97, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 344);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // UserTimeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUserTime);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.lblAuction);
            this.Name = "UserTimeShow";
            this.Text = "UserTimeShow";
            this.Load += new System.EventHandler(this.UserTimeShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserTime;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}