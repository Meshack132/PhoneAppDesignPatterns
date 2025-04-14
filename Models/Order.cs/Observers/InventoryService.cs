namespace PhoneAppDesignPatterns.Services.Order.Observers
{
    public class InventoryService : IOrderObserver
    {
        public void Update(Order order) =>
            Console.WriteLine($"Inventory: Updated stock for order with status {order.Status}");
    }
}