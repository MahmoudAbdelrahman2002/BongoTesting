using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer _customer;
        [SetUp]

        public void Setup()
        {
            _customer = new Customer();

        }
        [Test]
        public void GreatAndCombineNames_InputFirstAndLastName_ReturnsCombinedString()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            // Act
            string result = _customer.GreatAndCombineNames(firstName, lastName);
            // Assert
            Assert.That(result, Is.EqualTo("Hello, John Doe"));






        }
        [Test]
        public void GreatMessage_NotGreated_ReturnsNull()
        {
            // Assert
            Assert.That(_customer.GreatMessage, Is.Null);
        }
        [Test]
        public void GreatAndCombineNames_InputEmptyFirstName_ThrowsArgumentException()
        {
            // Arrange
            string firstName = "";
            string lastName = "Doe";
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _customer.GreatAndCombineNames(firstName, lastName));


        }
        [Test]
        public void GetCustomerType_OrderTotalLessThan100_ReturnsBasicCustomer()
        {
            // Arrange
            _customer.OrderTotal = 50;
            // Act
            CustomerType result = _customer.GetCustomerType();
            // Assert
            Assert.That(result, Is.TypeOf<BasicCustomer>());
        }
    }
}
