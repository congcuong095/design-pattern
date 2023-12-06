using Factory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    internal class TwoLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal? CreateAnimal()
        {
            Random rnd = new();
            int type = rnd.Next(0, 2);
            return type switch
            {
                0 => new Chicken(),
                _ => new Duck(),
            };
        }
    }
}
