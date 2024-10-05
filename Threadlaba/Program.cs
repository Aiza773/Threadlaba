/*using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(DoWork);
        Thread thread2 = new Thread(DoWork);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads have completed their work.");
    }

    static void DoWork()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is executing iteration {i}");
            Thread.Sleep(100);
        }
    }
}
*/
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task1 = Task.Run(() =>
        {
            Thread.Sleep(1000); // Симуляция длительной операции
            Console.WriteLine("Асинхронная операция 1 завершена");
        });

        Task task2 = Task.Run(() =>
        {
            Thread.Sleep(2000); // Симуляция длительной операции
            Console.WriteLine("Асинхронная операция 2 завершена");
        });

        Task.WaitAll(task1, task2); // Ожидание завершения всех задач

        Console.WriteLine("Все асинхронные операции завершены");
    }
}
