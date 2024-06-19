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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void btnTImeDate_Click(object sender, EventArgs e)
        {
            UserTimeShow form = new UserTimeShow();
            form.Show();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ViewProducts form = new ViewProducts();
            form.Show();
        }

        private void btnPlaceBid_Click(object sender, EventArgs e)
        {
            PlaceBid form = new PlaceBid();
            form.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
            form.Show();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            WriteReview form = new WriteReview();
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

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
