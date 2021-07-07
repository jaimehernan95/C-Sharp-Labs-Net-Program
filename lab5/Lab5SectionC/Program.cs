using System;

namespace Lab5SectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] intArray = new int[10];
                Console.WriteLine("Kindly Enter 10 mumbers");
                int sum = 0;
                for (int i = 0; i<10;i++)
                {
                    Console.WriteLine("Enter number {0}", i+1);
                    intArray[i] = Convert.ToInt32(Console.ReadLine());

                    sum += intArray[i];
                }


                Console.WriteLine();
                Console.WriteLine("the summation is: {0}, the average: {1}", sum, (double)sum/10);
                Console.ReadKey();

            }
            catch(Exception)
            {
                Console.WriteLine("Kindly Enter a correct number");
            }
        }
    }
}
