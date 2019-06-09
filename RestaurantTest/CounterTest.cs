using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using Restaurant.Counter;
using Restaurant.Salad;

namespace RestaurantTest
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod()]
        public void ShouldOrder_BeCookedThenReady()
        {
            var client = new Client("Visitor");
            var order = new Order(client, new Batavia(), null, null );
            new BarCounter().AssignOrder(order);
            Assert.IsTrue(client.IsServed);
        }
        
    }
}