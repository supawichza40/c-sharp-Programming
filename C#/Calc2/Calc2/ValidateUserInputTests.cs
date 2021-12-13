using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
    [TestFixture]
    class ValidateUserInputTests
    {
        private ValidateUserInput v;
        [SetUp]
        public void SetUp()
        {
            v = new ValidateUserInput();
        }
        [Test]
        public void ValidInput_PassingInAlphabet_ReturnFalse()
        {

            var result = v.ValidInput("a");
            Assert.IsFalse(result);
        }
        [Test]
        public void ValidInput_PassingOperator_ReturnTrue()
        {
            
            var result = v.ValidInput("+");
            Assert.IsTrue(result);
        }
        [Test]
        public void ValidInput_PassingTwoContinuousOperator_ReturnFalse()
        {
            var result = v.ValidInput("++");
            Assert.IsFalse(result);
        }
        [Test]
        public void ValidInput_PassingValidValue_ReturnTrue()
        {
            var result = v.ValidInput("10");
            Assert.IsTrue(result);
        }
        [Test]
        public void ValidInput_PassingValueAndCharacter_ReturnFalse()
        {
            var result = v.ValidInput("10a");
            Assert.IsFalse(result);
        }
    }
}
