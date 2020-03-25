using DataAccessor.Common;

namespace Services.Dtos
{
    public class PackageDto
    {
        public string VendorId { get; set; }
        public ServiceType ServiceType { get; set; }
        public string VendorName { get; set; }
        public double Cost { get; set; }
    }
}
