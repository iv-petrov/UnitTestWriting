using UnitTestWriting.Domain;
using Xunit;

namespace UnitTestWriting.Tests.Domain
{
    public class CartTests
    {
        [Fact]
        public void Ctor_SingleProduct_ReturnFullPrice()
        {
            // Arrange
            var product = new Product { Price = 1000 };
            var user = new User();
            // Act
            var cart = new Cart(user);
            cart.AddProduct(product, 20);
            // Assert
            Assert.Equal(20000, cart.GetFullPrice(DateTime.Now));
        }
    }
}
