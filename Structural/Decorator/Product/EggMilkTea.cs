using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Base;

namespace Decorator.Product
{
    internal class EggMilkTea : MilkTeaDecorator
    {
        public EggMilkTea(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override int Count()
        {
            return 7 + base.Count();
        }
    }
}
