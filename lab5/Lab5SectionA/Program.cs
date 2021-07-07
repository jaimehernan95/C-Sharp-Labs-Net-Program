using System;

namespace Lab5SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            int tableOf5 = 5;
            int tableof10 = 10;

            int count = 0;
            Console.WriteLine("Table of 5: ");
            while(count < tableOf5)
            {
                Console.WriteLine("{0}", count);
                count++;
            }
            Console.WriteLine();

            count = 0;
            Console.WriteLine("Table of 10: ");
            do
            {
                Console.WriteLine("{0}", count);
                count++;
            } while (count < tableof10);

            Console.ReadKey();
        }
    }
}
