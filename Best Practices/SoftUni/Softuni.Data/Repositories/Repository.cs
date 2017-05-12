using Softuni.Data.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using EntityFramework.Extensions;

namespace Softuni.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SoftuniContext Context;

        public Repository(SoftuniContext context)
        {
            this.Context = context;
        }

        public void Add(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            //this.Context.Set<TEntity>().Delete(entities) when installed FWExtended

            foreach (TEntity entitie in entities)
            {
                this.Delete(entitie);
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Context.Set<TEntity>().Where(predicate);
        }

        public TEntity GetById(int id)
        {
            return this.Context.Set<TEntity>().Find(id);
        }
    }
}
