namespace VEdger.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using VEdger.Models;

    public class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<TEntity> dbSet;

        public EntityRepository()
        {
            this.context = new ApplicationDbContext();
            this.dbSet = context.Set<TEntity>();
        }

        public void Create<T>(
            TEntity entity)
        {
            this.dbSet.Add(entity);
            context.SaveChangesAsync();
        }

        public void Delete<T>(
            TEntity entityForDeletion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Read<TEntity>()
        {
            var data = this.dbSet.ToList();
            return (IEnumerable<TEntity>)data;
        }

        public T Read<T>(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Read<T>(
            T parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Read<T>(
            TEntity parameters)
        {
            var data = this.dbSet.ToList();
            return data;
        }

        public void Update<T>(
            TEntity entityForUpdate)
        {
            this.dbSet.Attach(entityForUpdate);
            context.Entry(entityForUpdate).State = EntityState.Modified;

            context.SaveChangesAsync();
        }
    }
}