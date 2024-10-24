// Program to use protected members with C# in Visual Studio
// Programmer : Ashwin Pillai

// Base class
public class Appliance
{
    protected string brand;

    public Appliance(string brandName)
    {
        brand = brandName;
    }
}
// Derived class
public class WashingMachine : Appliance
{
    public WashingMachine(string brandName) : base(brandName) { }

    public void DisplayBrand()
    {
        Console.WriteLine("Washing Machine brand = " + brand);

    }
}
namespace UsingProtectedMembers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to use protected members with C# in Visual Studio\n");

            WashingMachine myWashingMachine = new WashingMachine("LG");
            myWashingMachine.DisplayBrand();

        }

    }
}