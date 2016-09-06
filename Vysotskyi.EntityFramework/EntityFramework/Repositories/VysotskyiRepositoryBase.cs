using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Vysotskyi.EntityFramework.Repositories
{
    public abstract class VysotskyiRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<VysotskyiDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected VysotskyiRepositoryBase(IDbContextProvider<VysotskyiDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class VysotskyiRepositoryBase<TEntity> : VysotskyiRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected VysotskyiRepositoryBase(IDbContextProvider<VysotskyiDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
