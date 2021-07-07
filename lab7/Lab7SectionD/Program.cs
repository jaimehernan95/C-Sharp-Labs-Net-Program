using System;
using System.Collections;

namespace Lab7SectionD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack myStack = new Stack();
                int objectCount = 4, j = 0;

                Console.WriteLine("Kindly Enter 4 values in a stack:");
                do
                {
                    Console.Write("value type(1 => string, 2 => int, 3 => double, 4 => boolean): ");
                    int valueType = Convert.ToInt32(Console.ReadLine());

                    if (valueType < 1 || valueType > 4)
                    {
                        Console.WriteLine("Wrong Type");
                        continue;
                    }

                    Console.Write("Value: ");
                    string value = Console.ReadLine();

                    switch (valueType)
                    {
                        case 1:
                            myStack.Push(value);
                            break;
                        case 2:
                            myStack.Push(Convert.ToInt32(value));
                            break;
                        case 3:
                            myStack.Push(Convert.ToDouble(value));
                            break;
                        case 4:
                            myStack.Push(Convert.ToBoolean(value));
                            break;
                    }

                    j++;
                } while (j < objectCount);

                Console.WriteLine();
                Console.WriteLine("Total stack count: {0}", myStack.Count);

                Console.WriteLine("Top value in the stack: {0}", myStack.Peek());
                Console.WriteLine("Removing Top value in the stack: {0}", myStack.Pop());

                Console.WriteLine();
                Console.WriteLine("Stack new Data");
                foreach (var item in myStack)
                {
                    Console.WriteLine(item);
                }

                Console.ReadKey();
            }
            catch(Exception)
            {
                Console.WriteLine("Exception: Wrong Data");
            }
        }
    }
}
