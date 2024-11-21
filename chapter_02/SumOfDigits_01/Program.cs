// Program to demonstrate Sum Of Digits with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace SumOfDigits_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Sum Of Digits with C# in Visual Studio.\n");

            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers: {input}, Sum of digits:{SumOfDigits(input)}");
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;    

            while(number > 0)
            {
                // Extract last digit from a number
                int lastdigit = number % 10;

                // Add last digit to sum
                sum = sum + lastdigit;

                // Remove last digit from a number
                number = number / 10;
            }
            return sum;
        }
    }
}
