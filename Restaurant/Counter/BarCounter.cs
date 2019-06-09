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
            cook.CookMeal(order);
        }

        public void NotifyOrderIsReady(Order order)
        {
            order.Client.RingBiper();
        }
    }
}