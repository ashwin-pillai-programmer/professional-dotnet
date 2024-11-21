// Program to demonstrate Palindrome Check with C# in Visual Studio.
// Programmer : Ashwin Pillai

using System.ComponentModel.DataAnnotations;

namespace PalindromeCheck_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Palindrome Check with C# in Visual Studio.\n");

            Console.Write("Enter the string: ");

            string? input = Console.ReadLine();

            if(IsPalindrome(input))
            {
                Console.WriteLine("Is a Palindrome");
            }
            else
            {
                Console.WriteLine("Is not a Palindrome");
            }
        }
        static bool IsPalindrome(string input)
        {
            int length = input.Length;

            for(int loopcounter = 0; loopcounter < length / 2; loopcounter++)
            {
                if (input[loopcounter] != input[length - loopcounter - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
