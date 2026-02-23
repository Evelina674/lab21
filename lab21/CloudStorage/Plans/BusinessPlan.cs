using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.CloudStorage.Plans
{
    // BusinessPlan:
    // Base: $30/month includes 200GB and up to 5 users
    // Extra storage: +$0.15 per GB over 200
    // Extra users: +$4 per user over 5
    public class BusinessPlan : ICloudPlanStrategy
    {
        public string Name => "Business";

        public decimal CalculateMonthlyCost(int storageGb, int users)
        {
            decimal cost = 30m;

            int extraGb = storageGb - 200;
            if (extraGb > 0) cost += extraGb * 0.15m;

            int extraUsers = users - 5;
            if (extraUsers > 0) cost += extraUsers * 4m;

            return cost;
        }
    }
}