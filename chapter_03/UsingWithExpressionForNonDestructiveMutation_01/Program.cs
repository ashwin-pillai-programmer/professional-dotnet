// Program to use 'With' Expression for Non Destructive Mutation with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace UsingWithExpressionForNonDestructiveMutation_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to use 'With' Expression for Non Destructive Mutation with C# in Visual Studio\n");

            // Creating an initial instance of 'Student' record.
            Student student1 = new Student("Emma","Physics");

            // Using the 'with' expression to create a new record based on 'student1' but with a different major.
            Student student2 = student1 with { Major = "Mathematics" };

            // Displaying the details of the student
            Console.WriteLine(student1);
            Console.WriteLine(student2);
        }
    }
    // Record named 'Student' that contains properties 'Name' and 'Major'.
    // Records support the 'with' expression to create a new instance based on an existing one with modifications.
    public record Student(string Name, string Major);
}
