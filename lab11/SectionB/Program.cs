using CommonData;
using System;

namespace SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            FileOperations fo = new FileOperations();


            Console.WriteLine("Enter Person Name:");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter Person Age:");
            person.Age = int.Parse(Console.ReadLine());

            fo.WriteObjectToFile(person);
            fo.ReadObjectFromFile();


        }
    }
}
