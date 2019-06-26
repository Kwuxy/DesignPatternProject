using System.Collections.Generic;
using Restaurant.CustomExceptions;
using Restaurant.Extras;
using Restaurant.Salad;

namespace Restaurant
{
    public class OrderBuilder : IOrderBuilder
    {
        private Client _client;
        private IDessert _dessert;
        private IDrink _drink;
        private IIngredient _salad;

        public OrderBuilder()
        {
        }

        public IOrderBuilder SetClient(Client client)
        {
            _client = client;
            return this;
        }

        public IOrderBuilder SetSalad(IIngredient ingredient)
        {
            _salad = ingredient;
            return this;
        }

        public IOrderBuilder SetDessert(IDessert dessert)
        {
            _dessert = dessert;
            return this;
        }
        
        public IOrderBuilder SetDrink(IDrink drink)
        {
            _drink = drink;
            return this;
        }

        public Order Build()
        {
            if (_client == null)
                throw new ClientNotFoundException();
            if(_dessert == null && _drink == null && _salad == null)
                throw new NothingToOrderException();
            return new Order(_client, _salad, _dessert, _drink);
        }
        
    }
}