using System;
using System.Collections.Generic;

namespace Lab7SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> Names = new List<string>();


                Console.WriteLine("Kindly Enter 4 Names:");
                for(int i = 0; i < 4; i++)
                {
                    string name = Console.ReadLine();
                    Names.Add(name);
                }

                Console.WriteLine();
                Console.WriteLine("Entered names:");
                foreach (var item in Names)
                {
                    Console.WriteLine("{0}", item);
                }

                Names.Sort((a, b) => a.CompareTo(b));

                Console.WriteLine();
                Console.WriteLine("Sorted names:");
                foreach (var item in Names)
                {
                    Console.WriteLine("{0}", item);
                }

                Console.WriteLine();
                Console.WriteLine("Enter a Name to check:");

                string checkName = Console.ReadLine();

                int nameIndex = Names.FindIndex(x => x.ToLower().Trim() == checkName.ToLower().Trim());

                if(nameIndex >= 0)
                {
                    Console.WriteLine("the index of this name is: {0}", nameIndex);
                }
                else
                {
                    Console.WriteLine("This not exists");
                }

                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Data");
            }
        }
    }
}
