using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using Restaurant.Counter;
using Restaurant.Salad;

namespace RestaurantTest
{
    [TestClass]
    public class CounterTest
    {
        private BarCounter _counter;
        
        [TestMethod()]
        public void ShouldOrder_BeReadyAfterSomeSeconds()
        {
            _counter = new BarCounter();
            var order = new Order(new Client("Visitor"), new Batavia(), null, null );
            _counter.AssignOrder(order);
            Assert.IsFalse(order.IsReady);
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(order.IsReady);
        }
        
        [TestMethod()]
        public void Should4thOrder_BeOnWaitingList()
        {
            _counter = new BarCounter();
            var order1 = new Order(new Client("Jean"), new Batavia(), null,null);
            var order2 = new Order(new Client("Louis"), new Batavia(), null,null);
            var order3 = new Order(new Client("Charles"), new Batavia(), null,null);
            var order4 = new Order(new Client("Jules"), new Batavia(), null,null);
            _counter.AssignOrder(order1);
            _counter.AssignOrder(order2);
            _counter.AssignOrder(order3);
            _counter.AssignOrder(order4);
            Assert.IsFalse(_counter.WaitingOrders.Contains(order1));
            Assert.IsFalse(_counter.WaitingOrders.Contains(order2));
            Assert.IsFalse(_counter.WaitingOrders.Contains(order3));
            Assert.IsTrue(_counter.WaitingOrders.Contains(order4));
        }

    }
}