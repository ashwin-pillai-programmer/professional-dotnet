// Program to Using Lambdas With List Filtering with C# in Visual Studio.
// Programmer : Ashwin Pillai

using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
//Lambda Expressions as Arguments: Used with methods like FindAll to filter collections.
//Predicate Delegate: Lambdas can replace predicates for concise, readable code.
//Functional Programming: Simplifies collection manipulation using built-in functions.

namespace UsingLambdasWithListFiltering_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Using Lambdas With List Filtering with C# in Visual Studio.\n");

            // Initialize a list of integers
            List<int> numbers = new List<int> { 1,2,3,4,5,6};

            // Using a lambda expression with the List's FindAll method to filter even numbers
            // Predicate<int> is a delegate that takes an int and returns a bool
            List<int> evennumbers = numbers.FindAll(n => n % 2 == 0);

            // Displaying the result
            Console.WriteLine("Even Numbers:");
            evennumbers.ForEach(n => Console.WriteLine(n));
        }
    }
}
