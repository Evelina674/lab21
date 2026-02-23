using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.Shipping.Strategies
{
    // New shipping type added WITHOUT modifying existing strategies (OCP)
    public class NightShippingStrategy : IShippingStrategy
    {
        public decimal CalculateCost(decimal distance, decimal weight)
            => distance * 3.0m + weight * 1.2m + 75m;
    }
}