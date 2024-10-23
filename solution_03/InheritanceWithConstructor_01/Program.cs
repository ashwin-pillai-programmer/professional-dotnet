// Program to create a inheritance with constructor with C# in Visual Studio
// Programmer : Ashwin Pillai

//Base Class
public class Vehicle
{
    public string _brand;
    
    // Constructor
    public Vehicle(string brand)
    {
        _brand = brand;
    }
    public void ShowBrand()
    {
        Console.WriteLine("Vehicle brand:" +  _brand);
    }
}

// Derived class
public class Car : Vehicle
{
    public Car(string brand) : base(brand) { }
}

namespace InheritanceWithConstructor_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a inheritance with constructor with C# in Visual Studio\n");

            Car mycar = new Car("Buggati");
            mycar.ShowBrand(); // Output: Vehicle brand: Buggati
        }
    }
}
