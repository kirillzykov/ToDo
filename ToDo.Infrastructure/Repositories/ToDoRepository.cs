using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.DomainService;
using ToDoApp.Core.Entity.Models;

namespace ToDoApp.Infrastructure.Repositories
{
    public class ToDoRepository : RepositoryBase<ToDo>, IToDoRepository
    {
        readonly ToDoAppContext _ctx;
        public ToDoRepository(ToDoAppContext ctx)
         : base(ctx)
        {
            _ctx = ctx;
        }

        public ToDo CreateToDo(ToDo toDo)
        {
            return Create(toDo);       
        }

        public ToDo DeleteToDo(ToDo toDo)
        {
            return Delete(toDo);
        }

        public List<ToDo> ReadAllToDos()
        {
            return FindAll();
        }

        public ToDo ReadById(ToDo toDo)
        {
            Expression<Func<ToDo, bool>> byId = o => o.Id == toDo.Id;
            return FindByCondition(byId).FirstOrDefault();
        }

        public ToDo UpdateToDo(ToDo toDo)
        {
            return Update(toDo);
        }
    }
}
