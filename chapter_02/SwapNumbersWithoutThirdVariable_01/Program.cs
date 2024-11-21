// Program to Swap Numbers Without Third Variable with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace SwapNumbersWithoutThirdVariable_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Swap Numbers Without Third Variable with C# in Visual Studio.\n");

            int FirstNumber = 17;
            int SecondNumber = 23;

            Console.WriteLine($"Before Swapping first Number {FirstNumber} , second Number {SecondNumber}");

            FirstNumber = FirstNumber + SecondNumber;
            SecondNumber = FirstNumber - SecondNumber;
            FirstNumber = FirstNumber - SecondNumber;

            Console.WriteLine($"After swapping first number: {FirstNumber} , second number: {SecondNumber}");

        }
    }
}
