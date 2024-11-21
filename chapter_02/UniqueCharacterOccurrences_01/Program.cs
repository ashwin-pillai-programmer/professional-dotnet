// Program to create a Unique Character Occurrences with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace UniqueCharacterOccurrences_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Unique Character Occurrences with C# in Visual Studio.\n");

            Console.Write("Enter a string: ");

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a valid input");
            }
            else
            {
                Dictionary<char, int> occurences = UniqueCharacterOccurrences(input);
                foreach (var kvp in occurences)
                {
                    Console.WriteLine($"\nCharacter: {kvp.Key}, Occurences: {kvp.Value}");
                }
            }
        }
        static Dictionary<char, int> UniqueCharacterOccurrences(string input)
        {
            Dictionary<char, int> charactercount = new Dictionary<char, int>();

            foreach (var key in input)
            {
                if(charactercount.ContainsKey(key))
                {
                    charactercount[key]++;
                }
                else
                {
                    charactercount[key] = 1;
                }
            }
            return charactercount;
        }
    }       
}