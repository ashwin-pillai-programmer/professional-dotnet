// Program to create a Method Overloading with C# in Visual Studio
// Programmer : Ashwin Pillai

public class Calculator
{
    // Method to add two intgers
    public int Add(int number_1, int number_2)
    {
        return number_1 + number_2;
    }

    // Overloaded method to add three integers
    public int Add(int number_1, int number_2, int number_3)
    {
        return number_1 + number_2 + number_3;  
    }
}
namespace MethodOverloading_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a method overloading with C# in Visual Studio\n");

            Calculator mycalculator = new Calculator();
            Console.WriteLine(mycalculator.Add(5,3));
            Console.WriteLine(mycalculator.Add(5,3,2));
        }

    }
}