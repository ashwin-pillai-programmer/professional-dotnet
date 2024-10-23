// Program to create a class with multiple methods with C# in Visual Studio
// Programmer : Ashwin Pillai

// Defining a class named "Calculator"
public class Calculator
{
    // Method to add two numbers
    public int Add(int a, int b)
    {
        // Returns the sum
        return a + b; 
    }

    // Method to subtract two numbers           
    public int Subtract(int a, int b)
    {
        // Returns the difference
        return a - b; 
    }

    // Method to multiply two numbers
    public int Multiply(int a, int b)
    {
        // Returns the product
        return a * b; 
    }
}
namespace ClassWithMultipleMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Program to create a class with multiple methods with C# in Visual Studio\n");  

            // Create an object of the Calculator class
            Calculator calc = new Calculator();

            // Call the methods and print the results
            Console.WriteLine(" Addition: " + calc.Add(5, 3));        // Output: 8
            Console.WriteLine(" Subtraction: " + calc.Subtract(5, 3)); // Output: 2
            Console.WriteLine(" Multiplication: " + calc.Multiply(5, 3)); // Output: 15
        }
    }
}
