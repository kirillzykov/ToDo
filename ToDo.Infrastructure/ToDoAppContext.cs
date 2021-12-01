using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using ToDoApp.Core.Entity.Models;

namespace ToDoApp.Infrastructure
{
    public class ToDoAppContext: DbContext
    {
        public ToDoAppContext(DbContextOptions<ToDoAppContext> opt)
            : base(opt) 
        {

        }
  
        public DbSet<ToDo> ToDos { get; set; }
    }
}
