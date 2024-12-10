// Program to create a Basic Constructor Dependency Injection with Ilogger with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace BasicConstructorDependencyInjection_02
{
    // Define an interface for logging
    public interface Ilogger
    {
        void Log(string message);
    }
    // Implementation of a Console Logger
    public class ConsoleLogger : Ilogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Console log: " + message);
        }
    }
    // A service that depends on ILogger
    public class Service
    {
        private readonly Ilogger _logger;

        // Inject ILogger dependency via the constructor
        public Service(Ilogger logger)
        { 
            _logger = logger;
        }
        public void PerformTask()
        {
            _logger.Log("Performing a task...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Basic Constructor Dependency Injection with Ilogger with C# in Visual Studio.\n");

            // Dependency Injection
            Ilogger logger = new ConsoleLogger();
            Service service = new Service(logger);

           service.PerformTask();
        }
    }
}
