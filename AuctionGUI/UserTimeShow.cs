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
    public partial class UserTimeShow : Form
    {
        public UserTimeShow()
        {
            InitializeComponent();
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserTimeShow_Load(object sender, EventArgs e)
        {
            TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            int userTime = (int)t.TotalSeconds;
            int diffSecs1 = userTime - TimeDL.auctionTime.EnteredTime;
            int diffSecs2 = TimeDL.auctionTime.Duration - diffSecs1;
            float diffDays = diffSecs2 / 86400.0F;
            int days = (int)diffDays;
            float decimalHours = diffDays - days;
            float durHours = decimalHours * 24.0F;
            int hours = (int)durHours;
            float decimalMins = diffSecs1 / 60.0F;
            float decimalMinutes = 60.0F - decimalMins;
            int mins = (int)decimalMinutes;
            if (diffSecs1 < TimeDL.auctionTime.Duration)
            {
                txtDays.Text = days.ToString();
                txtHours.Text = hours.ToString();
                txtMinutes.Text = mins.ToString();
            }
            else if (diffSecs1 > TimeDL.auctionTime.Duration)
            {
                MessageBox.Show("Auction has ended or it has not started yet!");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
