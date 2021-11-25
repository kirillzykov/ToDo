using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.DomainService;

namespace ToDoApp.Infrastructure.Repositories
{
    class RepositoryBase<T> : IRepositoryBase<T>
    {
        public object Create(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public T Find(object id)
        {
            throw new NotImplementedException();
        }

        public List<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
