using System;


namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            var cars = new System.Collections.Generic.List<Car>
            {
                new Audi(200, "Blue", "A4"),
                new BMW(250, "Grey", "320")

            };


            foreach(var car in cars)
            {
                car.showDetails();
                car.repair();

            }


            Car BMWZ3 = new BMW(200, "black", "z3");

            BMWZ3.showDetails();
            BMWZ3.SetCarIdInfo(1234, "Me");


            BMWZ3.GetCaridInfo();









        }
    }
}
