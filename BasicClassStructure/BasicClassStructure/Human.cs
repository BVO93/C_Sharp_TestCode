using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClassStructure
{
    class Human
    {
        //member variables 
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;


        public Human()
        {
            Console.WriteLine("Human made ");

        }


        // Parameterized constructor 

            public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;

        }

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi I'm {0} {1 } my eyes are {2} and i am  {3} years old ", firstName, lastName, eyeColor, age);
        }

    }
}
