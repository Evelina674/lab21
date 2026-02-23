using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.CloudStorage.Plans
{
    // EnterprisePlan (прогресивна шкала):
    // Base: $100/month includes 1000GB and up to 20 users
    // Extra storage:
    //   1..1000 GB extra -> $0.10 per GB
    //   1001+ GB extra   -> $0.07 per GB (на обсяг понад 1000 extra)
    // Extra users: +$3 per user over 20
    public class EnterprisePlan : ICloudPlanStrategy
    {
        public string Name => "Enterprise";

        public decimal CalculateMonthlyCost(int storageGb, int users)
        {
            decimal cost = 100m;

            int extraGb = storageGb - 1000;
            if (extraGb > 0)
            {
                int tier1 = extraGb <= 1000 ? extraGb : 1000;
                int tier2 = extraGb > 1000 ? (extraGb - 1000) : 0;

                cost += tier1 * 0.10m;
                cost += tier2 * 0.07m;
            }

            int extraUsers = users - 20;
            if (extraUsers > 0) cost += extraUsers * 3m;

            return cost;
        }
    }
}
