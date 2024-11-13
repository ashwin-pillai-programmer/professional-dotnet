// Program to return Tuple from a Method with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace ReturningTupleFromMethod_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to return Tuple from a Method with C# in Visual Studio.\n");

            // Call the GetEmployeeData method which returns a Tuple with ID and Name.
            var employee = GetEmployeeData();

            Console.WriteLine("Employee ID: " + employee.Item1);
            Console.WriteLine("Employee Name: " + employee.Item2);
        }
        // Method that returns a Tuple containing an int and a string.
        public static Tuple<int,string> GetEmployeeData()
        {
            // Return a new Tuple object with ID and Name.
            return new Tuple<int, string>(15, "Alice");
        }
    }
}
