using Factory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Fatory
{
    internal class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal? CreateAnimal()
        {
            Random rnd = new();
            int type = rnd.Next(0, 3);
            return type switch
            {
                0 => new Dog(),
                1 => new Cat(),
                2 => new Duck(),
                _ => null,
            };
        }
    }
}
