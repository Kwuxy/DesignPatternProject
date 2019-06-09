using System;

namespace Restaurant
{
    public class Client
    {
        public string Name { get; private set; }
        public bool IsServed { get; private set; }
        
        public Order Order { get; set; }
        
        

        public Client(string name)
        {
            Name = name;
        }

        public void RingBiper()
        {
            Console.WriteLine("{0}'s order is served !", Name);
            IsServed = true;
        }
    }
}