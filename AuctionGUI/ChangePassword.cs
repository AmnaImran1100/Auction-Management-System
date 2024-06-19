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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ClearDataFromForm()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "" ;
            txtNewPassword2.Text = "";
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string userPath = "userInfo.txt";
            string currentUserName = MyUserDL.currentUser.UserName;
            string currentPassword = MyUserDL.currentUser.UserPassword;
            string currentPassordEntered = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string newPassword2 = txtNewPassword2.Text;
            if (currentPassword == currentPassordEntered)
            {
                if (newPassword == newPassword2)
                {
                    foreach (MyUserBL p in MyUserDL.userList)
                    {
                        if (currentUserName == p.UserName)
                        {
                            p.UserPassword = newPassword;
                            MyUserDL.storeintoFile(userPath);
                            MessageBox.Show("Password has been Changed");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("New Passwords Do not Match");
                }
            }
            else
            {
                MessageBox.Show("Wrong Current Password Entered");
            }
            ClearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
