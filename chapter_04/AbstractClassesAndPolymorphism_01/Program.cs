// Program to create an Abstract classes And Polymorphism with C# in Visual Studio
// Programmer : Ashwin Pillai

public abstract class Employee
{
    public String Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
    // Abstract Method - no implementation needed, declaration only
    public abstract void CalculateSalary();
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string name) : base(name) { }
    public override void CalculateSalary()
    {
        Console.WriteLine($"{Name} gets a fixed salary.");
    }
}
public class PartTimeEmployee : Employee
{
    public PartTimeEmployee(string name) : base(name) { }
    public override void CalculateSalary()
    {
        Console.WriteLine($"{Name} gets paid by the hour.");
    }
}
namespace AbstractClassesAndPolymorphism_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Abstract classes And Polymorphism with C# in Visual Studio\n");

            Employee[] employees = { new FullTimeEmployee("John"), new PartTimeEmployee("Doe") };
            foreach(Employee employee in employees)
            {
                employee.CalculateSalary();
            }
        }
    }
}
