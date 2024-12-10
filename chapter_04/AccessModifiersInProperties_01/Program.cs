// Program to create a Access Modifiers In Properties with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace AccessModifiersInProperties_01
{
    internal class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            // Public property with private setter
            private set
            {
                name = value;
            }
        }

        public Person(string name)
        {
            // Initializing through constructor
            Name = name;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Access Modifiers In Properties with C# in Visual Studio.\n");

            Person person = new Person("Tom");
            Console.WriteLine($"person name: {person.Name}");
        }
    }


}
