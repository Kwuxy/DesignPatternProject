using System;

namespace Restaurant.Payment
{
    public class CashPayment : IPaymentStrategy
    {
        public double Pay(double amount)
        {
            Console.WriteLine("{0}$ paid in cash.", amount);
            return amount;
        }
    }
}