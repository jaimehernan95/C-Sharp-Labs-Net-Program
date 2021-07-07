using System;

namespace SectionD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lasttName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Hello {0} {1}", firstName.Trim(), lasttName.Trim());

            Console.ReadKey();
        }
    }
}
