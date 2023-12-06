using Factory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Fatory
{
    internal class BasicAnimalFactory : IAnimalFactory
    {
        int index = 0;
        public IAnimal? CreateAnimal()
        {
            switch (index)
            {
                case 0:
                    {
                        index++;
                        return new Dog();
                    }
                case 1:
                    {
                        index++;
                        return new Cat();
                    }
                case 2:
                    {
                        index = 0;
                        return new Duck();
                    }
                default: return null;
            }
        }
    }
}
