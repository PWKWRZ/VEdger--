using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEdger.Repository
{
    public interface IRepository <T>
    {
        /// <summary>
        /// Creates one new entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Create<T>(T entity);

        /// <summary>
        /// Returns entities
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<T> Read<T>();

        /// <summary>
        /// Returns one entity by id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T Read<T>(int id);

        /// <summary>
        /// Returns filtered entities
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IEnumerable<T> Read<T>(T parameters);

        /// <summary>
        /// Updates one entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityForUpdate"></param>
        void Update<T>(T entityForUpdate);

        /// <summary>
        /// Deletes one entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityForDeletion"></param>
        void Delete<T>(T entityForDeletion);
    }
}
