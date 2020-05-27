using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // *** Explenation of jagged array ** //


            // store arrays in array
            // Declare that we have three arrays in array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];


            // other way 

            jaggedArray[0] = new int[] { 2, 3, 4, 5, 6, 77 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };


            // Alternative
            int[][] jaggedArray2 = new int[][]
            {
                new int[]{2,3,4,5,6,77},
                new int[] {1,2,3},
            };

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);

                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray2[i][j]);
                }
            }


            Console.WriteLine("Value in middle of arrray2 {0} ", jaggedArray2[1][1]);
        }




        // ** Test program friends arra ** /// 

        string[][] friendsAndFamilly = new string[][]
        {
            new string[]{"Test1",  "Test2" },
            new string[]{"Test3",  "Test4" },
            new string[]{"Test5",  "Test6" }
        };

    }
}
