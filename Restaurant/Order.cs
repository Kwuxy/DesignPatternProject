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
        
        public bool IsReady { get; set; }
        
        public double AmountPaid { get; private set; }
        

        public Order(Client client, IIngredient salad, IDessert dessert, IDrink drink)
        {
            Client = client;
            Salad = salad;
            Dessert = dessert;
            Drink = drink;
            
            Client.Order = this;
        }
        
        public double Pay(IPaymentStrategy strategy)
        {
            AmountPaid = strategy.Pay(GetPrice());
            return AmountPaid;
        }
        
        public double GetPrice()
        {
            double price = 0;
            price += Dessert?.GetPrice() ?? 0;
            price += Drink?.GetPrice() ?? 0;
            price += Salad?.GetPrice() ?? 0;
            return price;
        }

        
    }
}