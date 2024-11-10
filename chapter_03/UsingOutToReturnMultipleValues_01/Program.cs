// Program to use Out to Return Multiple Values with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace UsingOutToReturnMultipleValues_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to use Out to Return Multiple Values with C# in Visual Studio.\n");

            // Variables that will receive multiple outputs from the method.
            int sum, product;

            // Calling the method with 'out' parameters.
            Calculate(5, 3, out sum, out product);

            Console.WriteLine("sum = " + sum + "\n");
            Console.WriteLine("product = " + product);
        }
        // Method to calculate sum and product using 'out' parameters.
        public static void Calculate(int a,int b,out int sum,out int product)
        {
            sum = a + b;
            product = a * b;
        }
    }
}
