namespace PhoneAppDesignPatterns.Services.Payment
{
    public interface IPaymentStrategy
    {
        string ProcessPayment(decimal amount);
    }
}