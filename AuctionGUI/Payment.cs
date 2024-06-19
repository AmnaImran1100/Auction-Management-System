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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void ClearDataFromForm()
        {
            txtCardType.Text = "";
            txtCardNumber.Text = "";
            txtSecurityPin.Text = "";
        }

        private void lblPunchLine_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            string cardType = txtCardType.Text;
            int cardNumber = int.Parse(txtCardNumber.Text);
            int securityPin = int.Parse(txtSecurityPin.Text);
            CardInfoBL m = new CardInfoBL(cardType, cardNumber, securityPin);
            bool status = CardInfoDL.isCardInfoValid(m);
            if (status == true)
            {
                MessageBox.Show("Payment Made!");
            }
            else
            {
                MessageBox.Show("Wrong Card information entered! Please try again!");
            }
            ClearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
