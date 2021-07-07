using System;

namespace SectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your text: ");
            string text = Console.ReadLine();
            Console.Write("Enter the character to be searched: ");
            char enteredChar = Console.ReadKey().KeyChar;

            int index = text.IndexOf(enteredChar);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Index of '{0}' in text is : {1}", enteredChar, index);

            Console.ReadKey();
        }
    }
}
