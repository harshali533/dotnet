using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Program started");

        Task t1 = Task1();
        Task t2 = Task2();
        Task t3 = Task3();

        await Task.WhenAll(t1, t2, t3);

        Console.WriteLine("Program ended");
    }

    static async Task Task1()
    {
        Console.WriteLine("Task 1 started");
        await Task.Delay(2000); // non-blocking delay
        Console.WriteLine("Task 1 completed");
    }

    static async Task Task2()
    {
        Console.WriteLine("Task 2 started");
        await Task.Delay(2000);
        Console.WriteLine("Task 2 completed");
    }

    static async Task Task3()
    {
        Console.WriteLine("Task 3 started");
        await Task.Delay(2000);
        Console.WriteLine("Task 3 completed");
    }
}