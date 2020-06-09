using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Audi: Car
    {
        //*******  PROPERTIES  *******//
        // Public
        private string brand = "Audi";
        public string model { get; set; }

        //*******  CONSTRUCTOR  *******//
        // Default 
        public Audi()
        {
            model = "A4";
        }

        //Extended
        public Audi(int HP, string color, string model): base(HP, color)
        {
            this.model = model;
        }

        //********  METHODS  *******//
        // Public 
        override public void showDetails()
        {
            Console.WriteLine("This car has {0} HP and the color is {1} the brand {2} {3}", HP, color, brand, model);
        }


       override public void repair()
        {
            Console.WriteLine("Audi is repaired!");
        }

    }
}
