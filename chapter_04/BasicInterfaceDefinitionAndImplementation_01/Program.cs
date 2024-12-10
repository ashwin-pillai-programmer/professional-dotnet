// Program to create a Basic Interface Definition and Implementation with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace BasicInterfaceDefinitionAndImplementation_01
{
    interface Ishape
    {
        // Interface members are public and abstract by default
        double calculateArea();
    }
    // Implementing the IShape interface in a class 'Circle'
    class Circle : Ishape
    {
        private double radius;

        // Constructor to initialize radius
        public Circle(double radius)
        {
            this.radius = radius;
        }
        // Implementing the CalculateArea method from IShape interface
        public double calculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Basic Interface Definition and Implementation with C# in Visual Studio.\n");

            Circle circle = new Circle(5);
            Console.WriteLine($"Area of a circle: {circle.calculateArea():F2}");
        }
    }
}
