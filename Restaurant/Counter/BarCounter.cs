using System;
using System.Collections.Generic;

namespace Restaurant.Counter
{
    public class BarCounter
    {
        private Queue<Order> _waitingOrders;
        private List<Cook> _cooks;

        public BarCounter()
        {
            _cooks = PopulateCooks();
            _waitingOrders = new Queue<Order>();
        }

        public void AssignOrder(Order order)
        {
            foreach (var cook in _cooks)
            {
                if (!cook.IsBusy)
                {
                    cook.CookMeal(order);
                    return;
                }
            }
            
            _waitingOrders.Enqueue(order);
        }

        public void NotifyOrderIsReady(Order order)
        {
            order.Client.RingBiper();
            
            CheckIfAnOrderIsWaiting();
        }

        private void CheckIfAnOrderIsWaiting()
        {
            if (_waitingOrders.Count > 0)
            {
                AssignOrder(_waitingOrders.Dequeue());
            }
        }

        private List<Cook> PopulateCooks()
        {
            var cooks = new List<Cook>();
            
            cooks.Add(new Cook("Vincent", this));
            cooks.Add(new Cook("Alexis", this));
            cooks.Add(new Cook("Célia", this));

            return cooks;
        }
    }
}