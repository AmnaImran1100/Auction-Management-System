using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGUI.BL
{
    public class ProductsBL
    {
        private string name;
        private string category;
        private string color;
        private int age;
        private int price;
        private int quantity;
        private int highestBid;
        private int profit;
        private double percentageProfit;
        private string buyer;

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Color { get => color; set => color = value; }
        public int Age { get => age; set => age = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int HighestBid { get => highestBid; set => highestBid = value; }
        public int Profit { get => profit; set => profit = value; }
        public double PercentageProfit { get => percentageProfit; set => percentageProfit = value; }
        public string Buyer { get => buyer; set => buyer = value; }

        public ProductsBL()
        {

        }

        public ProductsBL(string name, string category, string color, int age, int price)
        {
            this.Name = name;
            this.Category = category;
            this.Color = color;
            this.Age = age;
            this.Price = price;
            Quantity = 1;
            HighestBid = 0;
            Profit = 0;
            Buyer = "";
            PercentageProfit = calculatePercentageProfit();
        }

        public ProductsBL(string name, string category, string color, int age, int price, int quantity, int highestBid, int profit, double percenatgeProfit, string buyer)
        {
            this.Name = name;
            this.Category = category;
            this.Color = color;
            this.Age = age;
            this.Price = price;
            this.Quantity = quantity;
            this.HighestBid = highestBid;
            this.Profit = profit;
            this.Buyer = buyer;
            percenatgeProfit = calculatePercentageProfit();
        }

        public double calculatePercentageProfit()
        {
            return (Profit / Price) * 100;
        }

        public bool ifBidIsHigher(int bid, string username)
        {
            if (bid == Price || bid >= Price)
            {
                HighestBid = bid;
                Quantity = 0;
                Profit = HighestBid - Price;
                Buyer = username;
                calculatePercentageProfit();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
