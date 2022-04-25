using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            Console.WriteLine(t2.Equals(t1));

        }
    }
}
