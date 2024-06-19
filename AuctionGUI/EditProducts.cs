using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuctionGUI.BL;
using AuctionGUI.DL;

namespace AuctionGUI
{
    public partial class EditProducts : Form
    {
        public EditProducts()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEditProducts_Load(object sender, EventArgs e)
        {
            gvEditProductsList.DataSource = ProductsDL.productsList;
            gvEditProductsList.Columns["Profit"].Visible = false;
            gvEditProductsList.Columns["PercentageProfit"].Visible = false;
        }

        public void BindGrid()
        {
            gvEditProductsList.DataSource = null;
            gvEditProductsList.DataSource = ProductsDL.productsList;
            gvEditProductsList.Refresh();
        }

        private void gvEditProductsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string productsPath = "productsInfo.txt";
            ProductsBL product = (ProductsBL)gvEditProductsList.CurrentRow.DataBoundItem;
            if (gvEditProductsList.Columns["Delete"].Index == e.ColumnIndex)
            {
                ProductsDL.deleteProductFromList(product);
                ProductsDL.storeintoFile(productsPath);
                BindGrid();
            }
            else if (gvEditProductsList.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditProductPanel myform = new EditProductPanel(product);
                myform.ShowDialog();
                ProductsDL.storeintoFile(productsPath);
                BindGrid();
            }
        }
    }
}
