using System;

namespace BasicClassStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create object of class 
            Human sissy = new Human("Sissy", "Wagner", "Brown", 29);
            sissy.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();



            Console.ReadKey();
        }
    }
}
