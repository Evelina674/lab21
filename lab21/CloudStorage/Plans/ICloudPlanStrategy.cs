using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21.CloudStorage.Plans
{
    public interface ICloudPlanStrategy
    {
        decimal CalculateMonthlyCost(int storageGb, int users);
        string Name { get; }
    }
}
