using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch()
            {
                throw; 
                Console.WriteLine("Wrong type");
            }

  

            Console.ReadKey();
        }
    }
}
