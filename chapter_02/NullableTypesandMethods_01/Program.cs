// Program to use Nullable Types and Methods with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace NullableTypesandMethods_01
{
    public class Program
    {
        // Method that taks nullable integer as parameter
        public static void CheckAge(int? age)
        {
            // Using a Conditional check to check if age has any value
            if (age.HasValue)
            {
                // Output the age if it is not null.
                Console.WriteLine($"Age: {age.Value}");
            }
            else
            {
                // If age is null , print a mesage
                Console.WriteLine("Age is not specified");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to use Nullable Types and Methods with C# in Visual Studio\n");

            // Calling 'CheckAge' with a null integer
            CheckAge(null);

            // Calling 'CheckAge' with a valid integer
            CheckAge(24);
        }
        
    }
}
