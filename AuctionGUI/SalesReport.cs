using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuctionGUI.DL;

namespace AuctionGUI
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            gvSalesReport.DataSource = ProductsDL.productsList;
            gvSalesReport.Columns["Quantity"].Visible = false;
            for (int i = 0; i < gvSalesReport.Rows.Count; i++)
            {
                if (gvSalesReport.Rows[i].Cells[6].Value.ToString()=="0")
                {
                    CurrencyManager c = (CurrencyManager)BindingContext[gvSalesReport.DataSource];
                    c.SuspendBinding();
                    gvSalesReport.Rows[i].Visible = false;
                }
            }
        }
    }
}
