using System;

namespace CommonData
{
    public class Honda : Vehicle
    {
        public Honda():base() { }
        public Honda(string name, string model):base(name, model) { }
        public override void DisplayInfo()
        {
            Console.WriteLine("Honda Info:");
            Console.WriteLine("Name: {0}, Model: {1}", Name, Model);
            Console.WriteLine();
        }
    }
}
