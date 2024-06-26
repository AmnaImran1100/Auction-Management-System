﻿using System;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void ClearDataFromForm()
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            txtUserRole.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;
            string userRole = txtUserRole.Text;
            string userPath = "userInfo.txt";
            bool flag = false;
            foreach (MyUserBL m in MyUserDL.userList)
            {
                if (userName == m.UserName)
                {
                    MessageBox.Show("This UserName Already Exists");
                    flag = true;
                }
            }
            if (flag == false)
            {
                MyUserBL User = new MyUserBL(userName, userPassword, userRole);
                MyUserDL.addUserIntoList(User);
                MyUserDL.storeintoFile(userPath);
                MessageBox.Show("User Added Successfully");
            }
            ClearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}