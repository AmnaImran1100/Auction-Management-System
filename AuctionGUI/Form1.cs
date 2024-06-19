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

namespace AuctionGUI
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
            string userPath = "userInfo.txt";
            if (MyUserDL.readFromFile(userPath))
            {
                MessageBox.Show("User Data Loaded Successfully");
            }
            else
            {
                MessageBox.Show("Data not Loaded");
            }
            string productsPath = "productsInfo.txt";
            if (ProductsDL.readFromFile(productsPath))
            {
                MessageBox.Show("Products Data Loaded Successfully");
            }
            else
            {
                MessageBox.Show("Products not Loaded");
            }
            string cardsPath = "cardsInfo.txt";
            if (CardInfoDL.readFromFile(cardsPath))
            {
                MessageBox.Show("Cards Data Loaded Successfully");
            }
            else
            {
                MessageBox.Show("Cards not Loaded");
            }
            string reviewsPath = "reviewsInfo.txt";
            if (ReviewsDL.readFromFile(reviewsPath))
            {
                MessageBox.Show("Reviews Data Loaded Successfully");
            }
            else
            {
                MessageBox.Show("Reviews not Loaded");
            }
            string timePath = "timeInfo.txt";
            if (TimeDL.readFromFile(timePath))
            {
                MessageBox.Show("Date and Time Data Loaded Successfully");
            }
            else
            {
                MessageBox.Show("Date and Time not Loaded");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkBoxSignIn.Checked)
            {
                SignIn form = new SignIn();
                form.Show();
                checkBoxSignIn.Checked = false;
            }
            else if (checkBoxSignUp.Checked)
            {
                SignUp form = new SignUp();
                form.Show();
                checkBoxSignUp.Checked = false;
            }
        }
    }
}
