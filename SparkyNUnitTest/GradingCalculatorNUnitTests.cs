using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator _gradingCalculator;
        [SetUp]
        public void Setup()
        {
            _gradingCalculator = new GradingCalculator();
        }
        [Test]
        public void GetGrade_Score95AndAttendance90_ReturnsA()
        {
            //arrange
            _gradingCalculator.Score = 95;
            _gradingCalculator.AttendancePercentage = 90;
            //act
            var result = _gradingCalculator.GetGrade();
            //assert
            Assert.That(result, Is.EqualTo("A"));



        }
        [Test]
        public void GetGrade_Score85AndAttendance90_ReturnsB()
        {
            //arrange
            _gradingCalculator.Score = 85;
            _gradingCalculator.AttendancePercentage = 90;
            //act
            var result = _gradingCalculator.GetGrade();
            //assert
            Assert.That(result, Is.EqualTo("B"));



        }
        [Test]
        public void GetGrade_Score65AndAttendance90_ReturnsC()
        {
            //arrange
            _gradingCalculator.Score = 65;
            _gradingCalculator.AttendancePercentage = 90;
            //act
            var result = _gradingCalculator.GetGrade();
            //assert
            Assert.That(result, Is.EqualTo("C"));

        }
        [Test]
        public void GetGrade_Score95AndAttendance65_ReturnsB()
        {
            //arrange
            _gradingCalculator.Score = 95;
            _gradingCalculator.AttendancePercentage = 65;
            //act
            var result = _gradingCalculator.GetGrade();
            //assert
            Assert.That(result, Is.EqualTo("B"));

        }
        [Test]
        [TestCase(95,55,ExpectedResult = "F")]
        [TestCase(65,55,ExpectedResult = "F")]
        [TestCase(55,90,ExpectedResult = "F")]
        public string GetGrade_ScoreAndAttendance_ReturnsF(int score, int attendance)
        {
            //arrange
            _gradingCalculator.Score = score;
            _gradingCalculator.AttendancePercentage = attendance;
            //act
            var result = _gradingCalculator.GetGrade();
            //assert
            return result;
        }


    }
}
