// Program to use a Null Coalescing operator with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace UsingNullCoalescingOperator_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to use a Null Coalescing operator with C# in Visual Studio\n");

            // Nullable double declared and initialised with null
            double? myNullabledouble = null;

            // Using the Null Coalescing operator to provide a default value
            // If 'myNullableDouble' is null , 3.14 will be assigned to 'result'.
            double result = myNullabledouble ?? 3.14;

            Console.WriteLine($"Result:{result}");
        }
    }
   
}
