// Program to create a Base Record Declaratiom with C# in Visual Studio
// Programmer : Ashwin Pillai

using System.Xml.Linq;

namespace BasicRecordDeclaration_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Base Record Declaratiom with C# in Visual Studio\n");

            // Creating an instance of the 'Person' record
            Person person1 = new Person("John",30);

            // Displaying the properties of the record
            Console.WriteLine($"Name: {person1.Name}");
            Console.WriteLine($"Age: {person1.Age}");
        }
    }
    // Declaring a simple record named 'Person'.
    // A record is a reference type that provides a way to encapsulate data.
    // Records are immutable by default, meaning their values cannot be changed once assigned
    public record Person(string Name, int Age);
}
