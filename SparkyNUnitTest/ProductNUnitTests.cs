using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class ProductNUnitTests
    {
        [Test]
        public void GetPrice_CustomerIsPlatinum_ReturnsDiscounted20Percent()
        {
            // Arrange
            var product = new Product { price = 100 };
            var customer = new Customer { IsPlatinum = true };
            // Act
            var result = product.GetPrice(customer);
            // Assert
            Assert.That(result, Is.EqualTo(80));

        }
        [Test]
        public void GetPriceMOQAbuse_CustomerIsPlatinum_ReturnsDiscounted20Percent()
        {
            // Arrange
            var product = new Product { price = 100 };
            var customerMoq = new Moq.Mock<ICustomer>();
            customerMoq.Setup(c => c.IsPlatinum).Returns(true);
            // Act
            var result = product.GetPrice(customerMoq.Object);
            // Assert
            Assert.That(result, Is.EqualTo(80));

        }

    }
}
