// Program to use 'Out' with Tryparse() method with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace UsingOutWithTryParseMethod_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to use 'Out' with try parse method with C# in Visual Studio.\n");

            string input = "123";
            int result;

            // TryParse method uses 'out' to return parsed integer or default zero.
            if(int.TryParse(input,out result))
            {
                Console.WriteLine("Parsed number: " + result);
            }
            else
            {
                Console.WriteLine("Failed to parse");
            }


        }
    }
}
