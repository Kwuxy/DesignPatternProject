namespace Restaurant.Extras
{
    public class Soda : IDrink
    {
        private const double Price = 3;
        public double GetPrice()
        {
            return Price;
        }
    }
}