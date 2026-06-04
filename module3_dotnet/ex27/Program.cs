using System;
using System.Threading;

class Program
{
    static readonly object lock1 = new object();
    static readonly object lock2 = new object();

    static void ThreadADeadlock()
    {
        lock (lock1)
        {
            Console.WriteLine("Thread A acquired lock1, waiting for lock2...");
            Thread.Sleep(100);
            lock (lock2)
            {
                Console.WriteLine("Thread A acquired lock2.");
            }
        }
    }

    static void ThreadBDeadlock()
    {
        lock (lock2)
        {
            Console.WriteLine("Thread B acquired lock2, waiting for lock1...");
            Thread.Sleep(100);
            lock (lock1)
            {
                Console.WriteLine("Thread B acquired lock1.");
            }
        }
    }

    static void ThreadASafe()
    {
        bool gotLock1 = false;
        bool gotLock2 = false;
        try
        {
            Monitor.TryEnter(lock1, 500, ref gotLock1);
            if (gotLock1)
            {
                Console.WriteLine("Safe Thread A acquired lock1, trying lock2...");
                Thread.Sleep(100);
                Monitor.TryEnter(lock2, 500, ref gotLock2);
                if (gotLock2)
                    Console.WriteLine("Safe Thread A acquired lock2. Work done.");
                else
                    Console.WriteLine("Safe Thread A could not acquire lock2. Releasing lock1.");
            }
            else
            {
                Console.WriteLine("Safe Thread A could not acquire lock1.");
            }
        }
        finally
        {
            if (gotLock2) Monitor.Exit(lock2);
            if (gotLock1) Monitor.Exit(lock1);
        }
    }

    static void ThreadBSafe()
    {
        bool gotLock2 = false;
        bool gotLock1 = false;
        try
        {
            Monitor.TryEnter(lock2, 500, ref gotLock2);
            if (gotLock2)
            {
                Console.WriteLine("Safe Thread B acquired lock2, trying lock1...");
                Thread.Sleep(100);
                Monitor.TryEnter(lock1, 500, ref gotLock1);
                if (gotLock1)
                    Console.WriteLine("Safe Thread B acquired lock1. Work done.");
                else
                    Console.WriteLine("Safe Thread B could not acquire lock1. Releasing lock2.");
            }
            else
            {
                Console.WriteLine("Safe Thread B could not acquire lock2.");
            }
        }
        finally
        {
            if (gotLock1) Monitor.Exit(lock1);
            if (gotLock2) Monitor.Exit(lock2);
        }
    }

    static void Main()
    {
        Console.WriteLine("--- Deadlock Simulation (will be detected by Monitor.TryEnter in safe version) ---");
        Console.WriteLine("\n--- Deadlock Resolved with Monitor.TryEnter ---");
        Thread safeA = new Thread(ThreadASafe);
        Thread safeB = new Thread(ThreadBSafe);
        safeA.Start();
        safeB.Start();
        safeA.Join();
        safeB.Join();
        Console.WriteLine("Both threads completed without deadlock.");
    }
}
