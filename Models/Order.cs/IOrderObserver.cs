namespace PhoneAppDesignPatterns.Services.Order
{
    public interface IOrderObserver
    {
        void Update(Order order);
    }
}