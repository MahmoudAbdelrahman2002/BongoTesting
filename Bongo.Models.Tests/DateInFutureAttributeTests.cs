using Bongo.Models.ModelValidations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.Models
{
    [TestFixture]
    public class DateInFutureAttributeTests
    {
        [Test]
        [TestCase(100,ExpectedResult =true)]
        public bool DateValidator_InputExpectedDateRange_DateValidity(int addDays)
        {
            // Arrange
            DateInFutureAttribute dateInFutureAttribute = new(() => DateTime.Now);
            // Act
            return dateInFutureAttribute.IsValid(DateTime.Now.AddDays(addDays));








        }
        [Test]
        public void DateValidator_InputDateInPast_ReturnsErrorMessage()
        {
            // Arrange
            DateInFutureAttribute dateInFutureAttribute = new();
            // Act
            bool isValid = dateInFutureAttribute.IsValid(DateTime.Now.AddDays(-1));
            // Assert
            Assert.IsFalse(isValid);
        }
    }
}
