// Program to demonstrate simple class example in visual studio
// Programmer: Ashwin Pillai

namespace class_example_01
{
    // Defining a class named Car
    public class Car
    {
        // Fields: Data that the car holds
        public string color;
        public int speed;

        // Method: A action that a car can perform
        public void Drive()
        {
            // This method will print a message when called
            Console.WriteLine("The car is driving at " + speed + " kmph");
            
        }
    }
    // Using the Car class to create an object
    internal class Program
    {
        // The Application begins with main()
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate simple class example in visual studio\n");

            // Create an object of the Car class using new operator and empty constructor
            Car mycar_object = new Car();

            // Assiging the values of the field of the object using object and dot operator
            mycar_object.color = "red";
            mycar_object.speed = 250;

            // Call the method to perform the action using object and dot operator
            mycar_object.Drive();
        }
    }
}
