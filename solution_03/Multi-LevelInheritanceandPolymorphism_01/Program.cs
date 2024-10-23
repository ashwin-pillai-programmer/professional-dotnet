// Program to create a multi-level inheritance and polymorphism with C# in Visual Studio
// Programmer : Ashwin Pillai

//Base class
public class Animal
{
    public virtual void Move()
    {
        Console.WriteLine("Animal can move");
    }
}
// Derived class 1
public class bird : Animal
{
    public override void Move()
    {
        Console.WriteLine("Bird can fly");
    }
}
// Derived class 2
public class Penguin : bird
{
    public override void Move()
    {
        Console.WriteLine("Penguin can swim");
    }
}

namespace MultiLevelInheritanceandPolymorphism_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a multi-level inheritance and polymorphism with C# in Visual Studio\n");

            Animal myanimal = new Animal();
            bird mybird = new bird();
            Penguin mypenguin = new Penguin();  
            myanimal.Move();
            mybird.Move();
            mypenguin.Move();
           
        }
    }
}