using System;
using System.Collections.Generic;

namespace Lab7SectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, string> myDectionary = new Dictionary<int, string>();

                int objectCount = 0;

                Console.WriteLine("Enter the count of Dictionary objects you want to enter: ");
                objectCount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your list Key(\"Integer\"), Value(\"string\"): ");
                int j = 0;
                do
                {
                    Console.Write("Key(int): ");
                    int key = Convert.ToInt32(Console.ReadLine());

                    if (myDectionary.ContainsKey(key))
                    {
                        Console.WriteLine("you entered this key before, try another one");
                        continue;
                    }
                    Console.Write("Value(string): ");
                    string value = Console.ReadLine();

                    myDectionary.Add(key, value);

                    j++;
                } while (j < objectCount);

                Console.WriteLine();
                Console.WriteLine("Entered names:");
                foreach (var item in myDectionary)
                {
                    Console.WriteLine("{0}", item);
                }

                Console.WriteLine();
                Console.WriteLine("Enter a Key to check:");

                int checkKey = Convert.ToInt32(Console.ReadLine());

                if(myDectionary.ContainsKey(checkKey))
                {
                    Console.WriteLine("the value of this index is: {0}", myDectionary[checkKey]);
                }
                else
                {
                    Console.WriteLine("Key not exists");
                }

                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine("Exception: Wrong Data");
            }

        }
    }
}
