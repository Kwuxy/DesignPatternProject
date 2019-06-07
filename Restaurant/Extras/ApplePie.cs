namespace Restaurant.Extras
{
    public class ApplePie : IDessert
    {
        private const double Price = 3;
        public double GetPrice()
        {
            return Price;
        }
    }
}