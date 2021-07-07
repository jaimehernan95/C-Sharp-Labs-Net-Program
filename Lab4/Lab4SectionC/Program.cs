using System;

namespace Lab4SectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1, num2;
                Console.WriteLine("Enter first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                string theGreatest = num1 > num2 ? string.Format("{0} greater than {1}", num1, num2) :
                    string.Format("{0} greater than {1}", num2, num1);

                Console.WriteLine(theGreatest);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Kindly Enter a correct number");
            }
        }
    }
}
