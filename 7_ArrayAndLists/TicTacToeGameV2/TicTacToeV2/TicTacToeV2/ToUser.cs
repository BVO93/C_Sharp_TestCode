using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeV2
{
    class ToUser
    {
        public int AskInput(int userToPlay)
        {
            Console.WriteLine(" User {0}, provide number please", userToPlay);
            char input = (char)Console.Read();
            //Throw the enter etc away.
            while (Console.In.Peek() != -1)
                Console.In.Read();

            int inputInt = 500;
            // Check if the number is a int
            try
            {
                inputInt = Convert.ToInt32(input);
                inputInt = inputInt - 48;
            }
            catch
            {
                Console.WriteLine(" You have not provided a number. Please do !" );
                AskInput(userToPlay);
            }
            // check that the number is in range and not 88 (X) or 99 (O)
            
            if(inputInt == 88 || inputInt == 99)
            {
                Console.WriteLine("This number is already selected, please provide other one !");
                AskInput(userToPlay);
            } 

            if(inputInt < 1 || inputInt > 9)
            {
                Console.WriteLine("Select a valid number please !");
                AskInput(userToPlay);
            }
            

            Console.WriteLine(" You selected {0}" , inputInt);

            return inputInt;
        }


        public int SwitchUser(int userToPlay)
        {
            if (userToPlay == 1)
            {
                return 2;
            } else
            {
                return 1;
            }

        }




    }
}
