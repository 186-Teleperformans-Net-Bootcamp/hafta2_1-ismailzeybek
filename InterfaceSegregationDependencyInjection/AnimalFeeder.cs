using InterfaceSegregationDependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class AnimalFeeder:IAnimalFeeder
    {
        public void Feed(Animal animal)
        {
            animal.eat();
        }

    }
}
