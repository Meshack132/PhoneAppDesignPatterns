// Controllers/OrderController.cs
using Microsoft.AspNetCore.Mvc;
using PhoneAppDesignPatterns.Services.Logging;
using PhoneAppDesignPatterns.Services.Order;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IAppLogger _logger;

    public OrderController(IAppLogger logger)
    {
        _logger = logger;
    }

    [HttpPut("status")]
    public IActionResult UpdateStatus([FromQuery] string newStatus)
    {
        var order = new Order(_logger);
        order.Status = newStatus;
        return Ok($"Order status updated to {newStatus}");
    }
}