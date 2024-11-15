// Program to create a Lambda Expression as Functions with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace LambdaExpressionAsFunction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Lambda Expression as Functions with C# in Visual Studio.\n");

            Func<int,int,int>multiply = (x,y) => x * y;
            Console.WriteLine("Product: " + multiply(3,5));
        }
    }
}
