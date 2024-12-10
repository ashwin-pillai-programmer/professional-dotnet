// Program to create an Access Modifiers in Nested Classes with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace AccessModifiersInNestedClasses_01
{
     class Outerclass
    {
        private class Innerclass
        {
            // Private method within nested class
            public void InnerClassMethod()
            {
                Console.WriteLine("Inner Class Method");
            }
        }

        public void AccessInnerClass()
        {
            Innerclass innerclass = new Innerclass();

            // Accessing private nested class method
           innerclass.InnerClassMethod();
     }
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create an Access Modifiers in Nested Classes with C# in Visual Studio.\n");

            Outerclass outerclass = new Outerclass();
            outerclass.AccessInnerClass();
        }
    }
}
