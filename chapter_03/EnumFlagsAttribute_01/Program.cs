// Program to create Enumerator Class Attribute with C# in Visual Studio
// Programmer : Ashwin Pillai

namespace EnumFlagsAttribute_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create Enumerator Class Attribute with C# in Visual Studio\n");

            // Combining multiple enum values using bitwise OR.
            Filepermission filepermission = Filepermission.Read | Filepermission.Write;

            // Checking if the combined value contains specific permissions.
            if((filepermission & Filepermission.Read) == Filepermission.Read)
            {
                Console.WriteLine("Read permission granted");
            }
            if((filepermission & Filepermission.Write) == Filepermission.Write)
            {
                Console.WriteLine("Write permission granted");
            }
        }
    }
    // Enum named 'FilePermissions' with the [Flags] attribute.
    // The [Flags] attribute allows enum values to be combined using bitwise operations.
    public enum Filepermission
    {
        None = 0,       // No permissions.
        Read = 1,       // Binary: 0001
        Write = 2,      // Binary: 0010
        Execute = 4,    // Binary: 0100    
        All = Read | Write | Execute    // Combines all permissions.
    }

}
