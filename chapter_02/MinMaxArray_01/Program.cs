// Program to identify the Minimum Maximum value in Array with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace MinMaxArray_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to identify the Minimum Maximum value in Array with C# in Visual Studio.\n");

            int[] numbers = { 7, 8, 5, 3, 4, 6 };

            int min = numbers[0];
            int max = numbers[0];

            foreach(int number in numbers)
            {
                if(number <  min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"Min: {min} Max: {max}");

            // Using built-in functions
            Console.WriteLine($"Min: {numbers.Min()} Max: {numbers.Max()}"); 
        }
    }
}
