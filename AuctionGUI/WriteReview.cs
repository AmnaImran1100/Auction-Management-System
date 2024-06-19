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
    public partial class WriteReview : Form
    {
        public WriteReview()
        {
            InitializeComponent();
        }

        private void ClearDataFromForm()
        {
            txtReview.Text = "";
        }

        private void WriteReview_Load(object sender, EventArgs e)
        {

        }

        private void txtReview_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            string reviewPath = "reviewsInfo.txt";
            string review = txtReview.Text;
            string name = MyUserDL.currentUser.UserName;
            ReviewsBL s = new ReviewsBL(name, review);
            ReviewsDL.addReviewIntoList(s);
            ReviewsDL.storeintoFile(reviewPath);
            MessageBox.Show("Your Review has been Added");
            ClearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
