using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CommonData
{
    public class FileOperations
    {
        public string FilePath { get; set; }

        public FileOperations()
        {
            FilePath = @"D:\ashrafFile.txt";
        }

        public void WriteToFile(string[] lines)
        {

            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                foreach (var item in lines)
                    writer.WriteLine(item);
            }

            Console.WriteLine("Writing finished");
        }

        public void ReadFromFile()
        {

            if (!File.Exists(FilePath))
            {
                Console.WriteLine("File Not Exists");
                return;
            }
            using (StreamReader file = new StreamReader(FilePath))
            {
                string st = "";
                int lines = 0;
                while ((st = file.ReadLine()) != null)
                {
                    Console.WriteLine(st);
                    lines++;
                }
                Console.WriteLine("number of lines: {0}", lines);
            }
        }


        public void WriteObjectToFile(object obj)
        {

            FileStream stream;
            BinaryFormatter bf = new BinaryFormatter();

            if (!File.Exists(FilePath))
            {

            }
            stream = File.Create(FilePath);
            bf.Serialize(stream, obj);
            stream.Close();

            Console.WriteLine("Serialization Completed");
        }

        public Person ReadObjectFromFile()
        {
            Person obj = null;
            FileStream stream;
            BinaryFormatter bf = new BinaryFormatter();

            if (!File.Exists(FilePath))
            {
                return obj;
            }
            stream = File.OpenRead(FilePath);
            obj = (Person) bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine("de-Serialization Completed");
            Console.WriteLine("Person Name: {0}", obj.Name);
            Console.WriteLine("Person Age: {0}", obj.Age);
            return obj;
        }




    }
}
