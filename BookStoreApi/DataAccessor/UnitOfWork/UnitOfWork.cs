using DataAccessor.Repositories;
using DataAccessor.Repositories.Implemetation;

namespace DataAccessor.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IVendorRepository _vendorRepository;
        private readonly IDatabaseContext _databaseContext;
        public UnitOfWork(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IVendorRepository VendorRepository
        {
            get
            {
                if (_vendorRepository == null)
                {
                    _vendorRepository = new VendorRepository(_databaseContext);
                }
                return _vendorRepository;
            }
            set
            {
                _vendorRepository = value;
            }
        }
    }
}