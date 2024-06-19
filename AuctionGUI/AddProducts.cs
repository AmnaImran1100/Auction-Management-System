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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void ClearDataFromForm()
        {
            txtName.Text = "";
            txtCategory.Text = "";
            txtColor.Text = "";
            txtAge.Text = "";
            txtPrice.Text = "";
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productsPath = "productsInfo.txt";
            string name = txtName.Text;
            string category = txtCategory.Text;
            string color = txtColor.Text;
            int age = int.Parse(txtAge.Text);
            int price = int.Parse(txtPrice.Text);
            bool flag = false;
            foreach (ProductsBL m in ProductsDL.productsList)
            {
                if (name == m.Name)
                {
                    MessageBox.Show("This Product Name Already Exists");
                    flag = true;
                }
            }
            if (flag == false)
            {
                ProductsBL p = new ProductsBL(name, category, color, age, price);
                ProductsDL.addProductInList(p);
                ProductsDL.storeintoFile(productsPath);
                MessageBox.Show("Product Added Successfully");
            }
            ClearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
