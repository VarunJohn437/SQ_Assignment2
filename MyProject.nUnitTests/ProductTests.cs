using System;

namespace MyProject.nUnitTests
{
    public class ProductTests
    {
        private readonly int DEFAULT_PRODUCT_ID = 1;
        private readonly string DEFAULT_PRODUCT_NAME = "Test Product";
        private readonly decimal DEFAULT_PRODUCT_PRICE = 500m;
        private readonly int DEFAULT_PRODUCT_STOCK = 100;

        private Product _product { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _product = new(DEFAULT_PRODUCT_ID, DEFAULT_PRODUCT_NAME, DEFAULT_PRODUCT_PRICE, DEFAULT_PRODUCT_STOCK);
        }

        [Test]
        public void ProductID_ShouldBeSetCorrectly()
        {
            // Arrange
            int expectedProductID = 1;

            // Act
            _product.ProductID = expectedProductID;

            // Assert
            Assert.That(_product.ProductID, Is.EqualTo(expectedProductID));
        }

        [Test]
        public void ProductID_ShouldThrowException_ForLessThanMinimunValue()
        {
            // Arrange
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Product ID should be between 1 to 1000.";
            int testProductID = 0;

            // Act
            Exception exception = Assert.Catch(() => _product.ProductID = testProductID);

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void ProductID_ShouldThrowException_ForMoreThanMaximunValue()
        {
            // Arrange
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Product ID should be between 1 to 1000.";
            int testProductID = 1001;

            // Act
            Exception exception = Assert.Catch(() => _product.ProductID = testProductID);

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void ProductName_ShouldBeSetCorrectly_Constructor()
        {
            // Arrange
            string expectedProductName = "Product 1";

            // Act
            Product product = new Product(DEFAULT_PRODUCT_ID, expectedProductName, DEFAULT_PRODUCT_PRICE, DEFAULT_PRODUCT_STOCK);

            // Assert
            Assert.That(product.ProductName, Is.EqualTo(expectedProductName));
        }

        [Test]
        public void ProductName_ShouldBeSetCorrectly_AttributeAssignment()
        {
            // Arrange
            string expectedProductName = "Product 2";

            // Act
            _product.ProductName = expectedProductName;

            // Assert
            Assert.That(_product.ProductName, Is.EqualTo(expectedProductName));
        }

        [Test]
        public void ProductName_ShouldThrowException_NullAttributeAssignment()
        {
            // Arrange
            var expectedException = typeof(ArgumentNullException);
            var expectedMessage = "Product name can't be null.";

            // Act
            Exception exception = Assert.Catch(() => _product.ProductName = null);

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void Price_ShouldBeSetCorrectly()
        {
            // Arrange
            decimal expectedPrice = 9.99m;

            // Act
            _product.Price = expectedPrice;

            // Assert
            Assert.That(_product.Price, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Price_ShouldThrowException_ForLessThanMinimunValue()
        {
            // Arrange
            decimal testPrice = 0;
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Price should be between $1 to $5000.";

            // Act
            Exception exception = Assert.Catch(() => _product.Price = testPrice);

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void Price_ShouldThrowException_ForMoreThanMaximunValue()
        {
            // Arrange
            decimal testPrice = 5001;
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Price should be between $1 to $5000.";

            // Act
            Exception exception = Assert.Catch(() => _product.Price = testPrice);

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void Stock_ShouldBeSetCorrectly()
        {
            // Arrange
            int expectedStock = 99;

            // Act
            _product.Stock = expectedStock;

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void Stock_ShouldThrowException_ForLessThanMinimunValue()
        {
            // Arrange
            int testStock = 0;
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Stock should be between 1 to 1000.";

            // Act
            Exception exception = Assert.Catch(() => _product.Stock = testStock);

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void Stock_ShouldThrowException_ForMoreThanMaxmunValue()
        {
            // Arrange
            int testStock = 1001;
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Stock should be between 1 to 1000.";

            // Act
            Exception exception = Assert.Catch(() => _product.Stock = testStock);

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void IncreaseStock_ShouldIncreaseStockCorrectly()
        {
            // Arrange
            _product.Stock = 100;
            int increaseValue = 50;
            int expectedStock = 150;

            // Act
            _product.IncreaseStock(increaseValue);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void IncreaseStock_ShouldThrowException_ForNegativeValue()
        {
            // Arrange
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Value should be greater than zero.";
            int increaseValue = -1;
            _product.Stock = 1;

            // Act
            Exception exception = Assert.Catch(() => _product.IncreaseStock(increaseValue));

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void IncreaseStock_ShouldThrowException_ForMoreThanStockValue()
        {
            // Arrange
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Stock can be more than 1000.";
            int increaseValue = 1001;
            _product.Stock = 1;

            // Act
            Exception exception = Assert.Catch(() => _product.IncreaseStock(increaseValue));

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void DecreaseStock_ShouldDecreaseStockCorrectly()
        {
            // Arrange
            _product.Stock = 100;
            int decreaseValue = 10;
            int expectedStock = 90;

            // Act
            _product.DecreaseStock(decreaseValue);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void DecreaseStock_ShouldThrowException_ForNegativeValue()
        {
            // Arrange
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Value should be greater than zero.";
            int decreaseValue = -1;

            // Act
            Exception exception = Assert.Catch(() => _product.DecreaseStock(decreaseValue));

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void DecreaseStock_ShouldThrowException_ForValueGreaterThanStock()
        {
            // Arrange
            var expectedException = typeof(ArgumentOutOfRangeException);
            var expectedMessage = "Stock is low";
            int decreaseValue = 2;
            _product.Stock = 1;

            // Act
            Exception exception = Assert.Catch(() => _product.DecreaseStock(decreaseValue));

            // Assert
            Assert.That(exception.GetType(), Is.EqualTo(expectedException));
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }
    }

}