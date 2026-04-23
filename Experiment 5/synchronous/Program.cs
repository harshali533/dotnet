using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program started");

        Task1();
        Task2();
        Task3();

        Console.WriteLine("Program ended");
    }

    static void Task1()
    {
        Console.WriteLine("Task 1 started");
        Thread.Sleep(2000); // wait for 2 seconds
        Console.WriteLine("Task 1 completed");
    }

    static void Task2()
    {
        Console.WriteLine("Task 2 started");
        Thread.Sleep(2000);
        Console.WriteLine("Task 2 completed");
    }

    static void Task3()
    {
        Console.WriteLine("Task 3 started");
        Thread.Sleep(2000);
        Console.WriteLine("Task 3 completed");
    }
}