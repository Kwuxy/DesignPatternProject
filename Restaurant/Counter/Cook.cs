using System;
using System.Threading.Tasks;

namespace Restaurant.Counter
{
    public class Cook
    {
        public string Name { get; private set; }
        private BarCounter _counter;
        private bool _isBusy;
        
        public Cook(string name, BarCounter counter)
        {
            Name = name;
            _counter = counter;
            _isBusy = false;
        }

        public void CookMeal(Order order)
        {
            System.Threading.Thread.Sleep(1000);
            
            order.IsReady = true;
            SetIsBusy(false);

            _counter.NotifyOrderIsReady(order);
        }

        public void SetIsBusy(bool busy)
        {
            _isBusy = busy;
        }
        
        public bool IsBusy()
        {
            return _isBusy;
        }
        
        
    }
}