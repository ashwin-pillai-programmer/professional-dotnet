// Program to create Three values using tuples with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace UsingTupleWithThreeValues_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create Three values using tuples with C# in Visual Studio.\n");

            // Creating a Tuple with three values: int, string, and double.
            Tuple<int, string, double> student = new Tuple<int, string, double>(1, "Tom", 80.75);

            // Accessing the three elements of the tuple.
            Console.WriteLine($"Student ID: {student.Item1}");
            Console.WriteLine($"Student Name: {student.Item2}");
            Console.WriteLine($"Student Percentage: {student.Item3}");
        }
    }
}
