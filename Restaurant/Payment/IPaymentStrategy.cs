namespace Restaurant.Payment
{
    public interface IPaymentStrategy
    {
        double Pay(double amount);
    }
}