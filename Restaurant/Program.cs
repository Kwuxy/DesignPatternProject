using System;
using System.Threading;
using Restaurant.Counter;
using Restaurant.Extras;
using Restaurant.Salad;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new BarCounter();
            
            
            counter.AssignOrder(new Order(new Client("Nicolas"), new Batavia(), new Tiramisu(), new Coffee()));
            System.Threading.Thread.Sleep(1000);
            counter.AssignOrder(new Order(new Client("Ornella"), new Batavia(), new Tiramisu(), new Coffee()));
            System.Threading.Thread.Sleep(1000);
            counter.AssignOrder(new Order(new Client("Ifan"), new Batavia(), new Tiramisu(), new Coffee()));
            System.Threading.Thread.Sleep(1000);
            counter.AssignOrder(new Order(new Client("Jean"), new Batavia(), new Tiramisu(), new Coffee()));

            
        }
    }
}