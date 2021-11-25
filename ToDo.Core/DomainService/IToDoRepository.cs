﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.Entity.Models;           

namespace ToDoApp.Core.DomainService
{
    public interface IToDoRepository
    {
        ToDo CreateToDo(ToDo toDo);
        ToDo ReadById(int id);
        List<ToDo> ReadAllToDos();
        ToDo UpdateToDo(ToDo toDoUpdate);
        ToDo DeleteToDo(int id);
    }
}
