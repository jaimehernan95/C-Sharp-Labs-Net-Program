using System;

namespace Lab4SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a month (January, February, March, April, May, June, July, August, September, October, November, December)!");
            string month = Console.ReadLine();

            switch(month)
            {
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    Console.WriteLine("This month has 31 days");
                    break;

                case "February":
                    Console.WriteLine("This month has 28/29 days");
                    break;

                case "April":
                case "June":
                case "September":
                case "November":
                    Console.WriteLine("This month has 30 days");
                    break;

                default:
                    Console.WriteLine("Incorrect Month");
                    break;
            }


            Console.ReadKey();
        }
    }
}
