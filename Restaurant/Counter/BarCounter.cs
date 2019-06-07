using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Counter
{
    public class BarCounter
    {
        public Queue<Order> WaitingOrders { get; set; }
        private readonly List<Cook> _cooks;

        public BarCounter()
        {
            _cooks = PopulateCooks();
            WaitingOrders = new Queue<Order>();
        }

        public void AssignOrder(Order order)
        {
            foreach (var cook in _cooks)
            {
                if (!cook.IsBusy())
                {
                    cook.SetIsBusy(true);
                    Task.Run(() => cook.CookMeal(order));
                    return;
                }
            }
            WaitingOrders.Enqueue(order);
        }

        public void NotifyOrderIsReady(Order order)
        {
            order.Client.RingBiper();
            
            CheckIfAnOrderIsWaiting();
        }

        private void CheckIfAnOrderIsWaiting()
        {
            if (WaitingOrders.Count > 0)
            {
                AssignOrder(WaitingOrders.Dequeue());
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