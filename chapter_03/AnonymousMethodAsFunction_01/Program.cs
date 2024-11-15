// Program to create a Anonymous methods as Functions with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace AnonymousMethodAsFunction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Anonymous methods as Functions with C# in Visual Studio.\n");

            Func<int,int>square = delegate(int x) { return x * x; };
            Console.WriteLine("Square: " + square(4));
        }
    }
}
