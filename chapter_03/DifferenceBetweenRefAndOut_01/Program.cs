// Program to explain the difference between ref and out with C# in Visual Studio
// Programmer : Ashwin Pillai


namespace DifferenceBetweenRefAndOut_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to explain the difference between ref and out with C# in Visual Studio.\n");

            int number1 = 5;
            int number2;

            // Both 'ref' and 'out' are used to pass arguments by reference, but they behave differently.
            ModifyRef(ref number1);
            Console.WriteLine("Using ref: " + number1);

            ModifyOut(out number2);
            Console.WriteLine("Using ref: " + number2);
        }
        public static void ModifyRef(ref int num)
        {
            // 'ref' requires the variable to be initialized before passing.
            num *= 2;
        }
        public static void ModifyOut(out int num)
        {
            // 'out' does not require initialization before passing.
            // Must assign value before returning.  
            num = 50;
        }

    }
}
