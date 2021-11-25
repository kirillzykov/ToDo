using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Core.DomainService
{
    public interface IRepositoryBase<T>
    {
        T Find(object id);
        object Create(T entity);
        bool Update(T entity);
        bool Delete(object id);
        List<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter);
        IEnumerable<T> Query();
        IEnumerable<T> Query(Expression<Func<T, bool>> filter);
    }
}
