namespace PhoneAppDesignPatterns.Services.Order.Observers
{
    public class NotificationService : IOrderObserver
    {
        public void Update(Order order) =>
            Console.WriteLine($"Notification: Order status changed to {order.Status}");
    }
}