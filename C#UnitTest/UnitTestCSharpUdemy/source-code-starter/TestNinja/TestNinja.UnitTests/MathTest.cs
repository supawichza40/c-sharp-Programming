
using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTest
    {
        private Math math;
        private Math _math; //We used _ to tell the developer that it is a private field.
        [SetUp]
        public void SetUp()
        {
            math = new Math();
        }
        [Test]
        public void Add_WhenCall_ReturnTheSumOfArguments()
        {
            //Math math = new Math();
            var outcome = math.Add(10, 20);
            Assert.AreEqual(30, outcome);

        }
        [Test]
        public void Max_WhenFirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            //Math math = new Math();
            var outcome = math.Max(20, 10);
            Assert.AreEqual(20, outcome);

        }
        [Test]
        public void Max_WhenSecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            //Math math = new Math();
            var outcome = math.Max(10, 20);
            Assert.AreEqual(20, outcome);

        }
        [Test]
        public void Max_WhenBothArgumentAreEqual_ReturnEitherArgument()
        {
            Math math = new Math();
            var outcome = math.Max(20, 20);
            Assert.AreEqual(20, outcome);

        }
        [Test]
        [TestCase(2,1,2)]

        [TestCase(1, 2, 2)]

        [TestCase(1, 1, 1)]
        //Single Generic method instead of 3 above method.
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a,int b,int expectedResult)
        {

            var outcome = math.Max(a, b);
            Assert.AreEqual(outcome, expectedResult);
        }
        //we should test when limit is negative 0 and positive.
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            Math math = new Math();
            var result =  math.GetOddNumbers(5);

            //general way
            Assert.That(result, Is.Not.Empty);

            //Specific way(count)
            Assert.That(result.Count(), Is.EqualTo(3));

            //Very Specific
            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));
            //Alternative
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
            Assert.That(result, Is.Ordered);



        }

    }
}
