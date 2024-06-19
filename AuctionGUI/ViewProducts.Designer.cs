
namespace AuctionGUI
{
    partial class ViewProducts
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
            this.lblAuction = new System.Windows.Forms.Label();
            this.lblAllProductList = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gvProductsList = new System.Windows.Forms.DataGridView();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilterCategory = new System.Windows.Forms.TextBox();
            this.btnAddFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAdminMenu.Location = new System.Drawing.Point(630, 81);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(210, 33);
            this.lblAdminMenu.TabIndex = 19;
            this.lblAdminMenu.Text = "ADMIN MENU";
            // 
            // lblAuction
            // 
            this.lblAuction.AutoSize = true;
            this.lblAuction.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuction.Location = new System.Drawing.Point(430, 37);
            this.lblAuction.Name = "lblAuction";
            this.lblAuction.Size = new System.Drawing.Size(656, 44);
            this.lblAuction.TabIndex = 18;
            this.lblAuction.Text = "AUCTION MANAGEMENT SYSTEM";
            // 
            // lblAllProductList
            // 
            this.lblAllProductList.AutoSize = true;
            this.lblAllProductList.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllProductList.Location = new System.Drawing.Point(652, 114);
            this.lblAllProductList.Name = "lblAllProductList";
            this.lblAllProductList.Size = new System.Drawing.Size(153, 45);
            this.lblAllProductList.TabIndex = 21;
            this.lblAllProductList.Text = "All Products List";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(356, 566);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 42);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gvProductsList
            // 
            this.gvProductsList.BackgroundColor = System.Drawing.Color.White;
            this.gvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductsList.Location = new System.Drawing.Point(37, 173);
            this.gvProductsList.Name = "gvProductsList";
            this.gvProductsList.RowHeadersWidth = 62;
            this.gvProductsList.RowTemplate.Height = 28;
            this.gvProductsList.Size = new System.Drawing.Size(1406, 387);
            this.gvProductsList.TabIndex = 24;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(620, 570);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(100, 31);
            this.lblFilter.TabIndex = 25;
            this.lblFilter.Text = "Filter(Category)";
            // 
            // txtFilterCategory
            // 
            this.txtFilterCategory.Location = new System.Drawing.Point(740, 575);
            this.txtFilterCategory.Name = "txtFilterCategory";
            this.txtFilterCategory.Size = new System.Drawing.Size(252, 26);
            this.txtFilterCategory.TabIndex = 26;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.BackColor = System.Drawing.Color.White;
            this.btnAddFilter.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddFilter.Location = new System.Drawing.Point(1027, 570);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(123, 38);
            this.btnAddFilter.TabIndex = 27;
            this.btnAddFilter.Text = "Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = false;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 620);
            this.Controls.Add(this.btnAddFilter);
            this.Controls.Add(this.txtFilterCategory);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.gvProductsList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAllProductList);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.lblAuction);
            this.Name = "ViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Label lblAuction;
        private System.Windows.Forms.Label lblAllProductList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gvProductsList;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilterCategory;
        private System.Windows.Forms.Button btnAddFilter;
    }
}