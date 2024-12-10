// Program to create an Access Modifiers with Interfaces with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace AccessModifiersWithInterfaces_01
{
    public interface Imath
    {
        // Public by default in interface
        int Add(int number_1, int number_2);
    }
    class MathOperation : Imath
    {
        public int Add(int number_1, int number_2)
        {
            return number_1 + number_2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Access Modifiers with Interfaces with C# in Visual Studio.\n");

            Imath mathOperation = new MathOperation();
            Console.WriteLine($"Sum: {mathOperation.Add(5,2)}");
        }
    }
}
