using System;

class ArraySum
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 0;

        foreach (int n in arr)
        {
            sum += n;
        }

        Console.WriteLine("Sum of array elements = " + sum);
        Console.ReadLine();
    }
}
