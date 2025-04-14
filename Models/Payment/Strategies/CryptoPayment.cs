namespace PhoneAppDesignPatterns.Services.Payment.Strategies
{
    public class CryptoPayment : IPaymentStrategy
    {
        public string ProcessPayment(decimal amount) =>
            $"Processed R{amount} via Cryptocurrency";
    }
}