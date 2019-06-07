namespace Restaurant.Salad
{
    public interface ITopping : IIngredient
    {
        IIngredient Ingredient { get; set; }
        void SetTopping(IIngredient ingredient);
    }
}