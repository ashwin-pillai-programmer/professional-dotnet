// Program to create an Enumerator with Custom Values with C# in Visual Studio
// Programmer : Ashwin Pillai

using System.Diagnostics;

namespace EnumWithCustomValues_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Enumerator with Custom Values with C# in Visual Studio\n");

            // Creating a variable of 'StatusCode' and setting it to a specific value
            StatusCode code = StatusCode.Error;

            // Checking the value of the enum using a conditional statement.
            if(code == StatusCode.Error)
            {
                Console.WriteLine("An error occurred");  // Output: An error occurred.
            }
        }
    }

    // Declaring an enum named 'StatusCode' with custom integer values.
    // Enum values can be explicitly assigned, allowing custom values instead of the default sequence.
    public enum StatusCode
    {
        Success = 200, // The value 200 is typically used for a successful operation.
        Warning = 300, // A custom value of 300 for warning status.
        Error = 500    // The value 500 is often used to indicate an error.
    }
}
