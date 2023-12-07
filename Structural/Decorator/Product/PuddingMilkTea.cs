using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Base;

namespace Decorator.Product
{
    internal class PuddingMilkTea : MilkTeaDecorator
    {
        public PuddingMilkTea(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override int Count()
        {
            return 3 + base.Count();
        }
    }
}
