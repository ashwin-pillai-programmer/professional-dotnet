// Program to create a Method Overriding with C# in Visual Studio
// Programmer : Ashwin Pillai

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The Dog makes a sound");
    }
}
namespace MethodOverloading_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a method overriding with C# in Visual Studio\n");

            Animal myanimal = new Animal();

            // Upcasting
            Dog mydog = new Dog();
            myanimal.Speak();
            mydog.Speak();
        }
    }   
}