using Microsoft.AspNetCore.Mvc;
using PhoneAppDesignPatterns.Services.Logging;
using PhoneAppDesignPatterns.Services.Payment;
using PhoneAppDesignPatterns.Services.Payment.Strategies;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly PaymentContext _paymentContext;
    private readonly IAppLogger _logger;

    public PaymentController(IAppLogger logger)
    {
        _logger = logger;
        _paymentContext = new PaymentContext(_logger);
    }

    [HttpPost("process")]
    public IActionResult ProcessPayment([FromQuery] string method, [FromQuery] decimal amount)
    {
        IPaymentStrategy strategy = method.ToLower() switch
        {
            "creditcard" => new CreditCardPayment(),
            "paypal" => new PayPalPayment(),
            "crypto" => new CryptoPayment(),
            _ => throw new ArgumentException("Invalid payment method")
        };

        _paymentContext.SetStrategy(strategy);
        var result = _paymentContext.ExecutePayment(amount);
        return Ok(result);
    }
}