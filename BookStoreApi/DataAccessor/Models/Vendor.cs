using DataAccessor.Common;
using System.Collections.Generic;

namespace DataAccessor.Models
{
    public class Vendor : Entity
    {
        public ServiceType ServiceType { get; set; }
        public string Name { get; set; }
        public double BaseCost { get; set; }
        public Dictionary<string, float> FactorsForMonth { get; set; }
    }
}
