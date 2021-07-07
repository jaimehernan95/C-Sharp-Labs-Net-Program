using System;

namespace CommonData
{
    public class Cube: IShape
    {
        public string Name { get; set; }
        public double Length { get; set; }

        public Cube()
        {

        }

        public Cube(string name, double lenght)
        {
            Name = name;
            Length = lenght;
        }

        public double Volume()
        {
            double volume = Math.Pow(Length, 3);
            Console.WriteLine("the volume of cube {0} is: {1}", Name, volume);

            return volume;
        }
    }
}
