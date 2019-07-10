using Deloitte.Todo.Data;
using Deloitte.Todo.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Deloitte.Todo.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ITaskContext _taskContext;

        public TaskRepository(ITaskContext taskContext)
        {
            _taskContext = taskContext;
        }

        public bool DeleteTask(int taskId, string userId)
        {
            var result = false;
            var taskToDelete = _taskContext.Tasks.Where(t => t.TaskId == taskId && t.UserId == userId).FirstOrDefault();
            if (taskToDelete != null)
            {
                _taskContext.Tasks.Remove(taskToDelete);
                _taskContext.SaveChanges();
                result = true;
            }
            return result;            
        }

        public TaskEntity GetTask(int taskId, string userId)
        {
            var task = _taskContext.Tasks.FirstOrDefault(t => t.TaskId == taskId && t.UserId == userId);
            return task;
        }

        public IEnumerable<TaskEntity> ListTasksForUser(string userId)
        {
            var tasks = _taskContext.Tasks
                .Where(t => t.UserId == userId)
                .ToList();

            return tasks;
        }

        public bool SaveTask(TaskEntity task)
        {
            if (task.TaskId == 0)
            {
                _taskContext.Tasks.Add(task);
            }
            else
            {
                _taskContext.Tasks.Update(task);
            }
            _taskContext.SaveChanges();
            return true;
        }
    }
}
