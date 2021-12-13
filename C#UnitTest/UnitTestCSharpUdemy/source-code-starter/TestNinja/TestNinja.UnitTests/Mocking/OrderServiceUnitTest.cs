using System;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceUnitTest
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            OrderService os = new OrderService(storage.Object);

            var order = new Order();
            os.PlaceOrder(order);
            storage.Verify(s => s.Store(order)); 

        }
        [Test]
        public void PlaceOrder_whenCorrectOrderPlace_returnOrderId()
        {
            var storage = new Mock<IStorage>();
            storage.Setup(str => str.Store(It.IsAny<Object>())).Returns(10);
            OrderService os = new OrderService(storage.Object);
            var result = os.PlaceOrder(new Order());
            Assert.That(result, Is.EqualTo(10));
        }
    }
}
