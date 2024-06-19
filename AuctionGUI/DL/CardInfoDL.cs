using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AuctionGUI.BL;

namespace AuctionGUI.DL
{
    class CardInfoDL
    {
        static public List<CardInfoBL> cardList = new List<CardInfoBL>();

        static public void addCardInfoInList(CardInfoBL p)
        {
            cardList.Add(p);
        }

        static public bool isCardInfoValid(CardInfoBL m)
        {
            foreach (CardInfoBL storedCard in cardList)
            {
                if (m.CardNumber == storedCard.CardNumber && m.CardType == storedCard.CardType && m.SecurityPin == storedCard.SecurityPin)
                {
                    return true;
                }
            }
            return false;
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
                    string cardType = splittedRecord[0];
                    int cardNumber = int.Parse(splittedRecord[1]);
                    int securityPin = int.Parse(splittedRecord[2]);
                    CardInfoBL s = new CardInfoBL(cardType, cardNumber, securityPin);
                    addCardInfoInList(s);
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
