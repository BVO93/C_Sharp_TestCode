using System;

namespace Enums
{
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Month A = Month.Jan;

            Console.WriteLine(Month.Jan == A);

            Console.WriteLine((int)Month.Jun);



        }
    }
}
