// Program to create Nested Tuples for Complex Data with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace NestedTuplesForComplexData_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create Nested Tuples for Complex Data with C# in Visual Studio.\n");

            // Nested tuple for complex data representation
            var department = (Id: 101, Name: "Sales", Manager: (Id: 102, Name: "Ash"));

            // Accessing elements from the nested tuple
            Console.WriteLine("Department Id: " + department.Id);
            Console.WriteLine("Department Name: " + department.Name);
            Console.WriteLine("Manager Id: " + department.Manager.Id);
            Console.WriteLine("Manager Name: " + department.Manager.Name);

        }
    }
}
