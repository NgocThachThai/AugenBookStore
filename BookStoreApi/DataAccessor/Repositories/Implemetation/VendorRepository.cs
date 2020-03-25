using DataAccessor.Common;
using DataAccessor.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DataAccessor.Repositories.Implemetation
{
    public class VendorRepository : Repository<Vendor>, IVendorRepository
    {
        public VendorRepository(IDatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public IEnumerable<Vendor> GetAllVendor()
        {
            return DatabaseContext.Vendors;
        }

        public double GetServiceCostByServiceType(ServiceType serviceType)
        {
            var data = DatabaseContext.Vendors.FirstOrDefault(x => x.ServiceType == serviceType);
            return data.BaseCost * data.FactorsForMonth.GetValueOrDefault(DateTime.Now.ToString("MMM", CultureInfo.InvariantCulture));

        }
    }
}
