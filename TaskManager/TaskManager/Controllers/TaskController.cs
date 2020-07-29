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
    
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
       
        [Route("api/Task/newtask")]
        [HttpPost]
        public async Task<ActionResult<String>> NewTask(TaskItem newtask)
        {
            //Business logic to call task service method
            return null;
        }

        [Route("api/Task/newgroup")]
        [HttpPost]
        public ActionResult<String> NewTaskGroup(TaskGroup newgroup)
        {
            //Business logic to call task service method
            return null;

        }

        [Route("api/Task/edittask")]
        [HttpPost]
        public async Task<ActionResult<long>> EditTask(TaskItem task)
        {
            //Business logic to call task service method
            return null;

        }

        [Route("api/Task/alltask")]
        [HttpPost]
        public  ActionResult<List<TaskItem>> GetAllTask()
        {
            //Business logic to call task service method
            return null;

        }

        [Route("api/Task/dashboard")]
        [HttpPost]
        public async Task<ActionResult<TaskDashboard>> GetTaskDashboard()
        {
            //Business logic to call task service method
            return null;

        }
        [Route("api/Task/allgroups")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<TaskGroup>>> GetAllTaskGroups()
        {
            //Business logic to call task service method
            return null;

        }
    }
}