using System;
using System.Threading;

class Program
{
    static int counter = 0;
    static readonly object lockObj = new object();

    static void IncrementWithoutLock()
    {
        for (int i = 0; i < 1000; i++)
            counter++;
    }

    static void IncrementWithLock()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockObj)
            {
                counter++;
            }
        }
    }

    static void Main()
    {
        counter = 0;
        Thread[] threads = new Thread[5];
        for (int i = 0; i < 5; i++)
            threads[i] = new Thread(IncrementWithoutLock);
        foreach (Thread t in threads) t.Start();
        foreach (Thread t in threads) t.Join();
        Console.WriteLine("Without lock (expected 5000, actual): " + counter);

        counter = 0;
        Thread[] safeThreads = new Thread[5];
        for (int i = 0; i < 5; i++)
            safeThreads[i] = new Thread(IncrementWithLock);
        foreach (Thread t in safeThreads) t.Start();
        foreach (Thread t in safeThreads) t.Join();
        Console.WriteLine("With lock (expected 5000, actual): " + counter);
    }
}
