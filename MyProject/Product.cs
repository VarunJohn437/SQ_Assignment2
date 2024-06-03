using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private decimal _price;
        private int _stock;

        public int ProductID
        {
            get { return _productId; }
            set
            {
                if (value < 1 || value > 1000)
                    throw new ArgumentOutOfRangeException("", "Product ID should be between 1 to 1000.");
                _productId = value;
            }
        }

        public string ProductName
        {
            get { return _productName; }
            set {
                _productName = value ?? throw new ArgumentNullException("", "Product name can't be null.");
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 1 || value > 5000)
                    throw new ArgumentOutOfRangeException("", "Price should be between $1 to $5000.");
                _price = value;
            }
        }

        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 1 || value > 1000)
                    throw new ArgumentOutOfRangeException("", "Stock should be between 1 to 1000.");
                _stock = value;
            }
        }

        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("", "Value should be greater than zero.");
            else if (value > 1000)
            {
                throw new ArgumentOutOfRangeException("", "Stock can be more than 1000.");
            }
            Stock += value;
        }

        public void DecreaseStock(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("", "Value should be greater than zero.");
            if (Stock >= value)
            {
                Stock -= value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("", "Stock is low");
            }
        }

    }
}
