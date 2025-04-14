using PhoneAppDesignPatterns.Services.Logging;

namespace PhoneAppDesignPatterns.Services.Payment
{
    public class PaymentContext
    {
        private IPaymentStrategy _strategy;
        private readonly IAppLogger _logger;

        public PaymentContext(IAppLogger logger)
        {
            _logger = logger;
        }

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
            _logger.Log($"Payment strategy set to {strategy.GetType().Name}");
        }

        public string ExecutePayment(decimal amount)
        {
            var result = _strategy.ProcessPayment(amount);
            _logger.Log($"Payment processed: {result}");
            return result;
        }
    }
}