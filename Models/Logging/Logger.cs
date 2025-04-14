// Models/Logging/Logger.cs
namespace PhoneAppDesignPatterns.Services.Logging
{
    public sealed class Logger : IAppLogger
    {
        private static Logger? _instance;
        private static readonly object _lock = new();

        // Public constructor required for DI
        public Logger() { }

        // Singleton instance accessor
        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new Logger();
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }
    }
}