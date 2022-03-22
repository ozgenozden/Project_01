using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext :DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var _context=new TContext())
            {
                var addedEntry=_context.Entry(entity);
                addedEntry.State=EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var _context = new TContext())
            {
                var deletedEntry = _context.Entry(entity);
                deletedEntry.State=EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var _context = new TContext())
            {
              return  _context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll()
        {
            using (var _context = new TContext())
            {
                return _context.Set<TEntity>().ToList();
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var _context = new TContext())
            {
               
                return filter==null?_context.Set<TEntity>().ToList():_context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var _context = new TContext())
            {
                var updatedEntity = _context.Entry(entity);
                updatedEntity.State=EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
