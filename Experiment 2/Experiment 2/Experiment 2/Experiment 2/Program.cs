using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Experiment_2
{
    // Abstraction
    abstract class Animal
    {
        public abstract void Sound();   // abstract method
    }

    // Inheritance
    class Dog : Animal
    {
        // Encapsulation
        private string name;

        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }

        // Polymorphism (method overriding)
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();   // object creation

            d.SetName("Tommy");  // using encapsulation
            Console.WriteLine("Dog Name: " + d.GetName());

            d.Sound();  // polymorphism
        }
    }
}
