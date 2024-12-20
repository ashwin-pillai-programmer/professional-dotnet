// Program to demonstrate Builder Pattern in C# with Visual Studio.
// Programmer: Ashwin Pillai

/* 
Definition:
The Builder Pattern separates the construction of a complex object from its representation so that the same 
construction process can create different representations. It is often used for creating objects with many 
optional parameters.

Applications:
When constructing a complex object requires multiple steps.
When the object creation involves assembling various parts, especially if these parts have optional variations.
Creating immutable objects with various configurations. 
*/

using static _03_BuilderPatternExample.GamingComputerBuilder;

namespace _03_BuilderPatternExample
{
    // Product class
    public class Computer
    {
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string storage { get; set; }
        public string GraphicsCard { get; set; }    
 
        public void showspecification()
        {
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"storage: {storage}");
            Console.WriteLine($"GraphicsCard: {GraphicsCard}");
        }
    }
    // Builder interface
    public interface IcomputerBuilder
    {
        void SetProcessor();
        void SetRAM();
        void SetStorage();
        void SetGraphicsCard();
        Computer GetComputer();
    }

    // Concrete Builder for Gaming Computer
    public class GamingComputerBuilder : IcomputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetProcessor()
        {
            _computer.Processor = "Intel Core i9";
        }
        public void SetRAM()
        {
            _computer.RAM = "32GB";
        }

        public void SetStorage()
        {
            _computer.storage = "1TB SSD";
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "NVIDIA RTX 3090";
        }

        public Computer GetComputer()
        {
            return _computer;
        }

    }
    // Director class
    public class ComputerDirector
    {
        private IcomputerBuilder _builder;

        public ComputerDirector(IcomputerBuilder builder)
        {
            _builder = builder;
        }
        public void BuildComputer()
        {
            _builder.SetProcessor();
            _builder.SetRAM();
            _builder.SetStorage();
            _builder.SetGraphicsCard();
        }
        public Computer GetComputer()
        {
            return _builder.GetComputer();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Builder Pattern in C# with Visual Studio.\n");

            // Create a GamingComputerBuilder instance
            IcomputerBuilder builder = new GamingComputerBuilder();

            // Pass the builder to the director
            ComputerDirector director = new ComputerDirector(builder);

            // Build the gaming computer
            director.BuildComputer();

            // Get the built computer and display specifications
            Computer gamingComputer = director.GetComputer();
            gamingComputer.showspecification();

            Console.ReadLine();
        }
    }
}
/*
Explanation of Code:

Product (Computer):
Represents the complex object to be built.
Contains properties like Processor, RAM, etc.

Builder Interface (IComputerBuilder):
Declares the steps required to build the product.

Concrete Builder (GamingComputerBuilder):
Implements the builder interface and provides specific configurations.

Director (ComputerDirector):
Orchestrates the building process by invoking the builder's methods in a specific sequence.

Main Method:
Demonstrates the creation of a gaming computer using the builder pattern.
*/
