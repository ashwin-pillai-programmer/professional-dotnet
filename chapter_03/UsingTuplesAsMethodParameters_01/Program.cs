// Program to use Tuples as Method Parameters with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace UsingTuplesAsMethodParameters_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to use Tuples as Method Parameters with C# in Visual Studio.\n");

            // Create a tuple to hold data.
            var student = (Id:12, Name:"Ash", Grade:90);

            // Pass the tuple as a parameter to the DisplayStudentInfo method.
            DisplayStudentInfo(student);
        }
        public static void DisplayStudentInfo((int Id, string Name, int Grade) student)
        {
            Console.WriteLine("Student Id: " + student.Id);
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Student Grade: " + student.Grade);
        }
    }
}
