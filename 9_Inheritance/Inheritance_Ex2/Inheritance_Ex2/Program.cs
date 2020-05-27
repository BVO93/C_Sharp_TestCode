using System;

namespace Inheritance_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee employ1 = new Employee("Builder", "Bob", 2000);
            Employee employ2 = new Employee();

            Boss boss1 = new Boss("Boss", "Hugo", 3000, "Merc");

            Trainee train1 = new Trainee("Robert", "Jan", 100, "9 - 17", "18-20");

            employ1.Work();

            boss1.lead();

            train1.learn();
            train1.Work();


        }
    }
}
