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
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void lblAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            gvProductsList.DataSource = ProductsDL.productsList;
            gvProductsList.Columns["Profit"].Visible = false;
            gvProductsList.Columns["PercentageProfit"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            List<ProductsBL> rugs = new List<ProductsBL>();
            List<ProductsBL> paintings = new List<ProductsBL>();
            foreach(ProductsBL p in ProductsDL.productsList)
            {
                if(p.Category == "Rug")
                {
                    rugs.Add(p);
                }
                else if (p.Category == "Painting")
                {
                    paintings.Add(p);
                }
            }
            if (txtFilterCategory.Text == "Rug")
            {
                gvProductsList.DataSource = rugs;
                gvProductsList.Columns["Profit"].Visible = false;
                gvProductsList.Columns["PercentageProfit"].Visible = false;
            }
            else if (txtFilterCategory.Text == "Painting")
            {
                gvProductsList.DataSource = paintings;
                gvProductsList.Columns["Profit"].Visible = false;
                gvProductsList.Columns["PercentageProfit"].Visible = false;
            }
        }
    }
}
