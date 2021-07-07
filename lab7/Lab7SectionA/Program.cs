using System;
using System.Collections;

namespace Lab7SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList myArrayList = new ArrayList();

                Console.WriteLine("Enter Integer number:");
                int intNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter float number:");
                float floatNumber = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter string value:");
                string myString = Console.ReadLine();

                myArrayList.Add(intNumber);
                myArrayList.Add(floatNumber);
                myArrayList.Add(myString);

                Console.WriteLine("Entered Data:");
                for(int i = 0; i < myArrayList.Count; i++)
                {
                    Console.WriteLine("index {0}: {1}", i, myArrayList[i]);
                }

                Console.WriteLine("Enter index you want to delete");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("the deleted value is {0}: {1}", index, myArrayList[index]);
                myArrayList.RemoveAt(index);

                Console.WriteLine("List after deletion:");
                for (int i = 0; i < myArrayList.Count; i++)
                {
                    Console.WriteLine("index {0}: {1}", i, myArrayList[i]);
                }

                Console.ReadKey();
            }
            catch(Exception)
            {
                Console.WriteLine("Wrong Data");
            }
        }
    }
}
