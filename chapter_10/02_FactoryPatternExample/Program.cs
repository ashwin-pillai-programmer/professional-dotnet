// Program to create a Factory Pattern with C# in Visual Studio.
// Programmer : Ashwin Pillai

/*
Definition:
The Factory Pattern defines an interface/zarriyaa for creating objects but allows subclasses to alter the type of objects 
that will be created. It helps encapsulate the object creation process.

Applications:
When the exact type of object required is determined dynamically at runtime.
When the creation process is complex and needs centralization.
*/
namespace _02_FactoryPatternExample
{
    // Product interface
    public interface Ishape
    {
        void Draw();
    }

    // Concrete Product 1
    public class Circle : Ishape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    // Concrete Product 2
    public class Rectangle : Ishape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    // Factory Class
    public class ShapeFactory
    {
        public Ishape Getshape(string shapetype)
        {
            if(shapetype == null)
            {
                return null;
            }
            if (shapetype.Equals("Circle", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            else if(shapetype.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Program to create a Factory Pattern with C# in Visual Studio.\n");

            // Create factory instance
            ShapeFactory shapeFactory = new ShapeFactory();

            // Get a Circle object and call its Draw method
            Ishape circle = shapeFactory.Getshape("Circle");
            circle?.Draw();

            // Get a Rectangle object and call its Draw method
            Ishape rectangle = shapeFactory.Getshape("Rectangle");
            rectangle?.Draw();

            Console.ReadLine();
        }
    }
}
/*
Explanation of Code:

IShape interface:
Defines a common interface for all shapes, ensuring all shapes implement the Draw method.

Circle and Rectangle classes:
Concrete implementations of the IShape interface, each with its specific behavior for Draw.

ShapeFactory:
Contains the logic to create the appropriate object (Circle or Rectangle) based on the provided input.

Main method:
Demonstrates the usage of the factory by dynamically creating objects without exposing their instantiation logic.
*/
