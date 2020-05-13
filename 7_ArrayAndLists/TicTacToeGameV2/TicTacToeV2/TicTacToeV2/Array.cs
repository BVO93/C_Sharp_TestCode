using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeV2
{
    class Array
    {
        private int[,] numbers = new int  [3, 3];


        public void FillArray()
        {
            numbers = new int[,] { { 1, 2, 3 },
                                   { 4, 5, 6 },
                                   { 7, 8, 9 },
            };

        }

        public int GetNumber(int row, int column)
        {
            return numbers[row, column];
        }


        public void PrintArray()
        {
        
            for (int r= 0; r < 3; r++){

                for (int c = 0;  c < 3; c++){

                    // check if number needs to be replaced by O (99) or X (88)

                    if (GetNumber(r, c) == 99)
                    {
                        System.Console.Write("|  O ");
                    }
                    else if (GetNumber(r, c) == 88)
                    {
                        System.Console.Write("|  X ");
                    }
                    else
                    {
                        System.Console.Write("|  {0} ", numbers[r, c]);
                    }
                }
                Console.WriteLine("|");
                System.Console.WriteLine("-----------------");

            }
            return;
        }


        public (int, int) SearchNumber(int input)
        {

            for (int r = 0; r < 3; r++)
            {

                for (int c = 0; c < 3; c++)
                {
                    if (GetNumber(r, c) == input)
                    {
                        return (r, c);
                    }

                }
            }

            Console.WriteLine("Yor input is invalid. That is unexpected");
            return (-1, -1);
        }

        public void LockNumber(int input, int personToPlay)
        {
            (int r, int c) = SearchNumber(input);

            Console.WriteLine( "Number found at {0} and {1}", r , c);

            if( r == -1 || c == -1){
                Console.WriteLine("No good number, try again" );

                return;
            }

            if (personToPlay == 1)
            {
                numbers[r,c] = 99;
            }
            else
            {
                numbers[r, c] = 88;
            }

            return;
        }



        public bool CheckIfWon(int personToPlay)
        {
            int number = 0;
            if(personToPlay == 1)
            {
                number = 99;
            }
            else
            {
                number = 88;
            }

            // Check vertical 
            for(int i = 0; i < 3; i++)
            {
                if(GetNumber(0,i) == number)
                {
                    if(GetNumber(1,i) == number)
                    {
                        if(GetNumber(2,i) == number)
                        {
                            Console.WriteLine("Found a vertical match at line {0}", i);
                            return (true);
                        }
                    }
                }
            }

            // Check horizontal 
            for(int i = 0; i < 3; i++)
            {
                if (GetNumber(i, 0) == number)
                {
                    if (GetNumber(i, 1) == number)
                    {
                        if (GetNumber(i, 2) == number)
                        {
                            Console.WriteLine("Found a Horizontal match at line {0}", i);
                            return (true);
                        }
                    }
                }

            }

            // Check Cross Left to right

                if (GetNumber(0, 0) == number)
                {
                    if (GetNumber(1, 1) == number)
                    {
                        if (GetNumber(2, 2) == number)
                        {
                            Console.WriteLine("Found a Cross match ");
                            return (true);
                        }
                    }
                }

            // Check cross right to left
            if (GetNumber(0, 2) == number)
            {
                if (GetNumber(1, 1) == number)
                {
                    if (GetNumber(2, 0) == number)
                    {
                        Console.WriteLine("Found a Cross match");
                        return (true);
                    }
                }
            }





            return false;
        }



    };


}

