// Program to create a Overloaded Functions with different parameters with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace OverloadingFunctionsWithDifferentParameters_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a overloaded functions with different parameters with C# in Visual Studio.\n");

            // Calling overloaded functions with different parameters.
            Console.WriteLine("Sum of integers: " + AddNumbers(5,10));
            Console.WriteLine("Sum of doubles: " + AddNumbers(5.4, 10.9));
        }
        // Function to add two integers.
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        // Overloaded function to add two doubles.
        public static double AddNumbers(double a, double b)
        {
            return a + b;
        }
    }
}
