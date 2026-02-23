using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.Shipping.Strategies
{
    public interface IShippingStrategy
    {
        decimal CalculateCost(decimal distance, decimal weight);
    }
}