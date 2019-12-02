using System;

namespace SimpleLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;batelfield
            bool isRegisterred = true;
            string userName = "";

            Console.WriteLine("Please enter userName");
            userName = Console.ReadLine();


            if (isRegisterred)
            {
                Console.WriteLine("Hi registered user ");
                if(userName != "")
                {
                    Console.WriteLine("Hi there , " + userName);
                    if(userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there Admin");
                    }
                }
            }


        }
    }
}
