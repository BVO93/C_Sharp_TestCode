using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Ex2
{
    class Employee
    {
        //*******  PROPERTIES *******//

        // PROTECTED 
        protected string Name { get; set;}
        protected string FirstName { get; set;}
        protected int Salary { get; set;}


        //*******  CONSTRUCTOR  *******//
        //DEFAULT 
        public Employee() {
            Name = "Oceans";
            FirstName = "Frank";
            Salary = 1000;
        }

        // EXTENDED 
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;

        }



        //******* METHODS  *******//

        public void Work()
        {
            Console.WriteLine("Doing some work\n");
        }

        public void Pause()
        {
            Console.WriteLine("Taking a break\n");
        }

    }
}
