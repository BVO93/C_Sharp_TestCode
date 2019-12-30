using System;

namespace Properties_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //box.length = 3;
            box.Height = 4;
            box.Width = 5;
            box.setLenght(5);

            box.DisplayInfo();


            Console.WriteLine("Hello World!");
        }
    }
}
