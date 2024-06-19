using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AuctionGUI.BL;

namespace AuctionGUI.DL
{
    class TimeDL
    {
        static public TimeBL auctionTime = new TimeBL();

        public static void storeintoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            f.WriteLine(auctionTime.Day + "," + auctionTime.EnteredTime + "," + auctionTime.Duration);
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
                    int day = int.Parse(splittedRecord[0]);
                    int enteredTime  = int.Parse(splittedRecord[1]);
                    int duration = int.Parse(splittedRecord[2]);
                    TimeBL s = new TimeBL(day, enteredTime, duration);
                    auctionTime = s;
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
