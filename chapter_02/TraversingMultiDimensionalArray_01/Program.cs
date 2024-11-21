// Program to Traverse MultiDimensional Array with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace TraversingMultiDimensionalArray_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Traverse MultiDimensional Array with C# in Visual Studio.\n");

            int[,] matrix =
            {
                {1, 2, 3},
                {4, 5, 6}, 
                {7, 8, 9},
            };

            int rowcount = matrix.GetLength(0);
            int colcount = matrix.GetLength(1);

            for(int rowcounter = 0; rowcounter < rowcount; rowcounter++)
            {
                for (int columnCounter = 0; columnCounter < colcount; columnCounter++)
                {
                    Console.Write($"{matrix[rowcounter, columnCounter]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
