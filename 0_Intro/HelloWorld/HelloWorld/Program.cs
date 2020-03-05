using System;

namespace HelloWorld
{
    class Program
    {
    

        static void Main(string[] args)
        {
            CalculateResults();

            Console.WriteLine(Add(Add(1, 2), Add(5, 6)));

            WriteSomethingSpecific("test");

            WriteSomething();
   
        }




        public static void WriteSomething()
        {
            Console.WriteLine("I am called");
            return;
        }



        public static void WriteSomethingSpecific( string input)
        {
            Console.WriteLine(input);

            return;
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        public static void CalculateResults()
        {
            Console.WriteLine("Give input 1 ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Give input 2 ");
            string s2 = Console.ReadLine();

            int i1 = int.Parse(s1);
            int i2 = int.Parse(s2);

            int result = i1 + i2;

            Console.WriteLine("Sum is " + result);


        }

    }

}












































// Chapter 1 and 2 
/*
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



    Console.WriteLine("Sum of " + num + " And " + num2 + " is " + sum);
    Console.WriteLine("Sum of " + d1 + " And " + d2 + " is " + dSum);


    Console.Read();
}
*/