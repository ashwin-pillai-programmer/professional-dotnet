// Program to use GetValue or Default() Method with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace UsingGetValueOrDefaultMethod_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to use GetValue or Default() Method with C# in Visual Studio\n");

            // Declaraing and Initializing a nullable float variable
            float? myNullablefloat = null;

            // Using the 'GetValueorDefault()'method to return the value of the 'myNullablefloat'
            // or a default value (0.0f in the case of float) if it is null
            // Using string intrapolation with the dollar symbol to format the output
            float mydefaultfloat = myNullablefloat.GetValueOrDefault();

            Console.WriteLine($"Default value: {mydefaultfloat}");

            // Assigning the actual value to the 'myNullablefloat'
            myNullablefloat = 9.81f;

            // Using the 'GetValueorDefault()'method to return the actual value of the 'myNullablefloat'
            float myactualtfloat = myNullablefloat.GetValueOrDefault();

            Console.WriteLine($"Actual value: {myactualtfloat}");
        }
    }
}