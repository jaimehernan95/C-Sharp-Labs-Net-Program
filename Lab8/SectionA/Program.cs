namespace SectionA
{
    using CommonData;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Person obj1 = new Person("Ashraf", "Abouelnaga", new DateTime(1977,8,1), "3001 Carling Str.", "Ottawa", "Canada");

            Console.WriteLine("obj1 Info");
            obj1.DisplayInfo();
            Console.WriteLine();

            Person obj2 = new Person();

            Console.WriteLine("obj2 Info before copy");
            obj2.DisplayInfo();
            Console.WriteLine();

            CopyData(obj1, obj2);

            Console.WriteLine("obj2 Info after copy");
            obj2.DisplayInfo();

            Console.ReadKey();
        }

        public static void CopyData(Person p1, Person p2)
        {
            p2.FirstName = p1.FirstName;
            p2.LastName = p1.LastName;
            p2.DateOfBirth = p1.DateOfBirth;
            p2.Address = p1.Address;
            p2.City = p1.City;
            p2.Country = p1.Country;
        }
    }
}
