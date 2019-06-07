using System;

namespace Restaurant
{
    public class Client
    {
        public string Name { get; private set; }
        private Order _order;

        public Client(string name)
        {
            Name = name;
        }

        public void RingBiper()
        {
            Console.WriteLine("ring");
        }
    }
}