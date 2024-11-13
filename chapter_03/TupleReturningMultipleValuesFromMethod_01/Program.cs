// Program to create a Tuple returning multiple values from methods with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace TupleReturningMultipleValuesFromMethod_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Tuple returning multiple values from methods with C# in Visual Studio.\n");

            // Call the method that returns area and perimeter
            var result = CalculateRectangle(5, 10);

            Console.WriteLine("Area: " + result.area);
            Console.WriteLine("Perimeter: " + result.perimeter);
        }
        // Method returning multiple values as a tuple
        public static(int area, int perimeter) CalculateRectangle(int length,int width)
        {
            return (length * width, 2*(length + width));
        }
    }
}
