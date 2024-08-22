using Microsoft.VisualStudio.TestTools.UnitTesting;
using BonusApp.Code;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Order order;

        [TestInitialize]
        public void SetUp()
        {
            order = new Order();
            order.AddProduct(new Product { Value = 45.0 });
        }

        [TestMethod]
        public void GetBonusAnonymous_Test()
        {
            // Act & Assert for TenPercent bonus
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(4.5, order.GetBonus());

            // Act & Assert for FlatTwoIfAmountMoreThanFive bonus
            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]
        public void GetBonusByLambdaParameter_Test()
        {
            // Act & Assert for TenPercent lambda expression
            Assert.AreEqual(4.5, order.GetBonus(amount => amount * 0.1));

            // Act & Assert for FlatTwoIfAmountMoreThanFive lambda expression
            Assert.AreEqual(2.0, order.GetBonus(amount => amount > 5.0 ? 2.0 : 0.0));
        }

        [TestMethod]
        public void GetTotalPriceByLambdaParameter_Test()
        {
            // Act & Assert for TenPercent lambda expression
            Assert.AreEqual(40.5, order.GetTotalPrice(amount => amount * 0.1));

            // Act & Assert for FlatTwoIfAmountMoreThanFive lambda expression
            Assert.AreEqual(43.0, order.GetTotalPrice(amount => amount > 5.0 ? 2.0 : 0.0));
        }
    }
}
