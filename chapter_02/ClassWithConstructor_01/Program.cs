// Program to create a class with constructor with C# in Visual Studio
// Programmer : Ashwin Pillai

// Defining a class named "Person"
public class Person
{
    // Fields: Data that the Person holds
    public string name;
    public int age;

    // Constructor: Special method to initialize the Person's data
    public Person(string personName, int personAge)
    {
        // Set the name field
        name = personName;

        // Set the age field
        age = personAge;   
    }

    // Method: Action that prints the person's details
    public void Greet()
    {
        Console.WriteLine(" Hello, my name is " + name + " and I am " + age + " years old.");
    }
}
namespace ClassWithConstructor_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Program to create a class with constructor with C# in Visual Studio\n");

            // Create an object of the Person class using the constructor
            Person student = new Person("Alice", 16);

            // Call the Greet method
            student.Greet(); // Output: Hello, my name is Alice and I am 16 years old.
        }
    }

}
