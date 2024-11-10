// Program to use Ref Keyword for Value Update with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace UsingRefKeywordForValueUpdate_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to use Ref Keyword for Value Update with C# in Visual Studio\n");

            // Declare and initialize a variable.
            int number = 10;

            // Pass the variable to the method using 'ref'.
            // 'ref' allows the method to modify the original variable.
            Console.WriteLine("Before: " + number + "\n");
            AddFive(ref number);
            Console.WriteLine("After: " + number);
        }

        // Method that takes an argument by reference.
        // Using 'ref' ensures the original value gets modified.
        public static void AddFive(ref int num)
        {
            num += 5;
        }

    }
}
