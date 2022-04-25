using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Tv :ElectricalDevice
    {



        public Tv(bool isOn, string brand) : base(isOn, brand)
        {
       
        }


        public void WatchTV()
        {
            if (IsOn)
            {


                Console.WriteLine("TV is on ");
            }
            else
            {

                Console.WriteLine("TV is not On ");
            }
        }
    }
}

