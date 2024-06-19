using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGUI.BL
{
    class CardInfoBL
    {
        private string cardType;
        private int cardNumber;
        private int securityPin;

        public CardInfoBL(string cardType, int cardNumber, int securityPin)
        {
            this.CardType = cardType;
            this.CardNumber = cardNumber;
            this.SecurityPin = securityPin;
        }

        public string CardType { get => cardType; set => cardType = value; }
        public int CardNumber { get => cardNumber; set => cardNumber = value; }
        public int SecurityPin { get => securityPin; set => securityPin = value; }
    }

}
