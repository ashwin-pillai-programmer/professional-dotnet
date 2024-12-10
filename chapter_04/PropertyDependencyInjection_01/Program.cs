// Program to create a Property Dependency Injection with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace PropertyDependencyInjection_01
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
        public IMessageService messageService { get; set; }

        public void Notify(string message)
        {
            messageService?.SendMessage(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Property Dependency Injection with C# in Visual Studio.\n");

            Notification notification = new Notification()
            {
                messageService = new EmailService()
            };

            notification.Notify("Property injection Example");
        }
    }
}
