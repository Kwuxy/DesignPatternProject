using System;

namespace Restaurant.Payment
{
    public class CreditPayment : IPaymentStrategy
    {
        private readonly ICreditType _creditType;
        
        public CreditPayment(ICreditType creditType)
        {
            _creditType = creditType;
        }
        
        public double Pay(double amount)
        {
            var amountPaid = (amount * (1 + _creditType.GetTax())) / _creditType.GetNumberOfPayments();
            Console.WriteLine("{0}$ were paid. {1} payments left.", amount, _creditType.GetNumberOfPayments());
            return amountPaid;
        }
    }
}