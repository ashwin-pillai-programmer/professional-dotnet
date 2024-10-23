// Program to create a simple inheritance with C# in Visual Studio
// Programmer : Ashwin Pillai

// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }
}
//Derived class
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking");
    }
}
namespace chapter_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a simple inheritance with C# in Visual Studio\n");

            Dog mydog = new Dog();
            mydog.Eat();  // Output: This animal is eating.
            mydog.Bark(); // Output: The dog is barking.
        }
    }
}




        