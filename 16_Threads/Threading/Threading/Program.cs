using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World 1!");

            /*
                        new Thread(() =>
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Thread 1 reporting ");


                        }).Start();

                        new Thread(() =>
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Thread 2 reporting ");


                        }).Start();


                        new Thread(() =>
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Thread 3 reporting ");


                        }).Start();


                        new Thread(() =>
                        {
                            Thread.Sleep(1000);

                            Console.WriteLine("Thread 4 reporting ");

                        }).Start();
            */


            /* Lesson 2
            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(5000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} ended");
            });
            Console.WriteLine($"Thread number : {thread.ManagedThreadId}");

            thread.Start();


            var test = taskCompletionSource.Task.Result;
            */



         new Thread(() =>
            {
                Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(5000);
                Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} ended");
            })
         { IsBackground = true }.Start();
        // Start in the back ground 

    

            Enumerable.Range(0, 1000).ToList().ForEach(f =>
            {

                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);

                    Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} ended");
                });

            });
   




        }
    }
}
