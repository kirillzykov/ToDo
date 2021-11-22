using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Core.Entity.Models
{
    class ToDo : IEntity
    {
        public int Id { get; set; }
        public string Task;
        bool IsComplete;
        DateTime Date;
    }
}
