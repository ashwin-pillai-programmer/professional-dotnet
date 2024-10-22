namespace Accesing_Array_Elements_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 4, 7, 11, 12 };
            int value_1 = myArray[0];
            int value_2 = myArray[1];
            myArray[3] = 44;
            Console.WriteLine("Traversing and printing values of the array using for loop\n");

            for (int counter = 0; counter < myArray.Length; counter++)
            {
                Console.WriteLine("\t" + myArray[counter]);
            }

            Console.WriteLine("\nTraversing and printing values of the array using foreach loop\n");

            foreach (var current_element in myArray)
            {
                Console.WriteLine("\t" + current_element);
            }
        }
    }
}
