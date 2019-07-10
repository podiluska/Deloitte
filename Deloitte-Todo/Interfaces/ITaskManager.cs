using System.Collections.Generic;
using Deloitte.Todo.Data;

namespace Deloitte.Todo.Interfaces
{
    public interface ITaskManager
    {
        bool ChangeTaskStatus(string userId, int taskId, bool isComplete);
        bool CreateTask(string userId, string description);
        bool DeleteTask(string userId, int taskId);
        IEnumerable<TaskEntity> ListTasksForUser(string userId);        
    }
}