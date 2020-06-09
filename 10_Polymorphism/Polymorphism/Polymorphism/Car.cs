using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        //*******  PROPERTIES  *******//
        // public 
        public int HP { get; set; }
        public string color { get; set; }

        //Protected
        //has a relationship 
        protected CarIdInfo carIdInfo = new CarIdInfo();


        //*******  CONSTRUCTOR  *******//
        // Default
        public Car()
        {
            HP = 100;
            color = "Black";
        }
        // Extended
        public Car(int HP , string color)
        {
            this.HP = HP;
            this.color = color;
        }

        public void SetCarIdInfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }

        //********  METHODS  *******//
        // Public 
        public virtual void showDetails( ) {
            Console.WriteLine("This car has {0} HP and the color is {1}", HP, color);
        }


        public virtual void repair()
        {
            Console.WriteLine("Car is repaired!" );
        }

        public void GetCaridInfo()
        {
            Console.WriteLine("The car has id {0} and owned by {1} ", carIdInfo.IDNum, carIdInfo.Owner);
        }




    }
}
