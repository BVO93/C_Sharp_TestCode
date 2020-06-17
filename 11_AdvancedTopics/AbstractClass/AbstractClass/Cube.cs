using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Cube : Shapes
    {
        //*******  PREOPERTIES *******//
        public double Length { get; set; }


        //*******  CONSTRUCTOR  *******//
        public Cube(double length)
        {
            Name = "Cube";
            Length = length;

        }

        
        // *******  OVERRIDE  *******//
        public virtual void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The cube has a lenght of {Length}");
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);

        }

    }
}
