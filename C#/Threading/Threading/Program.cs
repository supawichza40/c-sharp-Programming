using System;
using System.Threading;
namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(1000);
            //Stop the main thread. one thread only
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");


            //Doing things in parallel 
            //CREATE A THREAD AND RUN FUNCTION INSIDE.
            //new Thread(() => 
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Thread 1");
            //        Thread.Sleep(1000);
            //    }

            //}).Start();
            //new Thread(() =>
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Thread 2");
            //        Thread.Sleep(1000);
            //    }

            //}).Start();
            //new Thread(() =>
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Thread 3");
            //        Thread.Sleep(1000);
            //    }

            //}).Start();

            //Create Thread
            var thread2 = new Thread(() =>
            {
                Thread.Sleep(1000);

            });

        }
    }
}
