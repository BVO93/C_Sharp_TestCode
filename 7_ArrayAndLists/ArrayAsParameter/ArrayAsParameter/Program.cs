using System;

namespace ArrayAsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[] { 1, 5, 13, 8, 20, 17, 2, 19, 4, 6, 10, 12, 13, 0 };

            double av = getAverage(grades);

            
            Console.WriteLine("Av is {0} !", av);


        }




        static double getAverage(int[] gradesArray)
        {

            int size = gradesArray.Length;

            double average;
            int sum = 0;

            for(int i = 0; i< size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double) sum / size;

            return average;
        }


    }
}
