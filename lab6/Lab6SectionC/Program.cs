using System;

namespace Lab6SectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,] names = new string[2, 2, 3] {
                {
                    { "Ashraf", "Pradeep", "Elyas"},
                    { "Vrunda", "Dare", "Anushi"}
                },
                {
                    { "Hanan", "Bizu", "Swati"},
                    { "Jeyashi", "Supun","Gurmeet"}
                }
            };

            string[] alpha = new string[12];
            int i = 0;
            foreach(string item in names)
            {
                alpha[i] = item;
                i++;
            }

            Array.Sort(alpha);

            foreach(string item in alpha)
            {
                Console.WriteLine("{0}", item);
            }

            Console.ReadKey();
        }
    }
}
