// Models/Order/Order.cs
using PhoneAppDesignPatterns.Services.Logging;
using PhoneAppDesignPatterns.Services.Order.Observers;

namespace PhoneAppDesignPatterns.Services.Order
{
    public class Order
    {
        private readonly OrderSubject _subject;
        private string? _status;

        public Order(IAppLogger logger)
        {
            _subject = new OrderSubject(logger);
            _subject.Attach(new NotificationService());
            _subject.Attach(new InventoryService());
        }

        public string? Status
        {
            get => _status;
            set
            {
                _status = value;
                _subject.Notify(this);
            }
        }
    }

    public class OrderSubject
    {
        private readonly List<IOrderObserver> _observers = new();
        private readonly IAppLogger _logger;

        public OrderSubject(IAppLogger logger)
        {
            _logger = logger;
        }

        public void Attach(IOrderObserver observer)
        {
            _observers.Add(observer);
            _logger.Log($"Observer {observer.GetType().Name} attached");
        }

        public void Notify(Order order)
        {
            foreach (var observer in _observers)
            {
                observer.Update(order);
            }
        }
    }
}