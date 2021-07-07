using CommonData;
using System;

namespace SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeDeserialize sd = new SerializeDeserialize();

            string filePath = @"D:\jsonData.txt";
            Person person = new Person
            {
                Name = "Ashraf Abouelnaga",
                Age = 48
            };


            sd.jsonSerialize(person, filePath);
            Person personFromJson = sd.jsonDeserialize(person.GetType(), filePath) as Person;
            Console.WriteLine("Name: {0}", personFromJson.Name);
            Console.WriteLine("Age: {0}", personFromJson.Age);

            Console.WriteLine();

            filePath = @"D:\xmlData.txt";

            sd.XmlSerialize(person.GetType(), person, filePath);
            Person personFromXml = sd.XmlDeserialize(person.GetType(), filePath) as Person;
            Console.WriteLine("Name: {0}", personFromXml.Name);
            Console.WriteLine("Age: {0}", personFromXml.Age);

            Console.ReadKey();
        }
    }
}
