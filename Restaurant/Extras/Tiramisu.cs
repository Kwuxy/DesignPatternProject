namespace Restaurant.Extras
{
    public class Tiramisu : IDessert
    {
        private const double Price = 3.5;
        public double GetPrice()
        {
            return Price;
        }
    }
}