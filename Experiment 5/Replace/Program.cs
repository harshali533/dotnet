using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program started");

        Task1();
        Task2();

        Console.WriteLine("Program ended");
    }

    static async void Task1()
    {
        Console.WriteLine("Task 1 started");
        await Task.Delay(2000); // replaced Thread.Sleep
        Console.WriteLine("Task 1 completed");
    }

    static async void Task2()
    {
        Console.WriteLine("Task 2 started");
        await Task.Delay(2000);
        Console.WriteLine("Task 2 completed");
    }
}