using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.CloudStorage.Plans
{
    // PersonalPlan:
    // Base: $10/month includes 50GB and 1 user
    // Extra storage: +$0.20 per GB over 50
    // Extra users: +$5 per user over 1
    public class PersonalPlan : ICloudPlanStrategy
    {
        public string Name => "Personal";

        public decimal CalculateMonthlyCost(int storageGb, int users)
        {
            decimal cost = 10m;

            int extraGb = storageGb - 50;
            if (extraGb > 0) cost += extraGb * 0.20m;

            int extraUsers = users - 1;
            if (extraUsers > 0) cost += extraUsers * 5m;

            return cost;
        }
    }
}