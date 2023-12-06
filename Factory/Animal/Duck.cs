using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Animal
{
    internal class Duck : IAnimal
    {
        public string SayName()
        {
            return "Duck";
        }
    }
}
