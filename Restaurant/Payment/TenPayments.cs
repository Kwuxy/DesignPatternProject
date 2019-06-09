namespace Restaurant.Payment
{
    public class TenPayments : ICreditType
    {
        private const int _numberOfPayments = 10;
        private const double _tax = 0.15;


        public int GetNumberOfPayments()
        {
            return _numberOfPayments;
        }

        public double GetTax()
        {
            return _tax;
        }
    }
}