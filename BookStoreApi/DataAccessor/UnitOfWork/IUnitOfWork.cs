using DataAccessor.Repositories;

namespace DataAccessor.UnitOfWork
{
    public interface IUnitOfWork
    {
        IVendorRepository VendorRepository { get; set; }
    }
}
