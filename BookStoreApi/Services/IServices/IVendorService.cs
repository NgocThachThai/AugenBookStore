using Services.Dtos;
using System.Collections.Generic;

namespace Services.IServices
{
    public interface IVendorService
    {
        IEnumerable<PackageDto> GetPackagesAvailableInThisMonth();
    }
}
