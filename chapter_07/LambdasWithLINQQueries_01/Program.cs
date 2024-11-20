// Program to create a Lambdas With LINQ Queries with C# in Visual Studio.
// Programmer : Ashwin Pillai

//LINQ Queries: Use lambdas for concise filtering and projection.
//Functional Composition: Where and Select together create powerful query-like logic.
//Readable Pipelines: Simplifies querying collections.

namespace LambdasWithLINQQueries_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Lambdas With LINQ Queries with C# in Visual Studio.\n");

            // Sample array of integers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Using LINQ with a lambda expression to filter and project elements
            // 'Where' filters elements based on a condition; 'Select' projects each element
            var result = numbers.Where(n => n % 2 == 0).Select(n => n * 10);

            // Displaying the results
            Console.WriteLine("Transformed Even Numbers:");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
