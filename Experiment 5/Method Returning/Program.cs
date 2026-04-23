using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Program started");

        await Task1();
        await Task2();

        Console.WriteLine("Program ended");
    }

    static async Task Task1()
    {
        Console.WriteLine("Task 1 started");
        await Task.Delay(2000);
        Console.WriteLine("Task 1 completed");
    }

    static async Task Task2()
    {
        Console.WriteLine("Task 2 started");
        await Task.Delay(2000);
        Console.WriteLine("Task 2 completed");
    }
}