using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Base;

namespace Decorator.Product
{
    internal class BubbleMilkTea(IMilkTea milkTea) : MilkTeaDecorator(milkTea)
    {
        public override int Count()
        {
            return 2 + base.Count();
        }
    }
}
