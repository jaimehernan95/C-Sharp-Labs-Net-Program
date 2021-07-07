using System;

namespace SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username Please:");
            var username = Console.ReadLine().Trim();

            string name = username;

            Console.WriteLine("You entered: {0}", name);

            Console.ReadKey();

        }
    }
}
