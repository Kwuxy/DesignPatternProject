using System.Collections.Generic;
using Restaurant.CustomExceptions;
using Restaurant.Extras;
using Restaurant.Salad;

namespace Restaurant
{
    public class OrderBuilder
    {
        private Client _client;
        private IDessert _dessert;
        private IDrink _drink;
        private IIngredient _salad;

        public OrderBuilder()
        {
        }

        public OrderBuilder SetClient(Client client)
        {
            _client = client;
            return this;
        }

        public OrderBuilder SetSalad(IIngredient ingredient)
        {
            _salad = ingredient;
            return this;
        }

        public OrderBuilder SetDessert(IDessert dessert)
        {
            _dessert = dessert;
            return this;
        }
        
        public OrderBuilder SetDrink(IDrink drink)
        {
            _drink = drink;
            return this;
        }

        public Order Build()
        {
            if(_client == null)
                throw new ClientNotFoundException();
            if(_dessert == null && _drink == null && _salad == null)
                throw new NothingToOrderException();
            return new Order(_client, _salad, _dessert, _drink);
        }
        
    }
}