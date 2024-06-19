
namespace AuctionGUI
{
    partial class EditProducts
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
            this.lblEditDelete = new System.Windows.Forms.Label();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.lblAuction = new System.Windows.Forms.Label();
            this.gvEditProductsList = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvEditProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditDelete
            // 
            this.lblEditDelete.AutoSize = true;
            this.lblEditDelete.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDelete.Location = new System.Drawing.Point(669, 101);
            this.lblEditDelete.Name = "lblEditDelete";
            this.lblEditDelete.Size = new System.Drawing.Size(222, 45);
            this.lblEditDelete.TabIndex = 20;
            this.lblEditDelete.Text = "Edit and Delete Products";
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAdminMenu.Location = new System.Drawing.Point(681, 68);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(210, 33);
            this.lblAdminMenu.TabIndex = 19;
            this.lblAdminMenu.Text = "ADMIN MENU";
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(481, 24);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 18;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // gvEditProductsList
            // 
            this.gvEditProductsList.BackgroundColor = System.Drawing.Color.White;
            this.gvEditProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEditProductsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.DELETE});
            this.gvEditProductsList.Location = new System.Drawing.Point(12, 161);
            this.gvEditProductsList.Name = "gvEditProductsList";
            this.gvEditProductsList.RowHeadersWidth = 62;
            this.gvEditProductsList.RowTemplate.Height = 28;
            this.gvEditProductsList.Size = new System.Drawing.Size(1571, 387);
            this.gvEditProductsList.TabIndex = 21;
            this.gvEditProductsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEditProductsList_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "EDIT";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 150;
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 8;
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "Delete";
            this.DELETE.UseColumnTextForButtonValue = true;
            this.DELETE.Width = 150;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(732, 563);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 45);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1612, 620);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvEditProductsList);
            this.Controls.Add(this.lblEditDelete);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.lblAuction);
            this.Name = "EditProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProducts";
            this.Load += new System.EventHandler(this.lblEditProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEditProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditDelete;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.DataGridView gvEditProductsList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
    }
}