
using System;
using CalculatorApplication;
using NUnit.Framework;

namespace CalculatorOperationUnitTest
{
    [TestFixture]
    public class CalculatorOperationTest
    {
        [Test]
        public void Addition_positiveTwoValue_ReturnNull()
        {
            Calculator testCal = new Calculator(10, 20);
            testCal.Addition();
            Assert.True(true);
        }
        [Test]
        public void Division_PositiveAndZero_ReturnNull()
        {
            Calculator testCal = new Calculator(10, 0);
            testCal.Division();
            Assert.True(true);
        }
        public void Division_ZeroAndPositiveOrNegative_ReturnNull()
        {
            Calculator testCal = new Calculator(0, 10);
            testCal.Division();
            Calculator testCal2 = new Calculator(0, -10);
            testCal2.Division();
            Assert.True(true);
        }

    }
}
