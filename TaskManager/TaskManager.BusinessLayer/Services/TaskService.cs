using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BusinessLayer.Interface;
using TaskManager.DataLayer;
using TaskManager.Entities;
using TaskStatus = TaskManager.Entities.TaskStatus;

namespace TaskManager.BusinessLayer.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMongoDBContext _mongoDBContext;
        private readonly IMongoCollection<TaskItem> _mongoCollection;

        private readonly IMongoCollection<TaskGroup> _mongoCollectionGroup;
        public TaskService(IMongoDBContext mongoDBContext)
        {
            _mongoDBContext = mongoDBContext;
            _mongoCollection = _mongoDBContext.GetCollection<TaskItem>(typeof(TaskItem).Name);
            _mongoCollectionGroup = _mongoDBContext.GetCollection<TaskGroup>(typeof(TaskGroup).Name);

        }
        public long EditTask(TaskItem task)
        {
            //MongoDB logic to update task into database
            return 0;
        }

        public List<TaskItem> GetAllTask()
        {
            //MongoDB logic to retrieve all task from database, Implement try catche block
            return null;
        }
            public List<TaskGroup> GetAllTaskGroup()
        {
            //MongoDB logic to retrieve all task group from database, Implement try catche block
            return null;
        }

        public TaskDashboard GetDashboard()
        {
            //MongoDB logic to retrieve all task, all groups, pending task and completed task from database, Implement try catche block
            return null;
        }

        public string NewTask(TaskItem newtask)
        {
            //MongoDB logic to insert new task into database, Implement try catche block
            return null;
        }

        public string NewTaskGroup(TaskGroup taskGroup)
        {
            //MongoDB logic to insert new task group into database, Implement try catche block
            return null;
        }
    }
}
