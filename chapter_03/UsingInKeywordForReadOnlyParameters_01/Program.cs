// Program to use 'IN' keyword for read only parameter with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace UsingInKeywordForReadOnlyParameters_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to use 'IN' keyword for read only parameter with C# in Visual Studio. \n");

            // Initialize a value.
            int number = 100;

            // Pass the value to the method using 'in'
            // 'in' ensures method cannot modify the original value
            ShowValue(in number);
        }
        // Method that takes a read-only argument using 'in'.
        public static void ShowValue(in int value)
        {
            Console.WriteLine($"Value: {value}");

            // Uncommenting the line below will cause a compile error as 'in' prevents modification.
            // value = 200;
        }

    }
}
