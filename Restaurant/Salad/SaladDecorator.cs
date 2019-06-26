using Restaurant.CustomExceptions;

namespace Restaurant.Salad
{
    public class SaladDecorator
    {
        private IIngredient _ingredient;

        public void ChooseSalad(ISalad salad)
        {
            _ingredient = salad;
        }

        public void AddTopping(ITopping topping)
        {
            if(_ingredient == null)
                throw new SaladNotFoundException();
            
            topping.SetTopping(_ingredient);
            _ingredient = topping;
        }

        public IIngredient GetSalad()
        {
            return _ingredient;
        }
    }
}