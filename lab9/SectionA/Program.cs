using CommonData;
using System;

namespace SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube("Cube A", 3);
            Sphere sphere = new Sphere("Sphere B", 3);
            Console.WriteLine("Total volume: {0}", cube.Volume() + sphere.Volume());
        }
    }
}
