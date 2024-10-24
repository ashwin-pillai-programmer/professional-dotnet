// Program to create an Inheriting from Record with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace InheritingFromRecord_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Inheriting from Record with C# in Visual Studio\n");

            // Creating an instance of 'Employee' record.
            Employee employee1 = new Employee("Alice",500000);

            // Creating an instance of 'Manager' record, which inherits from 'Employee'.
            Manager manager1 = new Manager("Ashwin",100000000, "Sales");

            // Displaying details of employee and manager.
            Console.WriteLine(employee1);
            Console.WriteLine(manager1);
        }
    }
    // Base record 'Employee' with properties 'Name' and 'Salary'.
    // Records can serve as base types for other records, allowing inheritance.
    public record Employee(string Name, int Salary);

    // Derived record 'Manager' inherits from 'Employee' and adds a new property 'Department'.
    // This demonstrates how records can be extended to include additional data.
    public record Manager(string Name, int Salary, string Department) : Employee(Name,Salary);
}
