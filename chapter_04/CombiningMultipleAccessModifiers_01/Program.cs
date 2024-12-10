// Program to Combine Multiple Access Modifiers with C# in Visual Studio.
// Programmer : Ashwin Pillai

using System.Security.Cryptography.X509Certificates;

namespace CombiningMultipleAccessModifiers_01
{
    class Document
    {
        // Accessible in derived class or within the same assembly
        protected internal string title;

        public Document(string docTitle)
        {
            title = docTitle;
        }
        // Accessible in derived class within the same assembly
        private protected void DisplayDocTitle()
        {
            Console.WriteLine($"Document Title: {title}");
        }
    }
    class Report : Document
    {
        public Report(string title) : base(title) { }
        public void DisplayReportTitle()
        {
           DisplayDocTitle();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Combine Multiple Access Modifiers with C# in Visual Studio.\n");

            Report book = new Report("Daily Report");
            book.DisplayReportTitle();
        }
    }
}
