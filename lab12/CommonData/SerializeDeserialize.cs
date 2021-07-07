using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CommonData
{
    public class SerializeDeserialize
    {
        public void jsonSerialize(object obj, string filePath)
        {
            JsonSerializer js = new JsonSerializer();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File Not Exists");
            }

            TextWriter write = new StreamWriter(filePath);
            JsonWriter jw = new JsonTextWriter(write);
            js.Serialize(jw, obj);
            write.Close();
            jw.Close();
            Console.WriteLine("JSON Serialization Completed");
        }

        public object jsonDeserialize(Type dataType, string filePath)
        {
            JObject obj = null;
            JsonSerializer js = new JsonSerializer();

            if (!File.Exists(filePath))
            {
                return null;
            }

            StreamReader read = new StreamReader(filePath);
            JsonReader jr = new JsonTextReader(read);
            obj = js.Deserialize(jr) as JObject;
            read.Close();
            jr.Close();
            Console.WriteLine("JSON De Serialization Completed");

            return obj.ToObject(dataType);
        }

        public void XmlSerialize(Type dataType, object obj, string filePath)
        {
            XmlSerializer xs = new XmlSerializer(dataType);

            if (!File.Exists(filePath))
            {

            }

            TextWriter write = new StreamWriter(filePath);
            xs.Serialize(write, obj);
            write.Close();

            Console.WriteLine("xml Serialization Completed");
        }

        public object XmlDeserialize(Type dataType, string filePath)
        {
            object obj = null;
            XmlSerializer xs = new XmlSerializer(dataType);

            if (!File.Exists(filePath))
            {
                return obj;
            }
            TextReader read = new StreamReader(filePath);
            obj = xs.Deserialize(read);
            read.Close();

            Console.WriteLine("xml de-Serialization Completed");
            return obj;
        }

    }
}
