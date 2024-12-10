// Program to create an Explicit Interface Implementation with C# in Visual Studio.
// Programmer : Ashwin Pillai

namespace ExplicitInterfaceImplementation_01
{
    interface Ireadable
    {
        void read();
    }
    interface Iwriteable
    {
        void write();
    }
    class Document : Ireadable, Iwriteable
    {
        // Explicity implementing interface
        public void read()
        {
            Console.WriteLine("Reading Document");
        }
        public void write()
        {
            Console.WriteLine("Writing Document");
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Program to create an Explicit Interface Implementation with C# in Visual Studio.\n");

                Document document = new Document();

                // Explicitly casting to 'IReadable' and 'IWriteable' interface
                ((Ireadable)document).read();
                ((Iwriteable)document).write();
            }
        }
    }

