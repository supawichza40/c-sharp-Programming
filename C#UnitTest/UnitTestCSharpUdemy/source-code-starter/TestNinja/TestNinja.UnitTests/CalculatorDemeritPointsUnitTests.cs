
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CalculatorDemeritPointsUnitTests
    {
        private DemeritPointsCalculator cal;
        [SetUp]
        public void SetUp()
        {
            cal = new DemeritPointsCalculator();

        }

        [Test]
        [TestCase(-1)]
        [TestCase(310)]
        public void CalculatorDemeritPoints_ValueLessThan0OrMoreThanMaxSpeed_RaiseArgumentOutOfRangeException(int value)
        {
            DemeritPointsCalculator cal = new DemeritPointsCalculator();
            Assert.That(() => cal.CalculateDemeritPoints(value), Throws.TypeOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void CalculatorDemeritPoints_ValueLessThanSpeedLimit_ReturnZero()
        {
            var result = cal.CalculateDemeritPoints(35);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void CalculatorDemeritPoints_ValueMoreThanSpeedLimit_ReturnDemeritPoints()
        {
            var result = cal.CalculateDemeritPoints(70);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
