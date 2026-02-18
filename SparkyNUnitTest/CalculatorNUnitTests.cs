using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void Add_InputTwoIntegers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.AddNumbers(10, 5);
            // Assert
            ClassicAssert.AreEqual(15, result);

        }
        [Test]
        public void IsOdd_InputEvenNumber_ReturnsFalse()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            bool result = calculator.IsOdd(10);
            // Assert
            ClassicAssert.IsFalse(result);

        }
        [Test]
        [TestCase(13)]
        [TestCase(15)]
        public void IsOdd_InputOddNumber_ReturnsTrue(int input)
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            bool result = calculator.IsOdd(input);
            // Assert
            ClassicAssert.IsTrue(result);
        }
        [Test]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = false)]
        public bool IsOdd_InputOddOrEvenNumber_ReturnsTrue(int input)
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            return calculator.IsOdd(input);
        }
        [Test]
        public void GetOddRange_InputMinAndMax_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();
            List<int> expectedList = new List<int>() { 11, 13, 15 };
            // Act
            List<int> result = calculator.GetOddRange(10, 15);
            // Assert
            Assert.That(result, Is.EquivalentTo(expectedList));
            Assert.That(result, Does.Contain(13));
            Assert.That(result, Has.Exactly(3).Items);
           



        }
    }
}
