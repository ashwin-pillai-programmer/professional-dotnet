// Program to create a recursive Function with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace RecursiveFunction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a recursive Function with C# in Visual Studio.\n");

            int number = 5;
            Console.WriteLine("Factorial of " + number + " is " + Factorial(number));  
        }
        // Recursive function to calculate factorial.
        public static int Factorial(int n)
        {
            if (n == 1)
            {
                // Base case
                return 1;
            }
            else 
            {
                // Recursive call
                return n * Factorial(n - 1);
            }
        }
    }
}
