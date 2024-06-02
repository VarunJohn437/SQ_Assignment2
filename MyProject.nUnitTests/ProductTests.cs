namespace MyProject.nUnitTests
{
    public class ProductTests
    {

        [TestCase(1)]
        [TestCase(499)]
        [TestCase(1000)]
        public void ProductID_ShouldBeSetCorrectly(int testValue)
        {
            // Arrange
            int expectedProductID = testValue;

            // Act
            Product product = new Product(expectedProductID, "Testing Product", 9.99m, 99);

            // Assert
            Assert.That(expectedProductID, Is.EqualTo(product.ProductID));
        }

        [TestCase("Product 1")]
        [TestCase("Product 2")]
        [TestCase("Product 3")]
        public void ProductName_ShouldBeSetCorrectly(String testValue)
        {
            // Arrange
            string expectedProductName = testValue;

            // Act
            Product product = new Product(1, expectedProductName, 9.99m, 99);

            // Assert
            Assert.That(expectedProductName, Is.EqualTo(product.ProductName));
        }

        [TestCase(1.99)]
        [TestCase(2599.99)]
        [TestCase(4900.99)]
        public void Price_ShouldBeSetCorrectly(decimal testValue)
        {
            // Arrange
            decimal expectedPrice = testValue;

            // Act
            Product product = new Product(1, "Testing Product", expectedPrice, 99);

            // Assert
            Assert.That(expectedPrice, Is.EqualTo(product.Price));
        }


        [TestCase(1)]
        [TestCase(499)]
        [TestCase(999)]
        public void Stock_ShouldBeSetCorrectly(int testValue)
        {
            // Arrange
            int expectedStock = testValue;

            // Act
            Product product = new Product(1, "Testing Product", 9.99m, expectedStock);

            // Assert
            Assert.That(expectedStock, Is.EqualTo(product.Stock));
        }

        [TestCase(1)]
        [TestCase(499)]
        [TestCase(999)]
        public void IncreaseStock_ShouldIncreaseStockCorrectly(int testValue)
        {
            // Arrange
            Product product = new Product(1, "Testing Product", 9.99m, 0);
            int expectedStock = product.Stock + testValue;

            // Act
            product.IncreaseStock(testValue);

            // Assert
            Assert.That(expectedStock, Is.EqualTo(product.Stock));
        }


        [TestCase(1)]
        [TestCase(499)]
        [TestCase(999)]
        public void DecreaseStock_ShouldDecreaseStockCorrectly(int testValue)
        {
            // Arrange
            Product product = new Product(1, "Testing Product", 9.99m, 0);
            int expectedStock = product.Stock - testValue;

            // Act
            product.DecreaseStock(testValue);

            // Assert
            Assert.That(expectedStock, Is.EqualTo(product.Stock));
        }

    }
}