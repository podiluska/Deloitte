using Deloitte.Todo.Data;
using System.Collections.Generic;

namespace Deloitte.Todo.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<TaskEntity> ListTasksForUser(string userId);

        TaskEntity GetTask (int taskId, string userId);
        bool SaveTask(TaskEntity task);

        bool DeleteTask(int taskId, string userId);
    }
}
