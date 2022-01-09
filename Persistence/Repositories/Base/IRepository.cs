using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        void Create(TEntity entity);
        void CreateAll(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveAll(IEnumerable<TEntity> entities);   

    }
}
