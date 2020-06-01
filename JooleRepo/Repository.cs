using JooleCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace JooleRepo
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal JooleDatabaseEntities context;
        internal DbSet<TEntity> dbSet;
        public Repository(JooleDatabaseEntities context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public TEntity Get(string identifier)
        {
            return dbSet.Find(identifier);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }
    }
}
