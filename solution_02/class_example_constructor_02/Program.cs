namespace class_example_constructor_02
{
    // Defining a class named Person
    public class Person
    {
        // Fields: Data that the person holds
        private string name;
        private int age;

        // Constructor: specialized function / method to automatically initialize person's data
        public Person(string personName, int personAge)
        {
            name = personName;
            age = personAge;
        }

        // Method: Action that prints persons details
        public void Greet()
        {
            Console.WriteLine("HI,I am " + name + " and I am " + age + " years old");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Person class using parameterized constructor
            Person student_01_object = new Person("Ashwin", 19);
            Person student_02_object = new Person("Miheer", 18);
            Person student_03_object = new Person("Akash", 15);

            // Call the greet method
            student_01_object.Greet();
            student_02_object.Greet();
            student_03_object.Greet();
        }
    }
}
