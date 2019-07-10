using Deloitte.Todo.Data;
using Deloitte.Todo.Interfaces;
using System;
using System.Collections.Generic;

namespace Deloitte.Todo.Logic
{
    public class TaskManager : ITaskManager
    {
        private readonly ITaskRepository _repository;
        private readonly IDateTimeProvider _dateTimeProvider;

        public TaskManager(ITaskRepository taskRepository, IDateTimeProvider dateTimeProvider)
        {
            if (taskRepository == null)
            {
                throw new ArgumentNullException(nameof(taskRepository));
            }
            _repository = taskRepository;
            _dateTimeProvider = dateTimeProvider;
        }

        public IEnumerable<TaskEntity> ListTasksForUser(string userId)
        {
            var tasks = _repository.ListTasksForUser(userId);
            return tasks;
        }

        public bool CreateTask(string userId, string description)
        {
            var task = new TaskEntity()
            {
                UserId = userId,
                Description = description,
                IsComplete = false,
                LastUpdated = _dateTimeProvider.GetCurrentTime(),
            };
            var result = _repository.SaveTask(task);
            return result;
        }

        public bool ChangeTaskStatus(string userId, int taskId, bool isComplete)
        {
            bool result = false;
            var task = _repository.GetTask(taskId, userId);
            if (task != null)
            {
                task.IsComplete = isComplete;
                task.LastUpdated = _dateTimeProvider.GetCurrentTime();
                result = _repository.SaveTask(task);
            }
            return result;
        }

        public bool DeleteTask(string userId, int taskId)
        {
            var result = _repository.DeleteTask(taskId, userId);
            return result;
        }

    }
}
