
using System;

namespace Restaurant.Counter
{
    public class Cook
    {
        public string Name { get; private set; }
        public BarCounter Counter { get; private set; }
        
        
        public Cook(string name, BarCounter counter)
        {
            Name = name;
            Counter = counter;
        }

        public void PrepareOrder(Order order)
        {
            Console.WriteLine("The cook is preparing the order of {0}", order.Client.Name);
            order.IsReady = true;
            Counter.NotifyOrderIsReady(order);
        }
        
    }
}