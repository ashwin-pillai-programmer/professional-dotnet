// Program to create a Named Tuple using value with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace NamedTuplesUsingValueTuple_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Named Tuple using value with C# in Visual Studio.\n");

            // Create a ValueTuple with named elements for better readability.
            (int id, string name, double salary)employee = (13, "Emma", 100000);

            // Access Tuple elements by name.
            Console.WriteLine("Employee Id: " + employee.Item1);
            Console.WriteLine("Employee Name: " + employee.Item2);
            Console.WriteLine("Employee Salary: " + employee.Item3);
        }
    }
}
