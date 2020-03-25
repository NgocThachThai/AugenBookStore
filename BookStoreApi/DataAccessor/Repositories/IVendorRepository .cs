using DataAccessor.Common;
using DataAccessor.Models;
using System.Collections.Generic;

namespace DataAccessor.Repositories
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        IEnumerable<Vendor> GetAllVendor();
        double GetServiceCostByServiceType(ServiceType serviceType);
    }
}
