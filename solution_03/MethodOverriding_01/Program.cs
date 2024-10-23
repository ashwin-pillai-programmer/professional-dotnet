// Program to create a method overriding with C# in Visual Studio
// Programmer : Ashwin Pillai

// Base class
public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}
// Derived class
public class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat makes sound");
    }
}
namespace MethodOverriding_01
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Program to create a method overriding with C# in Visual Studio\n");

            Animal myanimal = new Animal();
            Cat mycat = new Cat();
            myanimal.Sound(); // Output: Animal makes a sound.
            mycat.Sound();    // Output: The cat says: Meow
        }

    } 
    
}