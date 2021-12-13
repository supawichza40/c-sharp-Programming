
using NUnit.Framework;

using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IDis0_ReturnObjectNotFound()
        {
            CustomerController test = new CustomerController();
            ActionResult notFoundType = test.GetCustomer(0);
            //Different way we can check for a type.
            Assert.That(notFoundType, Is.TypeOf<NotFound>());
            //Type ensure that it is a notfound type
            Assert.That(notFoundType, Is.InstanceOf<NotFound>());
            //Instance can have any class that derive from not found class.
        }
        [Test]
        [Ignore("I just want to optimise test speed, so using only the one that is currently working!")]
        public void GetCustomer_IDisNot0_ReturnObjectOK()
        {
            var test = new CustomerController();
            ActionResult okType = test.GetCustomer(20);
            Assert.That(okType, Is.TypeOf<Ok>());
        }
    }
}
