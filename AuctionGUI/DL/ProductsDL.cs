using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AuctionGUI.BL;

namespace AuctionGUI.DL
{
    class ProductsDL
    {
        static public List<ProductsBL> productsList = new List<ProductsBL>();

        static public void addProductInList(ProductsBL p)
        {
            productsList.Add(p);
        }

        static public ProductsBL ifProducNameExists(string name)
        {
            bool nameCheck = false;
            ProductsBL product = new ProductsBL();
            foreach (ProductsBL p in ProductsDL.productsList)
            {
                if (p.Name == name)
                {
                    nameCheck = true;
                    product = p;
                }
            }
            if (nameCheck == true)
            {
                return product;
            }
            else
            {
                return null;
            }
        }

        public static void storeintoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (ProductsBL m in productsList)
            {
                f.WriteLine(m.Name + "," + m.Category + "," + m.Color + "," + m.Age + "," + m.Price + "," + m.Quantity + "," + m.HighestBid + "," + m.Profit + "," + m.PercentageProfit + "," + m.Buyer);
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
                    string category = splittedRecord[1];
                    string color = splittedRecord[2];
                    int age = int.Parse(splittedRecord[3]);
                    int price = int.Parse(splittedRecord[4]);
                    int quantity = int.Parse(splittedRecord[5]);
                    int highestBid = int.Parse(splittedRecord[6]);
                    int profit = int.Parse(splittedRecord[7]);
                    int percentageProfit = int.Parse(splittedRecord[8]);
                    string buyer = splittedRecord[9];
                    ProductsBL s = new ProductsBL(name, category, color, age, price, quantity, highestBid, profit, percentageProfit, buyer);
                    productsList.Add(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void deleteProductFromList(ProductsBL product)
        {
            for (int index = 0; index < productsList.Count; index++)
            {
                if (productsList[index].Name == product.Name)
                {
                    productsList.RemoveAt(index);
                }
            }

        }

        public static void editProductFromList(ProductsBL previous, ProductsBL updated)
        {
            foreach (ProductsBL product in productsList)
            {
                if (product.Name == previous.Name)
                {
                    product.Name = updated.Name;
                    product.Category = updated.Category;
                    product.Color = updated.Color;
                    product.Age = updated.Age;
                    product.Price = updated.Price;
                }
            }
        }

    }
}
