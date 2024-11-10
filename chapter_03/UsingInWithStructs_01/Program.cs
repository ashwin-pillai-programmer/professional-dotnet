// Program to use 'in' with structs with C# in Visual Studio
// Programmer : Ashwin Pillai

using System.Security.Cryptography.X509Certificates;

namespace UsingInWithStructs_01
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to use 'in' with structs with C# in Visual Studio.\n");

            Point p1 = new Point(5, 10);
            ShowCoordinates(in p1);
        }

        public static void ShowCoordinates(in Point point)
        {
            // The 'in' keyword prevents modifying the struct.
            // Output: Coordinates: (5, 10)
            Console.WriteLine($"Coordinates: ({point.X}, {point.Y})");
        }


    }
}
