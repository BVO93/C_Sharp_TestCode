using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Sphere : Shapes
    {
        // *******  PROPERTIES  *******//
        public double Radius { get; set; }

        //*******  CONSTRUCTOR *******//
        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        //*******  OVERRIDE *******//
        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
        }

        public virtual void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The S[here has a radius of {Radius}");
        }

    }
}
