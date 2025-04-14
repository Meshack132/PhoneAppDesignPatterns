// Models/Payment/Strategies/PayPalPayment.cs
namespace PhoneAppDesignPatterns.Services.Payment.Strategies
{
    public class PayPalPayment : IPaymentStrategy
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Processed R{amount} via PayPal";
        }
    }
}