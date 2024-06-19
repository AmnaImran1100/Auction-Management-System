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
using AuctionGUI.BL;

namespace AuctionGUI
{
    public partial class PlaceBid : Form
    {
        public PlaceBid()
        {
            InitializeComponent();
        }

        private void ClearDataFromForm()
        {
            txtProductName.Text = "";
            txtBid.Text = "";
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaceBid_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaceBid_Click(object sender, EventArgs e)
        {
            string productsPath = "productsInfo.txt";
            string name = txtProductName.Text;
            int bid = int.Parse(txtBid.Text);
            ProductsBL productSelected = ProductsDL.ifProducNameExists(name);
            if (productSelected == null)
            {
                MessageBox.Show("No Item with this name exists! Please Try Again!");
            }
            else
            {
                bool checkBid = productSelected.ifBidIsHigher(bid, MyUserDL.currentUser.UserName);
                if (checkBid == true)
                {
                    MessageBox.Show("Item Sold!");
                    ProductsDL.storeintoFile(productsPath);
                }
                else
                {
                    MessageBox.Show("Bid is lower than Starting Price or Highest Bid! Please Try Again!");
                }
            }
            ClearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
