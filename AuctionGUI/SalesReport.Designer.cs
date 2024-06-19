
namespace AuctionGUI
{
    partial class SalesReport
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
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.lblAuction = new System.Windows.Forms.Label();
            this.gvSalesReport = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(653, 100);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(123, 45);
            this.lblAddProduct.TabIndex = 20;
            this.lblAddProduct.Text = "Sales Report";
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAdminMenu.Location = new System.Drawing.Point(615, 67);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(210, 33);
            this.lblAdminMenu.TabIndex = 19;
            this.lblAdminMenu.Text = "ADMIN MENU";
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(415, 23);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 18;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // gvSalesReport
            // 
            this.gvSalesReport.BackgroundColor = System.Drawing.Color.White;
            this.gvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSalesReport.Location = new System.Drawing.Point(31, 162);
            this.gvSalesReport.Name = "gvSalesReport";
            this.gvSalesReport.RowHeadersWidth = 62;
            this.gvSalesReport.RowTemplate.Height = 28;
            this.gvSalesReport.Size = new System.Drawing.Size(1417, 372);
            this.gvSalesReport.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(661, 550);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 45);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 620);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvSalesReport);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.lblAuction);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.DataGridView gvSalesReport;
        private System.Windows.Forms.Button btnBack;
    }
}