using System;
using System.Text;

namespace SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstString = String.Empty;
            StringBuilder mySecondString = new StringBuilder();

            Console.WriteLine("the Default value of myFirstString of type string is: {0}", myFirstString);
            Console.WriteLine("the Default value of mySecondString of type StringBuilder is: {0}", mySecondString);
            Console.WriteLine();

            Console.WriteLine("Enter value in myFirstString");
            myFirstString = Console.ReadLine();

            Console.WriteLine("Enter value in mySecondString");
            mySecondString.Append(Console.ReadLine());

            Console.WriteLine("myFirstString in upper case: {0}", myFirstString.ToUpper());
            Console.WriteLine("myFirstString in Lower case: {0}", myFirstString.ToLower());
            Console.WriteLine("myFirstString in without start or end spaces: {0}", myFirstString.Trim());

            Console.WriteLine("mySecondString in upper case: {0}", mySecondString.ToString().ToUpper());
            Console.WriteLine("mySecondString in Lower case: {0}", mySecondString.ToString().ToLower());
            Console.WriteLine("mySecondString in without start or end spaces: {0}", mySecondString.ToString().Trim());

            Console.ReadKey();

        }
    }
}
