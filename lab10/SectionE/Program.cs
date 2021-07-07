using CommonData;
using System;

namespace SectionE
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Vehicle", "Model");
            Honda h = new Honda("Honda", "Accord");
            Civic c = new Civic("Honda", "Civic");

            Apple a = new Apple("Fruit");
            

            v.DisplayInfo();
            h.DisplayInfo();
            c.DisplayInfo();
            a.ChangeName("Apple");
            a.DisplayInfo();
        }
    }
}
