// Program to create a Basic Constructor Dependency injection with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace BasicConstructorDependencyInjection_01
{
    // Define a Service Interface
    public interface IMessageService
    {
        void SendMessage(string message);
    }
    // Implement the Service
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }
    // Class that depends on IMessageService
    public class Notification
    {
        public readonly IMessageService _messageservice;

        public Notification(IMessageService messageservice)
        {
            _messageservice = messageservice;
        }

        public void Notify(string message)
        {
            _messageservice.SendMessage(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Basic Constructor Dependency injection with C# in Visual Studio.\n");

            // Manual Dependency Injection: Pass an instance of EmailService
            IMessageService emailservice = new EmailService();
            Notification notification = new Notification(emailservice);

            notification.Notify("Hello via DI");
        }
    }
}
