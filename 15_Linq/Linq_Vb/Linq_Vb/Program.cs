using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq_Vb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            OddNumber(numbers);

        
        }


        static void OddNumber(int[] numbers)
        {
            Console.WriteLine("Odd numbers");

            //Div by two and no remainer
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine( oddNumbers);

            foreach(int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
            

        }

    }
}
