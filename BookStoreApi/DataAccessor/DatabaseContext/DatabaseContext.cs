using DataAccessor.Data;
using DataAccessor.Models;
using System.Collections.Generic;

namespace DataAccessor
{
    public class DatabaseContext : IDatabaseContext
    {
        public IEnumerable<Vendor> Vendors
        {
            get
            {
                return VendorData.Instance.Vendors;
            }
        }
    }
}
