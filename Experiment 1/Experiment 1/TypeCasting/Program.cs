using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit casting
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      
            Console.WriteLine(myDouble);

            //Explicit casting
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   
            Console.WriteLine(myInt1);
        }
    }
}
