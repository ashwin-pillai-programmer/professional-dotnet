// Program to create a Basic Enum Declaration and Usage with C# in Visual Studio
// Programmer : Ashwin Pillai

using System;

namespace BasicEnumDeclarationAndUsage_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Basic Enum Declaration and Usage with C# in Visual Studio\n");

            // Declaring a variable of type 'DayOfWeek' and assigning it a value from the enum.
            DayOfWeek today = DayOfWeek.Wednesday;

            // Displaying the value of the enum.
            Console.WriteLine("Today is: " + today); // Output: Today is: Wednesday
        }
    }

    // Declaring an enum type named 'DayOfWeek'.
    // An enum (short for "enumeration") is a distinct type used that consists of a set of named constants called enumerators.
    public enum DayOfWeek
    {
        // Each named constant in the enum has an underlying integer value, starting from 0 by default.
        Sunday,    // 0
        Monday,    // 1
        Tuesday,   // 2
        Wednesday, // 3
        Thursday,  // 4
        Friday,    // 5
        Saturday   // 6
    }
}
