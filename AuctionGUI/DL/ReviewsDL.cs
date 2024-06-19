using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AuctionGUI.BL;


namespace AuctionGUI.DL
{
    class ReviewsDL
    {
        public static List<ReviewsBL> reviewsList = new List<ReviewsBL>();

        public static void addReviewIntoList(ReviewsBL s)
        {
            reviewsList.Add(s);
        }

        public static void storeintoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (ReviewsBL m in reviewsList)
            {
                f.WriteLine(m.Name + "," + m.Review);
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
                    string name = splittedRecord[0];
                    string review = splittedRecord[1];
                    ReviewsBL s = new ReviewsBL(name, review);
                    reviewsList.Add(s);
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
