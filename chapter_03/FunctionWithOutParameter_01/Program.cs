// Program to create a Function with Out parameter with C# in Visual Studio
// Programmer : Ashwin Pillai

using System.Runtime.InteropServices;

namespace FunctionWithOutParameter_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Function with Out parameter with C# in Visual Studio.\n");

            int result;
            CalculateArea(5, 10, out result);
            Console.WriteLine("Area of the rectangle: " + result);
        }
        // Function to calculate area and use out parameter to return the result.
        public static void CalculateArea(int length, int width, out int area)
        {
            area = length * width;
        }
    }
}
