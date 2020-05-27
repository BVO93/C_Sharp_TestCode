using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Ex2
{
    class Trainee: Employee
    {
        //*******  PROPERTIES  *******//
        //PROTECTED
        protected string WorkingHours { get; set; }
        protected string SchoolHours { get; set; }

        //*******  CONSTRUCTOR  *******//
        //DEFAULT 
        public Trainee() { }

        //EXTENDED 
        public Trainee(string name, string firstName, int salary, string workingHours, string schoolHours)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;

            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }


        //*******  METHODS *******//
        public void learn()
        {
            Console.WriteLine("Doing some learning\n");
        }

        //*******  OVERRIDE  *******//
        public void Work()
        {
            Console.Write("My working hours are: ");
            Console.WriteLine(WorkingHours);
        }

    }
}
