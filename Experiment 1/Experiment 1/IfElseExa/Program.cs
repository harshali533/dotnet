using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num = 5;

            if (Num % 2 == 0)
            {
                Console.WriteLine("Num is Even");
            }
            else
            {
                Console.WriteLine("Num is Odd");
            }
        }
    }
}
