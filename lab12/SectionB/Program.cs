using System;

namespace SectionB
{
    public struct Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { FirstName = "Ashraf", LastName = "Aboulenaga"};
            Console.WriteLine("Person First Name: {0}", person.FirstName);
            Console.WriteLine("Person Last Name: {0}", person.LastName);

            Console.ReadKey();
        }
    }
}
