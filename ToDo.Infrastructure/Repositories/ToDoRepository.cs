using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.DomainService;
using ToDoApp.Core.Entity.Models;

namespace ToDoApp.Infrastructure.Repositories
{
    class ToDoRepository : RepositoryBase<ToDo>, IToDoRepository
    {
        public ToDo CreateToDo(ToDo toDo)
        {
            throw new NotImplementedException();
        }

        public ToDo DeleteToDo(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDo> ReadAllToDos()
        {
            throw new NotImplementedException();
        }

        public ToDo ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public ToDo UpdateToDo(ToDo toDoUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
