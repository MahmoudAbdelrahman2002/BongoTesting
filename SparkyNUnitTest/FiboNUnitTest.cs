using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class FiboNUnitTest
    {
        private Fibo _fibo;
        [SetUp]
        public void Setup()
        {
            _fibo = new Fibo();
        }
        [Test]
        public void GetFiboSeries_Range1_ReturnsFiboSeries()
        {
            _fibo.Range = 1;
            var result = _fibo.GetFiboSeries();
            Assert.That(result, Is.EqualTo(new List<int> { 0 }));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public void GetFiboSeries_Range6_ReturnsFiboSeries()
        {
            //arrange
            _fibo.Range = 6;
            //act
            var result = _fibo.GetFiboSeries();
            //assert
            Assert.That(result, Is.EqualTo(new List<int> { 0, 1, 1, 2, 3, 5 }));
            Assert.That(result, Has.Count.EqualTo(6));
           
            Assert.That(result, Does.Contain(5));
            Assert.That(result, Does.Not.Contain(6));









        }

    }
}
