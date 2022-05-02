using System;
using System.Threading;

namespace threadsync2_3
{
    class Program
    {
        static int count = 0;
        static object _lock = true;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(HashtagPrinter);
            t1.Name = "t1";
            t1.Start();
            Thread t2 = new Thread(StarPrinter);
            t2.Name = "t2";
            t2.Start();
        }

        static void HashtagPrinter()
        {
            while (true)
            {
                lock (_lock)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write("#");
                    }
                    count += 60;
                    Console.Write(count + "\n");
                }
                Thread.Sleep(1000);
            }
        }

        static void StarPrinter()
        {
            while (true)
            {
                lock (_lock)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write("*");
                    }
                    count += 60;
                    Console.Write(count + "\n");
                }
                Thread.Sleep(1000);
            }
        }
    }
}
