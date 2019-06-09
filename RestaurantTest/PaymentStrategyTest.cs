using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using Restaurant.Payment;
using Restaurant.Salad;

namespace RestaurantTest
{
    [TestClass()]
    public class PaymentStrategyTest
    {
        [TestMethod()]
        public void Should9PaidInCash_return9Paid()
        {
            Assert.AreEqual(9,new CashPayment().Pay(9));
        }
        
        [TestMethod()]
        public void Should9PaidInCredit_With3Payments_return3Paid()
        {
            Assert.AreEqual(3.3,new CreditPayment(new ThreePayments()).Pay(9), 0.00000001);
        }
        
        [TestMethod()]
        public void Should9PaidInCredit_With10Payments_return1Paid()
        {
            Assert.AreEqual(1.035,new CreditPayment(new TenPayments()).Pay(9), 0.00000001);
        }
    }
}