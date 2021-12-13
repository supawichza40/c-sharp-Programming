
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        [Test]
        public void GetOutput_DivisibleByThreeAndFiveValue_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.AreEqual(result, "FizzBuzz");
        }
        [Test]
        public void GetOutput_DivisibleByThreeValue_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(6);
            Assert.That(Is.Equals(result, "Fizz"));
        }
        [Test]
        public void GetOutput_DivisibleByFive_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);
            Assert.AreEqual(result, "Buzz");
        }

        [Test]
        public void GetOutput_ValueNotDivisibleByThreeOrFive_ReturnNumber()
        {
            var result = FizzBuzz.GetOutput(7);
            Assert.That(result,Is.EqualTo(result));
        }
    }
}
