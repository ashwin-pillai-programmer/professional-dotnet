// Program to pass reference types with ref with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace PassingReferenceTypesWithRef_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to pass reference types with ref with C# in Visual Studio\n");

            string text = "Hello";

            // Pass a reference type by 'ref'.
            AppendText(ref text);
            Console.WriteLine(text);
        }
        public static void AppendText(ref string str)
        {
            // Modify the original string by appending text.
            str += "World";
        }
    }
}
