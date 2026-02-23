using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using lab21.CloudStorage.Plans;

namespace lab21.CloudStorage.Services
{
    public static class CloudPlanFactory
    {
        public static ICloudPlanStrategy Create(string planType)
        {
            return planType.ToLower() switch
            {
                "personal" => new PersonalPlan(),
                "business" => new BusinessPlan(),
                "enterprise" => new EnterprisePlan(),
                _ => throw new ArgumentException("Unknown plan type")
            };
        }
    }
}