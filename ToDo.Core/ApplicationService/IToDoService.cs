using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.Entity.Models;

namespace ToDoApp.Core.ApplicationService
{
    public interface IToDoService
    {
        //Create //POST
        ToDo Create(ToDo product);
        //Read //GET
        ToDo FindById(int id);
        List<ToDo> GetAll();
        //Update //PUT
        ToDo Update(ToDo orderUpdate);

        //Delete //DELETE
        ToDo Delete(int id);
    }
}
