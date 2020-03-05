using System;

namespace MultiDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 2D array
            string[,] matrix;

            // 3D Array
            int[,,] threeD;


            int[,] array2D = new int[,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]);




        string[,,] array3D = new string[,,]
        {
            {
                {"010", "001" },
                {"010", "011" }
            },
            {
                {"100", "101" },
                {"110", "111" }
            }
        };

            Console.WriteLine("Central value is {0}", array3D[1, 1, 0]);

        }
    }
}
