// Program to demonstrate Prototype Pattern in C# with Visual Studio.
// Programmer: Ashwin Pillai

/*
Definition:
The Prototype Pattern creates new objects by cloning existing ones. 
It avoids the cost of creating objects from scratch when the initialization process is resource-intensive.

Applications:
When object creation is expensive, such as in simulations or when large datasets are involved.
When creating objects dynamically during runtime.
*/
namespace _04_PrototypePatternExample
{
    // Prototype interface
    public interface Iprototype
    { 
        Iprototype Clone();
    }

    // Concrete Prototype
    public class Employee : Iprototype
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position) 
        {
            Name = name;
            Position = position;
        }

        // Clone method
        public Iprototype Clone()
        {
            return (Iprototype)MemberwiseClone();
        }
        
        public void Showdetails()
        {
            Console.WriteLine($"Name: {Name}, Position: {Position}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Prototype Pattern in C# with Visual Studio.\n");

            // Create original object
            Employee originalemployee = new Employee("John Doe", "Manager");
            originalemployee.Showdetails();

            // Clone the object
            Employee clonedemployee = (Employee)originalemployee.Clone();
            // Modify cloned object
            clonedemployee.Name = "Jane Smith";

            // Display details of both objects
            Console.WriteLine("\nOriginal employee:");
            originalemployee.Showdetails();

            Console.WriteLine("\nCloned employee:");
            clonedemployee.Showdetails();

            Console.ReadLine();
        }
    }
}
/*
 Explanation of Code:
Prototype Interface (IPrototype):
Declares the Clone method for creating duplicates.

Concrete Prototype (Employee):
Implements the Clone method using MemberwiseClone, which performs a shallow copy.

Main Method:
Creates an object, clones it, and demonstrates that modifications to the clone do not affect the original.
 */
