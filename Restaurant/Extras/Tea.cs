namespace Restaurant.Extras
{
    public class Tea : IDrink
    {
        private const double Price = 3;
        public double GetPrice()
        {
            return Price;
        }
    }
}