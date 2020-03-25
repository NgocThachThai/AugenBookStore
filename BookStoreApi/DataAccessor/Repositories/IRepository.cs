using DataAccessor.Models;

namespace DataAccessor.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity, new()
    {
        //Here for generic functions. For speed up, I will not convert the functions to generic.
    }
}
