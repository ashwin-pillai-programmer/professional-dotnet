// Program to create a Basic Tuple with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace CreatingBasicTuple_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Basic Tuple with C# in Visual Studio.\n");

            // Creating a Tuple to hold two values, both an integer and a string.
            Tuple<int, string> person = new Tuple<int, string> ( 1, "Alice" );

            Console.WriteLine("ID: " + person.Item1); // doubt :- how this item1 came as it is not defined.
            Console.WriteLine("Name: " + person.Item2);
        }
    }
}
