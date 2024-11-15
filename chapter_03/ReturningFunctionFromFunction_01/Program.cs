// Program to Function from Function with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace ReturningFunctionFromFunction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Function from Function with C# in Visual Studio.\n");

            Func<int, int>doubler = GetMultiplierFunction(2);
            Console.WriteLine("Doubled: " + doubler(5));
        }
        public static Func<int,int> GetMultiplierFunction(int multiplier)
        {
            return x => x * multiplier;
        }
    }
}
