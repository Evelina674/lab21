using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab21.Shipping.Strategies;

namespace lab21.Shipping.Services
{
    public static class ShippingStrategyFactory
    {
        public static IShippingStrategy Create(string shippingType)
        {
            return shippingType.ToLower() switch
            {
                "standard" => new StandardShippingStrategy(),
                "express" => new ExpressShippingStrategy(),
                "international" => new InternationalShippingStrategy(),
                "night" => new NightShippingStrategy(),
                _ => throw new ArgumentException("Unknown shipping type")
            };
        }
    }
}