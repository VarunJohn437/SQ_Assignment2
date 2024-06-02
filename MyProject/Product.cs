using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Product
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }


        public Product(int productID, string productName, decimal price, int stock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int quantity)
        {
            Stock += quantity;
        }

        public void DecreaseStock(int quantity)
        {
            Stock -= quantity;
        }

    }
}
