using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingInterfaces
{
    class Car : Vehical, IDestroyable
    {

        public string DestructionSound { get; set; }


        public List<IDestroyable> DestroyablesNearby; 
        // List off all destroyable objects nearby


        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;

            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();

        }


        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Make fire");

            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }

        }
  
    }
}
