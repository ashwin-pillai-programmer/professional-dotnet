// Program to create an interface and polymorphism with C# in Visual Studio
// Programmer : Ashwin Pillai

public interface IMovable
{
    void Move();
}
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("The car drives on the road");
    }
}
public class Airplane : IMovable
{
    public void Move()
    {
        Console.WriteLine("The airplane drives on the road");
    }
}
namespace InterfaceandPolymorphism_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create an interface and polymorphism with C# in Visual Studio\n");

            IMovable[] movables = {new Airplane(),new Car()};
            foreach (IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }
}