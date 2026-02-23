using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab21.CloudStorage.Plans;

namespace lab21.CloudStorage.Services
{
    public class CloudStorageService
    {
        public decimal CalculateMonthlyCost(string planType, int storageGb, int users)
        {
            ICloudPlanStrategy plan = CloudPlanFactory.Create(planType);
            return plan.CalculateMonthlyCost(storageGb, users);
        }
    }
}