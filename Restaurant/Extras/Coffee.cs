namespace Restaurant.Extras
{
    public class Coffee : IDrink
    {
        private const double Price = 2;
        public double GetPrice()
        {
            return Price;
        }
    }
}