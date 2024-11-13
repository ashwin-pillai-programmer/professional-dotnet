// Program to create a Tuple in Collection with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace TupleInCollection_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Tuple in Collection with C# in Visual Studio.\n");

            // Create a list of tuples to hold employee data.
            List<(int id, string name)> employees = new List<(int, string)>
            {
                (101,"Alice"),
                (102,"Bob"),
                (103,"Charlie")
            };
            // Iterate through each tuple in the list and print the details.
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee Id: {employee.id}, Employee name: {employee.name}");
            }


        }
    }
}
