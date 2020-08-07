using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.BusinessLayer.Interface;
using TaskManager.Entities;

namespace TaskManager.Service.Controllers
{
    [Route("api/Task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        /// <summary>
        /// private reference of type ITaskService
        /// </summary>
        private readonly ITaskService _taskService;

        /// <summary>
        /// Injecting object of type ITaskService 
        /// </summary>
        /// <param name="taskService"></param>
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        /// <summary>
        /// post api to create new task 
        /// </summary>
        /// <param name="newtask"></param>
        /// <returns></returns>
        [Route("newtask")]
        [HttpPost]
        public async Task<ActionResult<String>> NewTask(TaskItem newtask)
        {
            //business logic goes here
            throw new NotImplementedException();

        }
        /// <summary>
        /// post api to create task group
        /// </summary>
        /// <param name="newgroup"></param>
        /// <returns></returns>
        [Route("newgroup")]
        [HttpPost]
        public async Task<ActionResult<String>> NewTaskGroup(TaskGroup newgroup)
        {
            //business logic goes here
            throw new NotImplementedException();
        }
        /// <summary>
        /// post api to update task 
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        [Route("edittask")]
        [HttpPut]
        public async Task<ActionResult<long>> EditTask(TaskItem task)
        {
            //business logic goes here
            throw new NotImplementedException();

        }
        /// <summary>
        /// post api to retrieve all task 
        /// </summary>
        /// <returns></returns>
        [Route("alltask")]
        [HttpGet]
        public async Task< ActionResult<List<TaskItem>>> GetAllTask()
        {
            //business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        /// post api to retrieve all task dashboard
        /// </summary>
        /// <returns></returns>
        [Route("dashboard")]
        [HttpGet]
        public async Task<ActionResult<TaskDashboard>> GetTaskDashboard()
        {
            //business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        /// post api to retrieve all task groups
        /// </summary>
        /// <returns></returns>
        [Route("allgroups")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskGroup>>> GetAllTaskGroups()
        {
            //business logic goes here
            throw new NotImplementedException();

        }
    }
}
