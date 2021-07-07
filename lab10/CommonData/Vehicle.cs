using System;

namespace CommonData
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public Vehicle() { }

        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Vehicle Info:");
            Console.WriteLine("Name: {0}, Model: {1}", Name, Model);
            Console.WriteLine();
        }
    }
}
