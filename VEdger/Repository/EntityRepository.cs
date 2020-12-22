using System;
using System.Collections.Generic;

namespace VEdger.Repository
{
    public class EntityRepository<T> : IRepository<T>
    {
        public void Create<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entityForDeletion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Read<T>()
        {
            throw new NotImplementedException();
        }

        public T Read<T>(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Read<T>(T parameters)
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entityForUpdate)
        {
            throw new NotImplementedException();
        }
    }
}