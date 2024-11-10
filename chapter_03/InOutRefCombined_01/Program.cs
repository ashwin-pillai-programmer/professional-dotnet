// Program to create an 'in','out',and 'ref' combined with C# in Visual Studio
// Programmer : Ashwin Pillai

using System.Numerics;
using System.Runtime.Serialization;

namespace InOutRefCombined_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an 'in','out',and 'ref' with C# in Visual Studio\n");

            int a = 10, b;
            Multiply(ref a, in a, out b);

            Console.WriteLine($"a = {a},b = {b}");
        }
        public static void Multiply(ref int refparam, in int inparam, out int outparam)
        {
            refparam *= 2;

            // Cannot modify 'inParam' as it is read-only
            // Assign value to 'outParam'
            outparam = inparam * refparam;
        }
    }
}
