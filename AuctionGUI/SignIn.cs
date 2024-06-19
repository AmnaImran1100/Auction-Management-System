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
    public partial class SignIn : Form
    {

        public SignIn()
        {
            InitializeComponent();
        }

        public void ClearDataFromForm()
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;
            MyUserBL User = new MyUserBL(userName, userPassword);
            MyUserBL validUser = MyUserDL.signIn(User);
            if (validUser != null)
            {
                MessageBox.Show("User is Valid");
                if (validUser.isAdmin())
                {
                    AdminMenu form = new AdminMenu();
                    form.Show();
                }
                else
                {
                    UserMenu form = new UserMenu();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("User is Invalid");
                
            }
            ClearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
