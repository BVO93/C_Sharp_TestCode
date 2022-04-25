using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Radio myRadio = new Radio(false, "SonY");
            myRadio.SwitchOn();

            myRadio.ListenRadio();



            Console.WriteLine("Hello World!");
        }
    }
}
