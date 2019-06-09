namespace Restaurant.Payment
{
    public class ThreePayments : ICreditType
    {
        private const int _numberOfPayments = 3;
        private const double _tax = 0.10;
        
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