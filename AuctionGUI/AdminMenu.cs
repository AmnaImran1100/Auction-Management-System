using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionGUI
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblPunchLine_Click(object sender, EventArgs e)
        {

        }

        private void lblAuction_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            AddProducts form = new AddProducts();
            form.Show();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ViewProducts form = new ViewProducts();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProducts form = new EditProducts();
            form.Show();
        }

        private void btnTImeDate_Click(object sender, EventArgs e)
        {
            Time form = new Time();
            form.Show();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport form = new SalesReport();
            form.Show();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            Reviews form = new Reviews();
            form.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword();
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
