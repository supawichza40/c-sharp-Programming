using ICalculatorInputService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    [TestFixture]
    public class UserInputTest
    {
        [Test]
        public void EnterTwoPlusThreeWillReturn3TimeinList()
        {

            UserInput sut = new UserInput();
            List<string> x  = sut.GetInput();

            Assert.AreEqual(x.Count, 3);

        }

    }
}
