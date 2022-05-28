using Solid;
using System;

namespace InterfaceSegregationDependencyInjection
{
    public class Dog : Animal, IRunnable
    {
        public override void eat()
        {
            Console.WriteLine("Köpek Maması yedi.");
        }

        public void Run()
        {
            Console.WriteLine("Koştu.");
        }
    }
}
