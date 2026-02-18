using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Xunit;

namespace Sparky
{
    public class CalculatorXUnitTests
    {
        [Fact]
        public void Add_InputTwoIntegers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.AddNumbers(10, 5);
            // Assert
            Assert.Equal(10, result);
            

        }
        [Fact]
        
        public void IsOdd_InputEvenNumber_ReturnsFalse()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            bool result = calculator.IsOdd(10);
            // Assert
            Assert.False(result);
            

        }
    
        [Theory]
        [InlineData(13)]
        [InlineData(15)]
        public void IsOdd_InputOddNumber_ReturnsTrue(int input)
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            bool result = calculator.IsOdd(input);
            // Assert
            Assert.True(result);
           
        }
        [Theory]
        [InlineData(10, false)]
        [InlineData(13, true)]
        public void IsOdd_InputOddOrEvenNumber_ReturnsTrue(int input, bool expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            bool result = calculator.IsOdd(input);
            // Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void GetOddRange_InputMinAndMax_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();
            List<int> expectedList = new List<int>() { 11, 13, 15 };
            // Act
            List<int> result = calculator.GetOddRange(10, 15);
            // Assert
            Assert.Equal(expectedList, result);
            Assert.Contains(13, result);
            







        }
    }
}
