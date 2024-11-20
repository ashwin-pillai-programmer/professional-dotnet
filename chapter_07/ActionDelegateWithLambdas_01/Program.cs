// Program to create a Action Delegate With Lambdas with C# in Visual Studio.
// Programmer : Ashwin Pillai

//Action Delegate: Represents a void-returning method with zero or more parameters.
//Lambdas as Actions: Useful for callbacks or operations with no return value.
//Increased Flexibility: Simplifies inline logic.

namespace ActionDelegateWithLambdas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Action Delegate With Lambdas with C# in Visual Studio.\n");

            // Action delegate represents a method that takes a parameter but returns void
            // Here, we use an Action<int> delegate with a lambda expression
            Action<int> printsquare = x => Console.WriteLine($"Square: {x * x}");

            // Invoking the action
            printsquare(6);
        }
    }
}
