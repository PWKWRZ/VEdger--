namespace VEdger.Repository
{
    using System.Collections.Generic;
    public interface IRepository <TEntity>
    {
        /// <summary>
        /// Creates one new entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Create<T>(TEntity entity);

        /// <summary>
        /// Returns entities
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<TEntity> Read<TEntity>();

        /// <summary>
        /// Returns one entity by id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T Read<T>(
            int id);

        /// <summary>
        /// Returns filtered entities
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Read<T>(TEntity parameters);

        /// <summary>
        /// Updates one entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityForUpdate"></param>
        void Update<T>(TEntity entityForUpdate);

        /// <summary>
        /// Deletes one entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityForDeletion"></param>
        void Delete<T>(TEntity entityForDeletion);
    }
}
