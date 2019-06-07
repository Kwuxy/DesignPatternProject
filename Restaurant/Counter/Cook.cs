using System;

namespace Restaurant.Counter
{
    public class Cook
    {
        private string _name;
        private BarCounter _counter;
        public bool IsBusy { get; private set; }

        public Cook(string name, BarCounter counter)
        {
            _name = name;
            _counter = counter;
            IsBusy = false;
        }

        public void CookMeal(Order order)
        {
            IsBusy = true;
            
            Console.WriteLine("The cook " + _name + " is cooking the order of " + order.Client.Name);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("The cook " + _name + " has finished cooking the order of " + order.Client.Name);

            IsBusy = false;
            
            _counter.NotifyOrderIsReady(order);
        }
        
        
    }
}