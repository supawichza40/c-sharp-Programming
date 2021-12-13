
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formater = new HtmlFormatter();
            var outcome = formater.FormatAsBold("test1");
            //different way to write assertion, from specific to general
            //1.Specific - but if we add period, colon, later, this will not work.
            Assert.That(outcome, Is.EqualTo("<strong>test1</strong>"));
            //3. More General 
            Assert.That(outcome, Does.StartWith("<strong>"));
            //2.General - this may allow the code to pass all the time, and not detect the bug.

            Assert.That(outcome, Does.StartWith("<strong>"));
            Assert.That(outcome, Does.EndWith("</strong>"));
            Assert.That(outcome, Does.Contain("test1"));

        }
    }
}
