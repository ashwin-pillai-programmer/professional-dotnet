// Program to create a Tuple in LINQ query with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace TupleInLINQQuery_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Tuple in LINQ query with C# in Visual Studio.\n");

            // Array of numbers
            int[] numbers = { 1, 2, 3 };

            // Using LINQ query to select tuples with square values
            var results = numbers.Select(n => (number : n, Square : n * n));

            foreach(var result in results)
            {
                Console.WriteLine($"Number: {result.number}, Square: {result.Square}");
            }
        }
    }
}
