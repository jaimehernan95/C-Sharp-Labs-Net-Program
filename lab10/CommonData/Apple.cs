using System;
using System.Collections.Generic;
using System.Text;

namespace CommonData
{
    public class Apple : Fruit
    {

        public Apple() : base() { }

        public Apple(string name) : base(name) { }

        public override void ChangeName(string newName)
        {
            Name = newName;
            Console.WriteLine("New Fruit Name: {0}", Name);
        }
    }
}
