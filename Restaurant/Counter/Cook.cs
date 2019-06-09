
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

        public void CookMeal(Order order)
        {
            System.Threading.Thread.Sleep(1000);
            
            Counter.NotifyOrderIsReady(order);
        }
        
    }
}