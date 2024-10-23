// Program to create a class with Properties with C# in Visual Studio
// Programmer : Ashwin Pillai

// Defining a class named "Book"
public class Book
{
    // Property: Like a field, but with more control
    // Private field, cannot be accessed directly
    private string title; 

    // Public property to get and set the value of the title
    public string Title
    {
        // Getter method
        get { return title; }

        // Setter method
        set { title = value; } 
    }
}
namespace ClassWithproperties_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Program to create a class with Properties with C# in Visual Studio\n");

            // Create an object of the Book class
            Book myBook = new Book();

            // Set the title using the property
            myBook.Title = "The Adventures of Sherlock Holmes";

            // Get and print the title using the property
            Console.WriteLine("Book title: " + myBook.Title); // Output: The Adventures of Sherlock Holmes
        }
    }
}
