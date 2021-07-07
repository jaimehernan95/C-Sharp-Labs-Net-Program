using System;

namespace CommonData
{
    public class Sphere: IShape
    {
        public string Name { get; set; }
        public double Radius { get; set; }

        public Sphere()
        {

        }

        public Sphere(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }

        public double Volume()
        {
            double volume = Math.PI * Math.Pow(Radius, 3)*4/3;
            Console.WriteLine("the volume of cube {0} is: {1}", Name, volume);

            return volume;
        }
    }
}
