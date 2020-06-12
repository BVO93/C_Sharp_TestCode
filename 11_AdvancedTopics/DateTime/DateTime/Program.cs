using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1993, 10, 28);
            Console.WriteLine("My birthay is {0}", dateTime);


            // Write today
            Console.WriteLine(DateTime.Today);
            // Current time 
            Console.WriteLine(DateTime.Now);


        }
    }
}
