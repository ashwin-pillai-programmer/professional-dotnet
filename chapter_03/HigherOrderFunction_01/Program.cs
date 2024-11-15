// Program to create a Higher Order Function with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace HigherOrderFunction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Higher Order Function with C# in Visual Studio.\n");

            // Passing a function as an argument
            ExecuteFunction(SayHello);
        }
        public static void SayHello()
        {
            Console.WriteLine("Hello from say hello function");
        }
        public static void ExecuteFunction(Action action)
        {
            action();
        }

    }
}
