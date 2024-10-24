// Program to create a Usage of Nullable Types with C# in Visual Studio
// Programmer : Ashwin Pillai

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Program to create a Usage of Nullable Types with C# in Visual Studio\n");


        // Declaraing a nullable integer
        // The '?' after 'int' means that 'myNullableInt' can hold an integer value or be null
        int? myNullableInt = null;

        // Checking if myNullableInt has null value or not
        if (myNullableInt.HasValue)
        {
            Console.WriteLine($"Value: {myNullableInt.HasValue}");
        }
        else
        {
            // Since 'myNullableInt' is null, this line will execute.
            Console.WriteLine("myNullableInt is null");
        }

        // Assigning a value to 'myNullableInt'
        myNullableInt = 10;

        // Since the myNullableInt has a value , so this line will execute
        if (myNullableInt.HasValue)
        {
            Console.WriteLine($"Value: {myNullableInt.Value}");
        }


    }
}

