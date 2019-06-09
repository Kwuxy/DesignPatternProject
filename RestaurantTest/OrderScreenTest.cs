using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using Restaurant.Extras;
using Restaurant.Payment;
using Restaurant.Salad;

namespace RestaurantTest
{
    [TestClass()]
    public class OrderScreenTest
    {
        private OrderScreen _orderScreen;

        [TestInitialize()]
        public void Initialize()
        {
            _orderScreen = new OrderScreen();
        }
        
        [TestMethod()]
        public void ShouldCreatePayAndProcessOrder()
        {
            var client = new Client("Visitor");
            
            Assert.IsFalse(client.IsServed);
            
            _orderScreen.SetClient(client);
            _orderScreen.ChooseSalad(new Batavia());
            _orderScreen.AddSaladTopping(new Avocado());
            _orderScreen.AddSaladTopping(new ChickPeas());
            _orderScreen.AddSaladTopping(new Chicken());
            _orderScreen.SetDrink(new Soda());
            _orderScreen.Pay(new CreditPayment(new TenPayments()));
            
            Assert.IsTrue(client.Order.IsReady);
            Assert.IsInstanceOfType(client.Order.Drink, typeof(Soda));
            Assert.AreEqual(17, client.Order.GetPrice());
            Assert.AreEqual(1.955,client.Order.AmountPaid, 0.000001);
            Assert.IsTrue(client.IsServed);
            
        }
        
    }
}