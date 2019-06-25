using System;
using System.Collections.Generic;

namespace Restaurant.Counter
{
    public class BarCounter
    {
        private readonly Cook cook;

        public BarCounter()
        {
            cook = new Cook("Alain Ducasse", this);
        }

        public void AssignOrder(Order order)
        {
            cook.PrepareOrder(order);
        }

        public void NotifyOrderIsReady(Order order)
        {
            Console.WriteLine("The cook has notified the counter that the order is ready.");
            order.Client.RingBiper();
        }
    }
}