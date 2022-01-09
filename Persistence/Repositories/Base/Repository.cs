using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly QuoteContext _context;

        public Repository(QuoteContext context)
        {
            _context = context;
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void CreateAll(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public TEntity Get(int Id)
        {
            return _context.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveAll(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
