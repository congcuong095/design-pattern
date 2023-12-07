using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Base
{
    abstract class MilkTeaDecorator : IMilkTea
    {
        protected IMilkTea MilkTea;

        protected MilkTeaDecorator(IMilkTea milkTea)
        {
            MilkTea = milkTea;
        }
        public virtual int Count()
        {
            return MilkTea.Count();
        }
    }
}
