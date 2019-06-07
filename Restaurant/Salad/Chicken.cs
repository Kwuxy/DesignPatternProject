namespace Restaurant.Salad
{
    public class Chicken : ITopping
    {
        private const double Price = 4;
        
        public IIngredient Ingredient { get; set; }
        
        public double GetPrice()
        {
            return Price + Ingredient.GetPrice();
        }
        
        public void SetTopping(IIngredient ingredient)
        {
            Ingredient = ingredient;
        }
    }
}