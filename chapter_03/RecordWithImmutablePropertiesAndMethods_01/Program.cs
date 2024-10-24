// Program to create a Record with Immutable Properties and Methods with C# in Visual Studio
// Programmer : Ashwin Pillai


using System.ComponentModel.DataAnnotations;

namespace RecordWithImmutablePropertiesAndMethods_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Record with Immutable Properties and Methods with C# in Visual Studio\n");

            // Creating an instance of 'Car' record.
            Car car1 = new Car("Toyota","Camry");

            // Displaying the car details
            Console.WriteLine(car1.GetcarDetails());
        }
    }
    // Defining a record named 'Car'.
    // Records can also contain methods along with properties.
    public record Car(string Make, string Model)
    {
        // Method to return car details as a string.
        public string GetcarDetails()
        {
            return $"Make {Make}, Model {Model}";
        }
    }
}
