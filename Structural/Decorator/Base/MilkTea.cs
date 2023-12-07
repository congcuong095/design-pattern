using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Base
{
    internal class MilkTea : IMilkTea
    {
        public int Count()
        {
            return 5;
        }
    }
}
