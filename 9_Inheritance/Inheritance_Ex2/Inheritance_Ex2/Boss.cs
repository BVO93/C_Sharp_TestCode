using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Ex2
{
    class Boss: Employee
    {
        //*******  PROPERTIES *******//
        //PROTECTED
        string CompanyCar { get; set; }


        //******* CONSTRUCTOR  *******//
        //DEFAULT 
        public Boss() { }

        //EXTENDED 
        public Boss(string name, string firstName, int salary, string companyCar)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;

            this.CompanyCar = companyCar;
        }


        //*******  METHODS  *******//
        public void lead()
        {
            Console.WriteLine("I am leading a bit\n");
        }


    }
}
