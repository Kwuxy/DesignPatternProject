namespace Restaurant.Salad
{
    public class Batavia : ISalad
    {
        private const double Price = 6;

        public double GetPrice()
        {
            return Price;
        }
    }
}