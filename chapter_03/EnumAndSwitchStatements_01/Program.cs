// Program to create an Enumerator and Switch Statements with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace EnumAndSwitchStatements_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Enumerator and Switch Statements with C# in Visual Studio\n");

            // Assigning a value to 'TrafficSignal' enum variable.
            TrafficSignal signal = TrafficSignal.Red;

            // Using a switch statement to perform different actions based on the enum value.
            switch(signal)
            {
                case TrafficSignal.Red:
                    Console.WriteLine("Stop"); // Output: Stop!
                    break;

                case TrafficSignal.Yellow:
                    Console.WriteLine("Get Ready");
                    break;

                case TrafficSignal.Green:
                    Console.WriteLine("Go");
                    break;

                default:
                    Console.WriteLine("Invalid Signal");
                    break;
            }
        }
    }

    // Enum named 'TrafficSignal' that represents different states of a traffic light.
    public enum TrafficSignal
    {
        Red,    // Represents the "Stop" state.
        Yellow, // Represents the "Get Ready" state.
        Green   // Represents the "Go" state.
    }
}
