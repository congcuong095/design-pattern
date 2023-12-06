using Factory.Animal;
using Factory.Fatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
       public abstract IAnimal? CreateAnimal();
    }
}
