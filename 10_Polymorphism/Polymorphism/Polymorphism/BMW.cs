using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class BMW: Car
    {
        //*******  PROPERTIES  *******//
        // Public
        private string brand = " BMW";
        public string model { get; set; }

        //*******  CONSTRUCTOR  *******//
        // Default 
        public BMW()
        {
            model = "3-series";
        }
        
        //Extended
        public BMW(int HP, string color, string model):base(HP, color)
        {
            this.model = model;
        }

        //********  METHODS  *******//
        // Public 
        override public void showDetails()
        {
            Console.WriteLine("This car has {0} HP and the color is {1} the brand {2} {3}", HP, color, brand,  model);
        }


        override public  void repair()
        {
            Console.WriteLine("BMW is repaired!");
        }




    }
}
