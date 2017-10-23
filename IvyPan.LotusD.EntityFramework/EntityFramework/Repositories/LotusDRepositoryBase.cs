using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace IvyPan.LotusD.EntityFramework.Repositories
{
    public abstract class LotusDRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LotusDDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected LotusDRepositoryBase(IDbContextProvider<LotusDDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class LotusDRepositoryBase<TEntity> : LotusDRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected LotusDRepositoryBase(IDbContextProvider<LotusDDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
