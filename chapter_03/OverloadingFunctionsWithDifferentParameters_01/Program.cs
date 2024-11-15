// Program to create a Function with Ref parameter with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace FunctionWithRefParameter_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Function with Ref parameter with C# in Visual Studio.\n");

            int number = 10;

            // Passing number by reference to the SquareNumber function.
            SquareNumber(ref number);
            Console.WriteLine("Squared number: " + number);  
        }
        // Function to square a number using ref parameter.
        public static void SquareNumber(ref int value)
        {
            // Multiply value by itself.
            value *= value;
        }
    }
}
