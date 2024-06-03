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

        public Product(int productId, string productName, decimal price, int stock)
        {
            if (productId < 1 || productId > 1000)
                throw new ArgumentOutOfRangeException("Product ID should be between 1 to 1000.");
            if (price < 1 || price > 5000)
                throw new ArgumentOutOfRangeException("Price should be between $1 to $5000.");
            if (stock < 1 || stock > 1000)
                throw new ArgumentOutOfRangeException("Stock should be between 1 to 1000.");

            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int value)
        {
            if (value < 0 || value > 1000)
                throw new ArgumentOutOfRangeException("Value should be greater than zero.");
            Stock += value;
        }

        public void DecreaseStock(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Value should be greater than positive.");
            if (Stock >= value)
            {
                Stock -= value;
            }
            else
            {
                throw new ArgumentException("Stock is low");
            }
        }

    }
}
