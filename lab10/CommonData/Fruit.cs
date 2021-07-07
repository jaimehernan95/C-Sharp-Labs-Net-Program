using System;

namespace CommonData
{
    public abstract class Fruit
    {
        public string Name { get; set; }

        public Fruit() { }
        public Fruit(string name)
        {
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Fruit name: ", Name);
        }

        public abstract void ChangeName(string newName);
    }
}
