using DataAccessor.Models;
using System.Collections.Generic;

namespace DataAccessor
{
    public interface IDatabaseContext
    {
        IEnumerable<Vendor> Vendors { get; }
    }
}
