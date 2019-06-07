namespace Restaurant.Salad
{
    public class ChickPeas : ITopping
    {
        private const double Price = 2;
        
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