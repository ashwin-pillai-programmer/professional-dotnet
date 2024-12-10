// Program to create a Method Dependency Injection with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace MethodDependencyInjection_01
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
        public void Notify(string message, IMessageService messageService)
        {
            messageService.SendMessage(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Method Dependency Injection with C# in Visual Studio.\n");

            Notification notification = new Notification();
            IMessageService emailservice = new EmailService();

            notification.Notify("Method injection example", emailservice);
        }
    }
}
