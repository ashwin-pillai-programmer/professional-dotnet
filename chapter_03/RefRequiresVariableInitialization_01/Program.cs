// Program to create Ref that require Variable Initialization with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace RefRequiresVariableInitialization_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create Ref that require Variable Initialization with C# in Visual Studio\n");

            int number_1;

            // Uncommenting the line below will cause a compile error because the 'ref' variable must be initialized.
            // Error: Use of unassigned local variable 'number_1'
            // AddTen(ref number_1);

            // Properly initialize the variable.
            number_1 = 20;
            AddTen(ref number_1);
            Console.WriteLine("Value after AddTen: " + number_1);
        }
        
        public static void AddTen(ref int number_2)
        {
            number_2 += 10;
        }
    }
}
