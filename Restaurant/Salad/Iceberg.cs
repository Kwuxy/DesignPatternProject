namespace Restaurant.Salad
{
    public class Iceberg : ISalad
    {
        private const double Price = 5;
        public double GetPrice()
        {
            return Price;
        }
    }
}