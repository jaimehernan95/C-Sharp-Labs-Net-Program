using System;
using System.Collections;

namespace Lab7SectionE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Queue myQueue = new Queue();
                int objectCount = 4, j = 0;

                Console.WriteLine("Kindly Enter 4 values in a Queue:");
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
                            myQueue.Enqueue(value);
                            break;
                        case 2:
                            myQueue.Enqueue(Convert.ToInt32(value));
                            break;
                        case 3:
                            myQueue.Enqueue(Convert.ToDouble(value));
                            break;
                        case 4:
                            myQueue.Enqueue(Convert.ToBoolean(value));
                            break;
                    }


                    j++;
                } while (j < objectCount);

                Console.WriteLine();
                Console.WriteLine("Total Queue count: {0}", myQueue.Count);

                Console.WriteLine("first value in the Queue: {0}", myQueue.Peek());
                Console.WriteLine("Removing first value in the Queue: {0}", myQueue.Dequeue());


                Console.WriteLine();
                Console.WriteLine("Queue new Data");
                foreach (var item in myQueue)
                {
                    Console.WriteLine(item);
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
