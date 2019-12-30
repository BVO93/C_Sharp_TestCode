using System;
using System.Collections.Generic;
using System.Text;

namespace _6_TicTacToeGame
{
    class Console
    {
       public void PrintStartMessage()
        { 
            System.Console.WriteLine("Welocome to Tic Tac Toe !");
            System.Console.WriteLine("Lets play a new game");

        }

        public void PrintRawArray(Numbers numbers)
        {
            int rowLength = numbers.GetRowLength();  // Square array so only 1 D needed
            int columnLength = numbers.GetColumnLength();

            for(int i = 0; i < rowLength; i++){

                for (int j = 0; j < columnLength; j++)
                {
                    int data = numbers.GetNunber(i, j);
                    char toPrint;
                    if (data == 10)
                    {
                        toPrint = 'X';
                    } else if (data == 0)
                    {
                        toPrint = 'O';
                    }
                    else
                    {
                        toPrint = (char)(data + 48); // convert because ASCI 
                    }

                    System.Console.Write("|  {0} ", toPrint);
                }
                System.Console.WriteLine(" |");
                System.Console.WriteLine("-----------------");
            }

        }
        
        public int askInput(int person)
        {
            int data = 100;
            System.Console.WriteLine("Person {0}, enter number ?", person);
            string input = System.Console.ReadLine();
            try
            {
                data = Int32.Parse(input);
                System.Console.WriteLine(data);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Looks like this is not a number you are typing");
                System.Console.WriteLine("Please try again");
                askInput(person);
            }

            if(data < 1 || data > 9)
            {
                System.Console.WriteLine("Please enter number between 1 and 9 ");
            }

            return data;
        }


    }
}
