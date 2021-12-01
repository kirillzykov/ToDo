using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.DomainService;
using ToDoApp.Core.Entity.Models;

namespace ToDoApp.Core.ApplicationService.Services
{
    public class ToDoService : IToDoService
    {
        readonly IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        public ToDo Create(ToDo toDo)
        {
            return _toDoRepository.CreateToDo(toDo);
        }

        public ToDo Delete(int id)
        {
            return _toDoRepository.DeleteToDo(new ToDo { Id = id });
        }

        public ToDo FindById(int id)
        {
            return _toDoRepository.ReadById(new ToDo { Id = id });
        }

        public List<ToDo> GetAll()
        {
            return _toDoRepository.ReadAllToDos();
        }

        public ToDo Update(ToDo toDoUpdate)
        {
            return _toDoRepository.UpdateToDo(toDoUpdate);
        }
    }
}
