// Program to create a Multi Parameter Lambda Expression with C# in Visual Studio.
// Programmer : Ashwin Pillai

//Multiple Parameters: Parentheses are required when specifying multiple parameters ((a, b) => a + b).
//Concise Functions: Lambdas are ideal for concise mathematical or functional logic.
//Elimination of Boilerplate: No need to define separate named methods.ons.

namespace MultiParameterLambdaExpression_01
{
    // Define a delegate that takes two integers and returns an integer
    public delegate int MathOperation(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Multi Parameter Lambda Expression with C# in Visual Studio.\n");

            // Lambda expression with multiple parameters
            // Syntax: (parameters) => expression
            MathOperation add = (a,b) => a + b;

            // Using the lambda to add two numbers
            int sum = add(3,4);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
