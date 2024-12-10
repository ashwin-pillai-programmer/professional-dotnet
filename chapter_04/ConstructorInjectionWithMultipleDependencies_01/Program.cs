// Program to create a Constructor Injection With Multiple Dependencies with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace ConstructorInjectionWithMultipleDependencies_01
{
    public interface ImessageService
    {
        void SendMessage(string message);
    }

    public class EmailService : ImessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    public class SmsService : ImessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sms sent: " + message);
        }
    }
    
    public class Notification
    {
        private readonly ImessageService _primaryService;
        private readonly ImessageService _backupService;

        public Notification(ImessageService primaryService, ImessageService backupService)
        {
            _primaryService = primaryService;
            _backupService = backupService;
        }
        public void Notify(string message)
        {
            _primaryService.SendMessage(message);
            _backupService.SendMessage(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Constructor Injection With Multiple Dependencies with C# in Visual Studio.\n");

            ImessageService emailservice = new EmailService();
            ImessageService smsservice = new SmsService();
            Notification notification = new Notification(emailservice, smsservice);

            notification.Notify("Di with multiple service");
        }
    }
}
