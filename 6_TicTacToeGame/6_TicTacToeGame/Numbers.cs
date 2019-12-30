using System;
using System.Collections.Generic;
using System.Text;

namespace _6_TicTacToeGame
{
    class Numbers
    {
        private int[,] numbers = new int[3, 3];



        public void ResetArray()
        {
            // herdefinitie van array 
            numbers = new int[,] { { 1, 2, 3},
                        { 4, 5, 6},
                        { 7, 8, 9}, };


        }

        public int GetNunber(int row, int column)
        {
            return numbers[row, column];
        }

        public void SetNumber(int data, int row, int column)
        {
            numbers[row, column] = data;
            return;
        }
        public int GetRowLength()
        {
            return numbers.GetLength(0);
        }

        public int GetColumnLength()
        {
            return numbers.GetLength(1);
        }

        public int[] getPosOfValue(int data)
        {
            int rowLength = GetRowLength();  // Square array so only 1 D needed
            int columnLength = GetColumnLength();
            int[] val = new int[] { 88, 88 };
            for (int i = 0; i < rowLength; i++)
            {

                for (int j = 0; j < columnLength; j++)
                {
                    if (data == GetNunber(i, j))
                    {
                        val = new int[] { i, j };
                        return val;
                    }
                }
            }
            return val;
        }


        public void checkIfWon(int personBusy, int row, int column)
        {
            int checkVal;
            if (personBusy == 1)
            {
                checkVal = 10;
            }
            else
            {
                checkVal = 0;
            }
            int tempVal;
            int tempRow;
            int tempColumn;

            tempRow = row -  1;
            tempColumn = column - 1;

            while(tempRow <= (row + 1))
            {
                if(tempRow > 0 && tempRow < 10)
                {
                    while(tempColumn <= (column +1))
                    {
                        if(tempColumn > 0 && tempColumn < 10)
                        {
                            tempVal = GetNunber(tempRow, tempColumn);
                            if(checkVal == tempVal)
                            {
                                System.Console.WriteLine("Second value found , checking tirth");



                                checkIfReallyWon(personBusy, tempRow, tempColumn, row, column);
                             


                            }

                        }

                        tempColumn++;
                    }


                }

                tempRow++;
            }



            return;

        }



        public void checkIfReallyWon(int personBusy, int row, int column, int firstRow, int firstColumn)
        {
            int checkVal;
            if (personBusy == 1)
            {
                checkVal = 10;
            }
            else
            {
                checkVal = 0;
            }
            int tempVal;
            int tempRow;
            int tempColumn;

            tempRow = row - 1;
            tempColumn = column - 1;

            while (tempRow <= (row + 1))
            {
                if (tempRow > 0 && tempRow < 10)
                {
                    while (tempColumn <= (column + 1))
                    {
                        if (tempColumn > 0 && tempColumn < 10)
                        {
                            tempVal = GetNunber(tempRow, tempColumn);
                            if (checkVal == tempVal)
                            {
                                if (tempRow == firstRow && tempColumn == firstColumn)
                                {

                                }
                                else
                                {
                                    System.Console.WriteLine("Thirth value found , player {0} won",  personBusy );
                                    break;
                                }










                            }

                        }

                        tempColumn++;
                    }


                }

                tempRow++;
            }


            return;


        }





    }
}
