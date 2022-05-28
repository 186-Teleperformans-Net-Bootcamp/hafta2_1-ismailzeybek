using Solid;
using System;

namespace InterfaceSegregationDependencyInjection
{
    public class Bird: Animal ,IFlyable
    {
        public override void eat()
        {
            Console.WriteLine("Kuş Maması yedi.");
        }

        public void Fly()
        {
            Console.WriteLine("Uçtu");
        }
    }
}
