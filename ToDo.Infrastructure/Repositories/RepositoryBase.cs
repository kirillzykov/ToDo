using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.DomainService;
using ToDoApp.Core.Entity;

namespace ToDoApp.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        readonly ToDoAppContext _ctx;
        private DbSet<T> entities;

        public RepositoryBase(ToDoAppContext ctx)
        {
            _ctx = ctx;
            entities = _ctx.Set<T>();
        }
        public T Create(T entity)
        {
            T added = entities.Add(entity).Entity;
            _ctx.SaveChanges();
            return added;
        }

        public T Delete(T entity)
        {           
            T removed = entities.Remove(entity).Entity;
            _ctx.SaveChanges();
            return removed;         
        }

        public T Find(int id)
        {
            return entities.Find(id);
        }

        public List<T> FindAll()
        {
            return entities.ToList();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter)
        {
            return entities.Where(filter);
        }

        public IEnumerable<T> Query(Func<T, bool> filter)
        {
            return entities.Where(filter);
        }

        public T Update(T entity)
        {

            T modified = entities.Update(entity).Entity;
            _ctx.SaveChanges();
            return modified;
        }
    }
}

