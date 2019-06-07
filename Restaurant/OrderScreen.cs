using System;
using Restaurant.Counter;
using Restaurant.Extras;
using Restaurant.Payment;
using Restaurant.Salad;

namespace Restaurant
{
    public class OrderScreen
    {
        private OrderBuilder _orderBuilder;
        private SaladDecorator _saladDecorator;
        private BarCounter _counter;

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

        public void SetDrink(IDrink drink)
        {
            _orderBuilder.SetDrink(drink);
        }

        public void Pay(IPaymentStrategy strategy)
        {
            _orderBuilder.SetSalad(_saladDecorator.GetSalad());
            var order = _orderBuilder.Build();

            if (order.Pay(strategy))
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