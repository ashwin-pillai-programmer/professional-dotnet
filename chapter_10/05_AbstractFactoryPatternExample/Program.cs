// Program to create an Abstract Factory Pattern with C# in Visual Studio.
// Programmer : Ashwin Pillai

/*
Definition:
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects 
without specifying their concrete classes.

Applications:
When the system needs to be independent of how its objects are created.
When the system should be configured with one of multiple families of products.
*/
using static _05_AbstractFactoryPatternExample.IfurnitureFactory;

namespace _05_AbstractFactoryPatternExample
{
    // Abstract Product A
    public interface IChair
    {
        void SitOn();
    }

    // Abstract Product B
    public interface ISofa
    {
        void LayOn();
    }
    // Concrete Product A1
    public class Victorianchair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Victorian Chair.");
        }
    }

    // Concrete Product A2
    public class Modernchair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Modern Chair.");
        }
    }

    // Concrete Product B1
    public class VictorianSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Laying on a Victorian Sofa.");
        }
    }

    // Concrete Product B2
    public class ModernSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Laying on a Modern Sofa.");
        }
    }

    // Abstract Factory
    public interface IfurnitureFactory
    { 
        IChair CreateChair();
        ISofa CreateSofa();

        // Concrete Factory 1
        public class VictorianFurnitureFactory : IfurnitureFactory
        {
            public IChair CreateChair() => new Victorianchair();
            public ISofa CreateSofa() => new VictorianSofa();
        }
        public class ModernFurnitureFactory : IfurnitureFactory
        {
            public IChair CreateChair() => new Modernchair();
            public ISofa CreateSofa() => new ModernSofa();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Abstract Factory Pattern with C# in Visual Studio.\n");

            // Create a Victorian Furniture Factory
            IfurnitureFactory victorianfactory = new VictorianFurnitureFactory();
            IChair victorainchair = victorianfactory.CreateChair();
            ISofa victorainsofa = victorianfactory.CreateSofa();
            victorainchair.SitOn();
            victorainsofa.LayOn();

            // Create a Modern Furniture Factory
            IfurnitureFactory modernfactory = new ModernFurnitureFactory();
            IChair modernchair = modernfactory.CreateChair();
            ISofa modernsofa = modernfactory.CreateSofa();
            modernchair.SitOn();
            modernsofa.LayOn();

            Console.ReadLine();
        }
    }
}
/*
Explanation of Code:
Abstract Products (IChair, ISofa):
Define interfaces for various product families.

Concrete Products (VictorianChair, ModernChair, etc.):
Implement the abstract products with specific behaviors.

Abstract Factory (IFurnitureFactory):
Declares methods to create abstract products.

Concrete Factories:
Implement the creation of specific product families.

Main Method:
Demonstrates creating families of products using different factories.
*/
