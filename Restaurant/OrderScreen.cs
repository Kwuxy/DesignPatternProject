using System;
using System.Runtime.InteropServices;
using Restaurant.Counter;
using Restaurant.Extras;
using Restaurant.Payment;
using Restaurant.Salad;

namespace Restaurant
{
    public class OrderScreen
    {
        private readonly IOrderBuilder _orderBuilder;
        private readonly SaladDecorator _saladDecorator;
        private readonly BarCounter _counter;

        public OrderScreen()
        {
            _orderBuilder = new OrderBuilder();
            _saladDecorator = new SaladDecorator();
            _counter = new BarCounter();
        }

        public void SetClient(Client client)
        {
            _orderBuilder.SetClient(client);
        }

        public void ChooseSalad(ISalad salad)
        {
            _saladDecorator.ChooseSalad(salad);
        }

        public void AddSaladTopping(ITopping topping)
        { 
            _saladDecorator.AddTopping(topping);
        }

        public void SetDessert(IDessert dessert)
        {
            _orderBuilder.SetDessert(dessert);
        }

        public void SetDrink(IDrink drink)
        {
            _orderBuilder.SetDrink(drink);
        }

        public void Pay(IPaymentStrategy strategy)
        {
            _orderBuilder.SetSalad(_saladDecorator.GetSalad());
            
            var order = _orderBuilder.Build();
            order.Pay(strategy);
            
            if (Math.Abs(order.AmountPaid) > 0.000001)
            {
                _counter.AssignOrder(order);
            }
            else
            {
                Console.WriteLine("Payment has failed... try again !");
            }
        }
    }
}