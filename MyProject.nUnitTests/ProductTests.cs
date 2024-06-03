namespace MyProject.nUnitTests
{
    public class ProductTests
    {
        [Test]
        public void ProductID_ShouldBeSetCorrectly()
        {
            // Arrange
            int expectedProductID = 1;

            // Act
            Product product = new Product(expectedProductID, "Testing Product", 9.99m, 99);

            // Assert
            Assert.That(expectedProductID, Is.EqualTo(product.ProductID));
        }

        [Test]
        public void ProductID_ShouldThrowException_ForLessThanMinimunValue()
        {
            // Arrange
            int expectedProductID = 0;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(expectedProductID, "Invalid Product", 9.99m, 99));
        }

        [Test]
        public void ProductID_ShouldThrowException_ForMoreThanMaximunValue()
        {
            // Arrange
            int expectedProductID = 1001;
            //
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(expectedProductID, "Invalid Product", 9.99m, 99));
        }

        [Test]
        public void ProductName_ShouldBeSetCorrectly_Test1()
        {
            // Arrange
            string expectedProductName = "Product 1";

            // Act
            Product product = new Product(1, expectedProductName, 9.99m, 99);

            // Assert
            Assert.That(expectedProductName, Is.EqualTo(product.ProductName));
        }

        [Test]
        public void ProductName_ShouldBeSetCorrectly_Test2()
        {
            // Arrange
            string expectedProductName = "Product 2";

            // Act
            Product product = new Product(1, expectedProductName, 9.99m, 99);

            // Assert
            Assert.That(expectedProductName, Is.EqualTo(product.ProductName));
        }

        [Test]
        public void ProductName_ShouldBeSetCorrectly_Test3()
        {
            // Arrange
            string expectedProductName = "Product 3";

            // Act
            Product product = new Product(1, expectedProductName, 9.99m, 99);

            // Assert
            Assert.That(expectedProductName, Is.EqualTo(product.ProductName));
        }

        [Test]
        public void Price_ShouldBeSetCorrectly()
        {
            // Arrange
            decimal expectedPrice = 9.99m;

            // Act
            Product product = new Product(1, "Testing Product", expectedPrice, 99);

            // Assert
            Assert.That(expectedPrice, Is.EqualTo(product.Price));
        }

        [Test]
        public void Price_ShouldThrowException_ForLessThanMinimunValue()
        {
            // Arrange
            decimal testPrice = 0;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(1, "Invalid Product", testPrice, 99));
        }

        [Test]
        public void Price_ShouldThrowException_ForMoreThanMaximunValue()
        {
            // Arrange
            decimal testPrice = 5001;
            //
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(1, "Invalid Product", testPrice, 99));
        }

        [Test]
        public void Stock_ShouldBeSetCorrectly()
        {
            // Arrange
            int expectedStock = 99;

            // Act
            Product product = new Product(1, "Testing Product", 9.99m, expectedStock);

            // Assert
            Assert.That(expectedStock, Is.EqualTo(product.Stock));
        }

        [Test]
        public void Stock_ShouldThrowException_ForLessThanMinimunValue()
        {
            // Arrange
            int testStock = 0;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(1, "Invalid Product", 9.99m, testStock));
        }

        [Test]
        public void Stock_ShouldThrowException_ForMoreThanMaxmunValue()
        {
            // Arrange
            int testStock = 1001;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(1, "Invalid Product", 9.99m, testStock));
        }

        [Test]
        public void IncreaseStock_ShouldIncreaseStockCorrectly()
        {
            // Arrange
            Product product = new Product(1, "Testing Product", 9.99m, 10);
            int increaseValue = 5;
            int expectedStock = 15;

            // Act
            product.IncreaseStock(increaseValue);

            // Assert
            Assert.That(expectedStock, Is.EqualTo(product.Stock));
        }

        [Test]
        public void IncreaseStock_ShouldThrowException_ForNegativeValue()
        {
            // Arrange
            int stockValue = 1;
            int increaseValue = -1;
            Product product = new Product(1, "Testing Product", 9.99m, stockValue);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.IncreaseStock(increaseValue));
        }

        [Test]
        public void IncreaseStock_ShouldThrowException_ForMoreThanStockValue()
        {
            // Arrange
            int stockValue = 1;
            int increaseValue = 1001;
            Product product = new Product(1, "Testing Product", 9.99m, stockValue);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.IncreaseStock(increaseValue));
        }

        [Test]
        public void DecreaseStock_ShouldDecreaseStockCorrectly()
        {
            // Arrange
            Product product = new Product(1, "Testing Product", 9.99m, 100);
            int decreaseValue = 10;
            int expectedStock = 90;

            // Act
            product.DecreaseStock(decreaseValue);

            // Assert
            Assert.That(expectedStock, Is.EqualTo(product.Stock));
        }

        [Test]
        public void DecreaseStock_ShouldThrowException_ForNegativeValue()
        {
            // Arrange
            int stockValue = 1;
            int decreaseValue = -5;
            Product product = new Product(1, "Testing Product", 9.99m, stockValue);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.DecreaseStock(decreaseValue));
        }

        [Test]
        public void DecreaseStock_ShouldThrowException_ForValueGreaterThanStock()
        {
            // Arrange
            int stockValue = 1;
            int decreaseValue = 2;
            Product product = new Product(1, "Testing Product", 9.99m, stockValue);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.DecreaseStock(decreaseValue));
        }
    }

}