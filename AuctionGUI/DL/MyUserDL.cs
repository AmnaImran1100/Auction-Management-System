using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AuctionGUI.BL;

namespace AuctionGUI.DL
{
    class MyUserDL
    {
        public static MyUserBL currentUser = new MyUserBL();

        public static List<MyUserBL> userList = new List<MyUserBL>();

        static public void addUserIntoList(MyUserBL User)
        {
            userList.Add(User);
        }

        static public MyUserBL signIn(MyUserBL User)
        {
            foreach (MyUserBL storedUser in userList)
            {
                if (User.UserName == storedUser.UserName && User.UserPassword == storedUser.UserPassword)
                {
                    currentUser = storedUser;
                    return storedUser;
                }

            }
            return null;
        }

        public static void storeintoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (MyUserBL p in userList)
            {
                f.WriteLine(p.UserName + "," + p.UserPassword + "," + p.UserRole);
            }
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string userName = splittedRecord[0];
                    string userPassword = splittedRecord[1];
                    string userRole = splittedRecord[2];
                    MyUserBL s = new MyUserBL(userName, userPassword, userRole);
                    addUserIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
