using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.Shipping.Strategies
{
    // International: distance * 5.0 + weight * 2.0 + 15% tax
    public class InternationalShippingStrategy : IShippingStrategy
    {
        public decimal CalculateCost(decimal distance, decimal weight)
        {
            decimal baseCost = distance * 5.0m + weight * 2.0m;
            return baseCost * 1.15m; // +15% tax
        }
    }
}