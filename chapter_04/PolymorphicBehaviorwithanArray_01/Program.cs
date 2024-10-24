// Program to create a Polymorphic Behaviour with an Array with C# in Visual Studio
// Programmer : Ashwin Pillai

// Base Class
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}
// Derived class 1
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}
// Derived class 2
public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Square.");
    }
}
namespace PolymaorphicBehaviourwithanarray_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Polymorphic Behaviour with an Array with C# in Visual Studio\n");

            Shape[] shapes_array = { new Circle(), new Square(), new Shape() };
            foreach (Shape shape in shapes_array)
            {
                shape.Draw();
            }
        }
    }
}