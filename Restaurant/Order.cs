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
        public IDessert Dessert { get; private set; }
        public IDrink Drink { get; private set; }
        public IIngredient Salad { get; private set; }

        public Order(Client client, IIngredient salad, IDessert dessert, IDrink drink)
        {
            Client = client;
            Salad = salad;
            Dessert = dessert;
            Drink = drink;
        }
        
        public double GetPrice()
        {
            double price = 0;
            price += Dessert?.GetPrice() ?? 0;
            price += Drink?.GetPrice() ?? 0;
            price += Salad?.GetPrice() ?? 0;
            return price;
        }

        public bool Pay(IPaymentStrategy strategy)
        {
            throw new NotImplementedException();
        }
    }
}