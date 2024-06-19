using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGUI.BL
{
    class ReviewsBL
    {
        private string name;
        private string review;

        public ReviewsBL(string name, string review)
        {
            this.Name = name;
            this.Review = review;
        }

        public string Name { get => name; set => name = value; }
        public string Review { get => review; set => review = value; }
    }
}
