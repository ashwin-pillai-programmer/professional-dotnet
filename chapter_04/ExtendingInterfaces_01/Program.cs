// Program to create an Extending Interfaces with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace ExtendingInterfaces_01
{
    // Base interface
    interface IWork
    {
        void start();
    }

    // Derived interface
    interface IAdvancedWork : IWork
    {
        void stop();
    }

    // Implementing the 'IWork' and 'IAdvancedWork' interface
    class Machine : IAdvancedWork
    {
        public void start()
        {
            Console.WriteLine("Machine started");
        }

        public void stop()
        {
            Console.WriteLine("Machine stopped");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Extending Interfaces with C# in Visual Studio.\n");

            Machine machine = new Machine();
            machine.start();
            machine.stop();
        }
    }
}
