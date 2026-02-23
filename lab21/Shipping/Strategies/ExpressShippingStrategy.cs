using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.Shipping.Strategies
{
    // (distance * 2.5 + weight * 1.0) + 50 fixed fee
    public class ExpressShippingStrategy : IShippingStrategy
    {
        public decimal CalculateCost(decimal distance, decimal weight)
            => distance * 2.5m + weight * 1.0m + 50m;
    }
}