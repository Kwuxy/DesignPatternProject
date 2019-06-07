using System.Collections.Generic;
using Restaurant.CustomExceptions;
using Restaurant.Extras;
using Restaurant.Salad;

namespace Restaurant
{
    public class OrderBuilder
    {
        private Client _client;
        private List<IExtra> _extras;
        private IIngredient _salad;

        public OrderBuilder()
        {
            _extras = new List<IExtra>();
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

        public OrderBuilder AddExtra(IExtra extra)
        {
            _extras.Add(extra);
            return this;
        }

        public Order Build()
        {
            if(_client == null)
                throw new ClientNotFoundException();
            if(_extras == null || _salad == null)
                throw new NothingToOrderException();
            return new Order(_client, _extras, _salad);
        }
        
    }
}