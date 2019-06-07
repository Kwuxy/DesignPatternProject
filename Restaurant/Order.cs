using System;
using System.Collections.Generic;
using System.Linq;
using Restaurant.Extras;
using Restaurant.Payment;
using Restaurant.Salad;

namespace Restaurant
{
    public class Order
    {
        public Client Client { get; private set; }
        public List<IExtra> Extras { get; private set; }
        public IIngredient Salad { get; private set; }

        public Order(Client client, List<IExtra> extras, IIngredient salad)
        {
            Client = client;
            Extras = extras;
            Salad = salad;
        }
        
        public double GetPrice()
        {
            return Extras.Sum(x => x.GetPrice()) + Salad.GetPrice();
        }

        public bool Pay(IPaymentStrategy strategy)
        {
            throw new NotImplementedException();
        }
    }
}