using System;

namespace SectionC
{
    public enum DaysOfWeek { Mon, Tue, Wed, Thur, Fri, Sat, Sun }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a day (just number):");
            Console.WriteLine("{0} => {1}", (int) DaysOfWeek.Mon, DaysOfWeek.Mon);
            Console.WriteLine("{0} => {1}", (int)DaysOfWeek.Tue, DaysOfWeek.Tue);
            Console.WriteLine("{0} => {1}", (int)DaysOfWeek.Wed, DaysOfWeek.Wed);
            Console.WriteLine("{0} => {1}", (int)DaysOfWeek.Thur, DaysOfWeek.Thur);
            Console.WriteLine("{0} => {1}", (int)DaysOfWeek.Fri, DaysOfWeek.Fri);
            Console.WriteLine("{0} => {1}", (int)DaysOfWeek.Sat, DaysOfWeek.Sat);
            Console.WriteLine("{0} => {1}", (int)DaysOfWeek.Sun, DaysOfWeek.Sun);

            int day = int.Parse(Console.ReadLine());

            DaysOfWeek theDay = (DaysOfWeek)day;

            Console.WriteLine("the selected day is: {0} => {1}", (int)theDay, theDay);

            Console.ReadKey();

        }
    }
}
