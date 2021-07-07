using System;

namespace CommonData
{
    public class Civic : Honda
    {
        public Civic() : base() { }
        public Civic(string name, string model) : base(name, model) { }
        public sealed override void DisplayInfo()
        {
            Console.WriteLine("Civic Info:");
            Console.WriteLine("Name: {0}, Model: {1}", Name, Model);
            Console.WriteLine();
        }
    }
}
