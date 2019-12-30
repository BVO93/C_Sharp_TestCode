using System;

namespace _6_TicTacToeGame
{
    class Program
    {
   

        static void Main(string[] args)
        {

            Numbers numbers= new Numbers();
            Console myConsole = new Console();

            myConsole.PrintStartMessage();
            numbers.ResetArray();
            myConsole.PrintRawArray(numbers);

            int numbersTaken = 0;
            int personBusy = 1;

            while (numbersTaken < 9)
            {
              

                int returnedNumber = myConsole.askInput(personBusy);
                int[] pos = numbers.getPosOfValue(returnedNumber);
                if (pos[0] == 88)
                {
                    System.Console.WriteLine("Please enter a valid number");

                    while (pos[0] == 88)
                    {
                        returnedNumber = myConsole.askInput(personBusy);
                        pos = numbers.getPosOfValue(returnedNumber);

                    }
                }

                    if (personBusy == 1)
                    {
                        numbers.SetNumber(10, pos[0], pos[1]);
                        numbersTaken++;
                    }
                    else
                    {
                        numbers.SetNumber(0, pos[0], pos[1]);
                        numbersTaken++;
                    }

                numbers.checkIfWon(personBusy, pos[0], pos[1]);


                if (personBusy == 1)
                    {
                        personBusy = 2;
                    }
                    else
                    {
                        personBusy = 1;
                    }

            

                myConsole.PrintRawArray(numbers);
            }
            

     
   



        }

      


    }




}
