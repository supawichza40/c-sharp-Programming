using System;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class ProductUnitTests
    {
        Customer customer;
        Product pd;
        [SetUp]
        public void SetUp()
        {
            customer = new Customer();
            pd = new Product();
            pd.ListPrice = 100;
        }
        [Test]
        public void GetPrice_WhenGoldCustomer_ReturnThirtyPercentOffDiscount()
        {

            customer.IsGold = true;


            var result = pd.GetPrice(customer);

            Assert.That(result, Is.EqualTo(70));
        }
    }
}
