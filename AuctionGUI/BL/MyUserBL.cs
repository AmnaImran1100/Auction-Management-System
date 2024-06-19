using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGUI.BL
{
    class MyUserBL
    {
        private string userName;
        private string userPassword;
        private string userRole;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserRole { get => userRole; set => userRole = value; }

        public MyUserBL()
        {

        }

        public MyUserBL(string userName, string userPassword, string userRole) // for signup
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
            this.UserRole = userRole;
        }

        public MyUserBL(string userName, string userPassword) // for signin
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
            this.UserRole = "NA";
        }
        public bool isAdmin() // checks if user is admin
        {
            if (UserRole == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isCurrentPassordValid(string currentPassword)
        {
            if (currentPassword == UserPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
