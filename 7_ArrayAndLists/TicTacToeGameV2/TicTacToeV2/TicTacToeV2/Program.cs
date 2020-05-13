using System;

namespace TicTacToeV2
{
    class Program
    {

        static void Main(string[] args)
        {
            int personToPlay = 1;
            Console.WriteLine("Hello World!");

            while (true)
            {
                bool winner = false;
                Array array = new Array();
                ToUser toUser = new ToUser();

                array.FillArray();


                while (winner == false)
                {
                    array.PrintArray();
                    int userInput = toUser.AskInput(personToPlay);
                    array.LockNumber(userInput, personToPlay);

                    Console.Clear();

                    winner = array.CheckIfWon(personToPlay);

                    if(winner == true)
                    {
                        Console.WriteLine("Congrats player {0}, you have won.", personToPlay);
                    }

                

                    personToPlay = toUser.SwitchUser(personToPlay);

                  
                }

                array.PrintArray();
                Console.WriteLine("Press a key to start again.");
                Console.ReadKey();

                while (Console.In.Peek() != -1)
                    Console.In.Read();


                Console.Clear(); ;



            }

        }
    }



    


}
