using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList.Business.Abstract;
using TodoList.Entities.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TaskListController : Controller
    {
        private readonly ITaskListService _taskListService;

        public TaskListController(ITaskListService taskListService)
        {
            _taskListService = taskListService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            try
            {
                var result = _taskListService.GetAllTasks();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            
        }

        [HttpPost("add")]
        public IActionResult AddTask([FromBody]TaskAddDTO taskAdd)
        {
            try
            {
                _taskListService.AddTodoList(taskAdd);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
           
        }
    }
}

