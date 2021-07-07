using System;

namespace Lab6SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] GPA = new int[5];
                Console.WriteLine("Kindly Enter 5 GPAs:");
                for (int i = 0; i < GPA.Length; i++)
                {
                    GPA[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = 0;

                for (int i = 0; i < GPA.Length; i++)
                {
                    sum += GPA[i];
                }

                Console.WriteLine();
                Console.WriteLine("the summation is: {0}, the average: {1}", sum, (double)sum / GPA.Length);
                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine("Kindly Enter a correct number");
            }
        }
    }
}
