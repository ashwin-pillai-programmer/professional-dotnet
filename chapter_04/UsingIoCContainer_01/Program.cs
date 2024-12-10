// Program to demonstrate the use IoC Container with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace UsingIoCContainer_01
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }
    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use IoC Container with C# in Visual Studio.\n");

            var services = new ServiceCollection();
            services.AddTransient<IMessageService, EmailService>();
            services.AddTransient<Notification>();

            var serviceProvider = services.BuildServiceProvider();

            var notification = serviceProvider.GetService<Notification>();
            notification.Notify("Using the Ioc container");
        }
    }
}
