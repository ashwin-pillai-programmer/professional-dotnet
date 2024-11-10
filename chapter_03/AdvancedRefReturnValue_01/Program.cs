// Program to create an advanced ref return value with C# in Visual Studio
// Programmer : Ashwin Pillai

using System.Security.Cryptography.X509Certificates;

namespace AdvancedRefReturnValue_01
{
    internal class Program
    {
        public static ref int Getelement(ref int[] numbers, int index)
        {
            return ref numbers[index];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an advanced ref return value with C# in Visual Studio.\n");

            int[] numbers = { 1, 2, 3 };
            ref int element  = ref Getelement(ref numbers, 1);

            // Modifying the element directly affects the original array.
            element = 20;
            Console.WriteLine(string.Join(",",numbers));
        }
    }
}
