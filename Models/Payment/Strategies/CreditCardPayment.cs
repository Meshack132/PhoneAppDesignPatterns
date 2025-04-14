namespace PhoneAppDesignPatterns.Services.Payment.Strategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        string IPaymentStrategy.ProcessPayment(decimal amount)
        {
            return $"Processed R{amount} via Credit Card";
        }
    }
}