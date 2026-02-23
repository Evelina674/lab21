using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab21.Shipping.Strategies;

namespace lab21.Shipping.Services
{
    public class DeliveryService
    {
        // As required: service depends only on interface, not on concrete strategies
        public decimal CalculateDeliveryCost(decimal distance, decimal weight, IShippingStrategy strategy)
        {
            return strategy.CalculateCost(distance, weight);
        }
    }
}