using System;

namespace CreatingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Chair officeChair = new Chair {"Brown", "wood" };
            Chair gameChair = new Chair{"Brown", "wood " };


            Car damagedCar = new Car(80f, "Blue");



            damagedCar.DestroyablesNearby.Add(gameChair);
            damagedCar.DestroyablesNearby.Add(officeChair);

            damagedCar.Destroy();

        }
    }
}
