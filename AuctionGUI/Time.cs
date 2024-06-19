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
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
        }

        private void Time_Load(object sender, EventArgs e)
        {

        }

        private void lblSetTime_Click(object sender, EventArgs e)
        {

        }

        private void btnShowEndOfAuction_Click(object sender, EventArgs e)
        {
            string timePath = "timeInfo.txt";
            int days = int.Parse(txtDays.Text);
            int duration = days * 86400;
            TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            int timestamp = (int)t.TotalSeconds;
            TimeDL.auctionTime.Day = days;
            TimeDL.auctionTime.EnteredTime = timestamp;
            TimeDL.auctionTime.Duration = duration;
            TimeDL.storeintoFile(timePath);
            MessageBox.Show("The Auction will End in " + days + " Days");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
