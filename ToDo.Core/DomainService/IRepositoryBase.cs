using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Core.DomainService
{
    public interface IRepositoryBase<T> where T : class
    {
        T Find(int id);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        List<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter);
        IEnumerable<T> Query(Func<T, bool> filter);
    }
}
