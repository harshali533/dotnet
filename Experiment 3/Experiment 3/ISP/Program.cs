using System;

interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

class Printer : IPrint
{
    public void Print()
    {
        Console.WriteLine("Printing document");
    }
}

class Program
{
    static void Main()
    {
        Printer p = new Printer();
        p.Print();
    }
}