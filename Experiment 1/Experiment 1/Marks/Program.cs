using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M1 = 30;
            int M2 = 60;
            int M3 = 75;
            int M4 = 80;
            int M5 = 55;
            int sum = M1 + M2 + M3 + M4 + M5;

            if (sum * 100 / 500 >= 35)
            {
                Console.WriteLine("Student is Pass");
            }
            else
            {
                Console.WriteLine("Student is Fail");
            }

        }
    }
}
