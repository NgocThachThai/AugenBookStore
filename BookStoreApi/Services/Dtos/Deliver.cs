using DataAccessor.Common;
using DataAccessor.Models;

namespace Services.Dtos
{
    public abstract class Deliver
    {
        public abstract string ServiceName { get; }
        public abstract ServiceType ServiceType { get; }
        public double Cost { get; set; }
        public Book Book { get; set; }
    }
}
