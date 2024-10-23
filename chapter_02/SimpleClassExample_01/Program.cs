// Program to create a simple class in C# with Visual Studio 
// Programmer: Ashwin Pillai

// Defining a class named "Car"
public class Car
{
    // Fields: Data that the Car holds
    
    // Color of the car
    public string color;

    // Speed of the car
    public int speed;    

    // Method: An action that the Car can perform
    public void Drive()
    {
        // This method will print a message when called
        Console.WriteLine("The car is driving at " + speed + " km/h.");
    }
}

// Using the Car class to create an object
namespace SimpleClassExample_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a simple class in C# with Visual Studio\n");

            // Create an object of the Car class
            // This is like building a new robot from the blueprint
            Car myCar = new Car(); 

            // Assign values to the fields of the object
            myCar.color = "Red";
            myCar.speed = 100;

            // Call the method to perform the action
            myCar.Drive(); // Output: The car is driving at 100 km/h.
        }
    }
}