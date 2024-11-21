// Program to check whether the number is Prime or Not with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace PrimeNumberCheck_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to check whether the number is Prime or Not with C# in Visual Studio.\n");

            Console.Write("Enter the number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if(IsPrime(number))
            {
                Console.WriteLine($"{number} is  prime number");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number");
            }
        }
        static bool IsPrime(int number)
        {
            if(number <= 1)
            {
                return false;
            }
            else
            {
                for(int loopcounter = 2; loopcounter * loopcounter < number; loopcounter++)
                {
                    return false ;
                }
                return true ;
            }
        }
    }
}
