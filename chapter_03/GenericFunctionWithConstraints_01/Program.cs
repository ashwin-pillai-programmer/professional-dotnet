// Program to create a Generic Function with Constraints with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace GenericFunctionWithConstraints_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Generic Function with Constraints with C# in Visual Studio.\n");

            // DisplayArray<int>(new int[] { 1, 2, 3 });
            DisplayArray<string>(new string[] { "apple", "orange", "banana" });
        }
        public static void DisplayArray<T>(T[] array)where T : class
        {
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
