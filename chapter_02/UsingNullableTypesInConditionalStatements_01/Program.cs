// Program to use Nullable Types in Conditional Statements with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace UsingNullableTypesInConditionalStatements_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to use Nullable Types in Conditional Statements with C# in Visual Studio\n");

            // Nullable character variable declared.
            char? myNullableChar = 'A';

            // Conditional (ternary) operator to check if 'myNullableChar' has a value.
            // If true, the character is returned; otherwise, a default character is returned.
            char displaychar = myNullableChar.HasValue ? myNullableChar.Value : 'Z';

            Console.WriteLine($"Display character: {displaychar}");

            // Setting the Nullable character to null
            myNullableChar = null;

            // Now the conditional will use the defualt character 'Z' because myNullableChar is null
            displaychar = myNullableChar.HasValue ? myNullableChar.Value : 'Z';

            Console.WriteLine($"Display character: {displaychar}");

        }
    }
}
