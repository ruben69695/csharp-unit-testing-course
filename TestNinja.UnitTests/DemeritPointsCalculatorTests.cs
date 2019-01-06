using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritPointsCalculator;
        
        [SetUp]
        public void Setup()
        {
            _demeritPointsCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]     // Negative speed is an invalid speed
        [TestCase(301)]    // Pass 300 speed is an invalid speed
        public void CalculateDemeritPoints_NegativeSpeed_ShouldThrowAnArgumentOutOfRangeException(int wrongSpeed)
        {
            Assert.That(() => { _demeritPointsCalculator.CalculateDemeritPoints(wrongSpeed); }, Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}