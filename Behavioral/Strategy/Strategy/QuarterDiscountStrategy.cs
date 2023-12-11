using Strategy.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    internal class QuarterDiscountStrategy : IDiscountStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.75;
        }
    }
}
