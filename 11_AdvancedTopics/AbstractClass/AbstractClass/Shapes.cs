using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Shapes
    {
        //*******  PROPERTIES *******//
        public string Name { get; set; }


        //*******  METHODS  *******//
        //Public
        public virtual void GetInfo()
        {
            Console.WriteLine($"\n this is a {Name}");
        }

        // Not implemented here, but in sub classes 
        public abstract double Volume();
    }
}
