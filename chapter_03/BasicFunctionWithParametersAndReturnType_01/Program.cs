// Program to create a basic Function with Parameter and return type with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace BasicFunctionWithParametersAndReturnType_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a basic Function with Parameter and return type with C# in Visual Studio.\n");

            // Calling the AddNumbers function and storing the result.
            int result = AddNumbers(5, 10);

            // Display the result
            Console.WriteLine("Sum: " + result);
        }
        /// <summary>
        /// Adds two integers and returns the sum.
        /// </summary>
        /// <param name="a">The first integer value.</param>
        /// <param name="b">The second integer value.</param>
        /// <returns>Returns the sum of a and b.</returns>
        public static int AddNumbers(int a, int b)
        {
            // Adding a and b and returning the result.
            return a + b;
        }
    }
}
