// Program to create a Tuple Deconstruction with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace TupleDeconstruction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Tuple Deconstruction with C# in Visual Studio.\n");

            // Create a tuple with three values.
            var product = (101, "Laptop", 75000);

            // Deconstruct the tuple into separate variables.
            var (id,name,price) = product;

            Console.WriteLine("Product ID: " + id);
            Console.WriteLine("Product Name: " + name);
            Console.WriteLine("Product Price: " + price);

        }
    }
}
