using System;

namespace Lab6SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[,] numbers = new int[3, 3];

                Console.WriteLine("Kindly Enter Numbers:");
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    Console.WriteLine("Raw {0}:", i);
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine();

                int[] oddNumbers = new int[9];
                int[] evenNumbers = new int[9];
                int oddCount = 0;
                int evenCount = 0;

                foreach (int i in numbers)
                {
                    if (i % 2 == 0)
                    {
                        evenNumbers[evenCount] = i;
                        evenCount++;
                    }
                    else
                    {
                        oddNumbers[oddCount] = i;
                        oddCount++;
                    }
                }

                Console.WriteLine();


                Console.WriteLine("Inserted numbers numbers[3][3]:");
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    Console.WriteLine("[{0},{1},{2}]:",numbers[i,0], numbers[i,1], numbers[i,2]);
                }


                Console.WriteLine("Even number in the array are:");
                for (int i = 0; i < evenCount; i++)
                {
                    Console.WriteLine("{0}:", evenNumbers[i]);
                }

                Console.WriteLine("Odd number in the array are:");
                for (int i = 0; i < oddCount; i++)
                {
                    Console.WriteLine("{0}:", oddNumbers[i]);
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
