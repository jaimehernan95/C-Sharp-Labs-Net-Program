using System;

namespace Lab5SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a start number: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a end number: ");
                int end = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("even numbers less than 25 and not equal 4: ");
                for (int i = start; i <= end; i++)
                {
                    if(i > 25)
                    {
                        break;
                    }
                    if(i == 4)
                    {
                        continue;
                    }
                    int j = i % 2;

                    if(j == 0)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }

                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Kindly Enter a correct number");
            }
        }
    }
}
