using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Radio : ElectricalDevice
    {
    

        public Radio(bool isOn, string brand) :base(isOn, brand)
        {
            
        }


        public void ListenRadio()
        {
            if (IsOn)
            {


                Console.WriteLine("Radio is on ");
            }
            else
            {

                Console.WriteLine("Radio is not On ");
            }
        }
    }
}
