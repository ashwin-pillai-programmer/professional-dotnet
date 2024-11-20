// Program to create a basic Lambda Expression with C# in Visual Studio.
// Programmer : Ashwin Pillai

// Definiton of Lambda expression.
// Lambda expressions are one of the core features of C# that bring the power of functional programming into a
// strongly-typed, object-oriented language. 
// They allow you to create concise and inline functions that can be used wherever delegate types are expected

namespace BasicLambdaExpression_01
{
    internal class Program
    {
        // Defining a delegate type that takes an integer and returns an integer
        public delegate int Operation(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a basic Lambda Expression with C# in Visual Studio.\n");

            // Using a lambda expression to define a function that squares a number
            // Syntax: (parameters) => expression or block
            // Here, 'n' is the parameter, and 'n * n' is the expression
            Operation square = n => n * n;

            // Calling the lambda expression through the delegate
            int result = square(5);
            Console.WriteLine($"Square of 5 is: {result}");
        }
    }
}
