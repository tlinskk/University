using System;
using System.Threading;
using System.Text;

class Program
{
    static int[] array = new int[18];
    static Random random = new Random();
    static readonly object consoleLock = new object(); 

    static void Main()
    {
        
        Console.OutputEncoding = Encoding.UTF8;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 91);
        }

        Console.WriteLine("Початковий масив:");
        lock (consoleLock)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine("\n");

        Thread t0 = new Thread(PrintSquares) { Name = "Потік T0" };
        Thread t1 = new Thread(PrintLessThanFifty) { Name = "Потік T1" };

        PrintThreadInfo(t0);
        PrintThreadInfo(t1);

        t0.Start();
        t1.Start();

        t0.Join();
        t1.Join();
    }

    static void PrintThreadInfo(Thread thread)
    {
        lock (consoleLock)
        {
            Console.WriteLine($"\nІм'я потоку: {thread.Name}");
            Console.WriteLine($"Id потоку: {thread.ManagedThreadId}");
            Console.WriteLine($"Пріоритет потоку: {thread.Priority}");
            Console.WriteLine($"Статус потоку: {thread.ThreadState}\n");
        }
    }

    static void PrintSquares()
    {
        lock (consoleLock)
        {
            Console.WriteLine($"\n[{Thread.CurrentThread.Name}] Квадрати всіх елементів масиву:");
            foreach (var item in array)
            {
                Console.WriteLine($"{item}^2 = {item * item}");
            }
        }
    }

    static void PrintLessThanFifty()
    {
        lock (consoleLock)
        {
            Console.WriteLine($"\n[{Thread.CurrentThread.Name}] Елементи масиву, менші 50:");
            foreach (var item in array)
            {
                if (item < 50)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}




