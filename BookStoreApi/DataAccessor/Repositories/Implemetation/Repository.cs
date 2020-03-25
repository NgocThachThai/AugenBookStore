using DataAccessor.Models;

namespace DataAccessor.Repositories.Implemetation
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, IEntity, new()
    {
        protected IDatabaseContext DatabaseContext { get; set; }

        protected Repository(IDatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }
    }
}
