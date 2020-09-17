using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace ThreadJoining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);

            thread1.Start();
            thread2.Start();

            Thread.Sleep(500);

            //thread1.Join();
            //Console.WriteLine("Thread 1 joined");

            thread2.Join();
  
            Console.WriteLine("Thread 2 Joined");

            if(thread1.Join(1000))
            {
                Console.WriteLine("Thread 1 done");
            }
            else
            {
                Console.WriteLine("Thread join timeouit thread1");
            }

            if (thread1.IsAlive)
            {
                Console.WriteLine("THread 1 is alive");
            }
            else
            {
                Console.WriteLine("Thread 1 was completed");
            }




            Console.WriteLine("Main thread ended");

        }


        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("thread 1 bakck to caller");
        }


        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
         
        }


    }
}
