using DataAccessor.UnitOfWork;
using Services.Dtos;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Services.Services
{
    public class VendorService : IVendorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public VendorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<PackageDto> GetPackagesAvailableInThisMonth()
        {
            var vendors = _unitOfWork.VendorRepository.GetAllVendor();
            var result = vendors.Select(
                x => new PackageDto
                {
                    VendorId = x.Id.ToString(),
                    VendorName = x.Name,
                    ServiceType = x.ServiceType,
                    Cost = x.BaseCost*x.FactorsForMonth.GetValueOrDefault(DateTime.Now.ToString("MMM", CultureInfo.InvariantCulture))
                });
            return result;
        }
    }
}
