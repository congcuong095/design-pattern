using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Base
{
    internal class Ticket
    {
        public double Price { get; set; }
        public string Name { get; set; }
        private IDiscountStrategy discountStrategy;

        public void SetStrategy(IDiscountStrategy _discountStrategy)
        {
            discountStrategy = _discountStrategy;
        }

        public double Discount()
        {
           return discountStrategy.DoDiscount(Price);
        }
    }
}
