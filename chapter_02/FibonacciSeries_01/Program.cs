// Program to create a Fibonacci Series with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace FibonacciSeries_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Fibonacci Series with C# in Visual Studio.\n");

            Console.Write("Enter the terms: ");

            int terms = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < terms; i++)
            {
                Console.WriteLine($"{Fibonacci(i)}");
            }
        }
        static int Fibonacci(int terms)
        {
            if(terms <= 1)
            {
                // Base condition
                return terms; 
            }
            else
            {
                // Incremental or decremental recursive calling
                return Fibonacci(terms - 1) + Fibonacci(terms - 2); 
            }
        }
    }
}
