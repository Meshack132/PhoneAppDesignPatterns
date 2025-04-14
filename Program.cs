// Program.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PhoneAppDesignPatterns.Services.Logging;
using PhoneAppDesignPatterns.Services.Payment;
using PhoneAppDesignPatterns.Services.Payment.Strategies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// // Register Logger as a singleton instance
builder.Services.AddSingleton<IAppLogger>(Logger.Instance);

// Register Strategies
builder.Services.AddTransient<IPaymentStrategy, CreditCardPayment>();
builder.Services.AddTransient<IPaymentStrategy, PayPalPayment>();
builder.Services.AddTransient<IPaymentStrategy, CryptoPayment>();

var app = builder.Build();

app.MapControllers();
app.Run();