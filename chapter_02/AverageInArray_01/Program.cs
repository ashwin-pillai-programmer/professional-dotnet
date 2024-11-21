// Program to create an Average In Array with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace AverageInArray_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Average In Array with C# in Visual Studio.\n");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Average: {(double) sum / numbers.Length}");
            Console.WriteLine($"Average: {numbers.Average()}");

        }
    }
}
