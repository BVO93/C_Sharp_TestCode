using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapes = { new Sphere(3), new Cube(4) };

            foreach(Shapes shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1} ", shape.Name, shape.Volume());
            }
        }
    }
}
