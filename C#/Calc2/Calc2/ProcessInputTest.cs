using CalculatorApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
    [TestFixture]
    class ProcessInputTest
    {
        [Test]
        public void ProcessInput_Valid2ListOfString_ReturnValidResult()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.CalculateInput(new List<string> { "3","+","3"});
            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void ProcessInput_Valid3ListOfString_ReturnValidResult()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.CalculateInput(new List<string> { "3", "+", "3","+","10" });
            Assert.That(result, Is.EqualTo(16));
        }
        [Test]
        public void ProcessInput_Valid5ListOfString_ReturnValidResult()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.CalculateInput(new List<string> { "3", "+", "3","+","3", "+", "10","+","20" });
            Assert.That(result, Is.EqualTo(39));
        }
        [Test]
        public void ProcessINput_PassingAddThenSubtractTo3Value_ReturnExpectedResult()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.CalculateInput(new List<string> { "3", "+", "3", "-", "3", "-", "10", "+", "20" });
            Assert.That(result, Is.EqualTo(13));
        }
        
    }
}
