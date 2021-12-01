using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Core.ApplicationService;
using ToDoApp.Core.Entity.Models;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : Controller
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        // GET api/todo -- READ All
        [HttpGet]
        public ActionResult<List<ToDo>> Get()
        {
            try
            {
                return Ok(_toDoService.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/todo/5 -- READ By Id
        [HttpGet("{id}")]
        public ActionResult<ToDo> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");

            try
            {
                return Ok(_toDoService.FindById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/todo -- CREATE
        [HttpPost]
        public ActionResult<ToDo> Post([FromBody] ToDo toDo)
        {
            try
            {
                return Ok(_toDoService.Create(toDo));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // PUT api/todo/5 -- Update
        [HttpPut("{id}")]
        public ActionResult<ToDo> Put(int id, [FromBody] ToDo toDo)
        {
            if (id < 1 || id != toDo.Id)
            {
                return BadRequest("Parameter Id and product ID must be the same");
            }

            try
            {
                return Ok(_toDoService.Update(toDo));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/todo/5
        [HttpDelete("{id}")]
        public ActionResult<ToDo> Delete(int id)
        {
            try
            {
                return Ok(_toDoService.Delete(id));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
