using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingInterfaces
{
    class Chair : Furniture, IDestroyable
    {

       public string DestructionSound { get; set;  }


        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;

            DestructionSound = "ChariDestructionsund.mp3";

        }

        public void Destroy()
        {

            Console.WriteLine("Char color {0} was destroyed", Color);
            Console.WriteLine("Play char {0}", DestructionSound);
            Console.WriteLine("Spawn parts");
        }


    }
}
