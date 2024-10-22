using System.Linq.Expressions;
using System.Xml.Linq;

namespace Jagged_Array_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged =
            {
                new[] { 1, 2 },
                new[] { 3, 4, 5, 6, 7, 8 },
                new[] { 9, 10, 11 }
            };
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int element = 0; element < jagged[row].Length; element++)
                {
                    Console.WriteLine($"row: {row}, element: {element}, " +
                    $"value: {jagged[row][element]}");
                }
            }
        }
        }
    }
