using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 13;
            int num2 = 10;

            int sum = num + num2;

            double d1 = 32.5;
            double d2 = 15.7;

            double dSum = d1 + d2;

            float f1 = 15.5f;
            float f2 = 0.6f;



            Console.WriteLine( "Sum of " + num  + " And " +  num2 +  " is " +  sum);
            Console.WriteLine("Sum of " + d1 + " And " + d2 + " is " + dSum);


            Console.Read();
        }
    }
}
