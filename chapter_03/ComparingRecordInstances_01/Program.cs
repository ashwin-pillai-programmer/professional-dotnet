// Program to Compare record Instances with C# in Visual Studio
// Programmer : Ashwin Pillai


namespace ComparingRecordInstances_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to Compare record Instances with C# in Visual Studio\n");

            // Creating two instances of 'Person' record with the same values
            Person person1 = new Person("Alice",25);
            Person person2 = new Person("Alice",25);

            // Using the equality operator (==) to check if both instances are equal.
            // Since records use value-based equality, this will return true.
            Console.WriteLine(person1 == person2);
        }
    }
    // A record named 'Person' that holds information about a person.
    // Records automatically provide value-based equality checks.
    public record Person(string Name,int Age);
}
