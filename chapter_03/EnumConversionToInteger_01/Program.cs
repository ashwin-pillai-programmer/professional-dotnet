// Program to create a class with Enumerator Conversion To Integer with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace EnumConversionToInteger_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a class with Enumerator Conversion To Integer with C# in Visual Studio\n");

            // Assigning an enum value to 'OrderStatus'.
            OrderStatus status = OrderStatus.Dispatched;

            // Converting the enum value to its underlying integer.
            int statusCode = (int)status;

            // Displaying the integer value of the enum.
            Console.WriteLine("Order Status Code: " + statusCode);
        }
    }
    // Enum named 'OrderStatus' to represent different stages of an order's lifecycle.
    // Enum values are implicitly assigned starting from 0.
    public enum OrderStatus
    {
        Pending,    // 0
        Processing, // 1
        Dispatched, // 2
        Delivered   // 3
    }
}
