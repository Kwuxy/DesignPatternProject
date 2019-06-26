using Restaurant.Extras;
using Restaurant.Salad;

namespace Restaurant
{
    public interface IOrderBuilder
    {
        IOrderBuilder SetClient(Client client);
        IOrderBuilder SetSalad(IIngredient salad);
        IOrderBuilder SetDessert(IDessert dessert);
        IOrderBuilder SetDrink(IDrink drink);
        Order Build();
    }
}