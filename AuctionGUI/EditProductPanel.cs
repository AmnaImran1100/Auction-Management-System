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
    public partial class EditProductPanel : Form
    {
        private ProductsBL previous;

        public EditProductPanel(ProductsBL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductsBL updated = new ProductsBL(txtName.Text, txtCatgeory.Text, txtColor.Text, int.Parse(txtAge.Text), int.Parse(txtPrice.Text));
            ProductsDL.editProductFromList(previous, updated);
            this.Close();
        }

        private void EditProductPanel_Load(object sender, EventArgs e)
        {
            txtName.Text = previous.Name;
            txtCatgeory.Text = previous.Category;
            txtColor.Text = previous.Color;
            txtAge.Text = previous.Age.ToString();
            txtPrice.Text = previous.Price.ToString();
        }
    }
}
