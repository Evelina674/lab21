using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.Shipping.Strategies
{
    // distance * 1.5 + weight * 0.5
    public class StandardShippingStrategy : IShippingStrategy
    {
        public decimal CalculateCost(decimal distance, decimal weight)
            => distance * 1.5m + weight * 0.5m;
    }
}