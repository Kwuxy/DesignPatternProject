namespace Restaurant.Payment
{
    public interface ICreditType
    {
        int GetNumberOfPayments();
        double GetTax();
    }
}