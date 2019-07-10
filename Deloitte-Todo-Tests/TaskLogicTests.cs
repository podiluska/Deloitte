using Deloitte.Todo.Data;
using Deloitte.Todo.Interfaces;
using Deloitte.Todo.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace Deloitte_Todo_Tests
{
    [TestClass]
    public class TaskLogicTests
    {
        private readonly MockRepository _mockFactory = new MockRepository(MockBehavior.Strict);

        [TestMethod]
        public void TaskManager_Requires_A_Repository()
        {
            ITaskManager target;

            try
            {
                target = new TaskManager(null, null);
                Assert.Fail("No exception was not generated");
            }
            catch (ArgumentNullException ex)
            {
            }
            catch
            {
                Assert.Fail("Expected exception was not generated");
            }
        }

        [TestMethod]
        public void ListTasksForUser_Lists_Tasks_From_Repository()
        {
            var userId = "201";
            var tasks = new List<TaskEntity>()
            {
                new TaskEntity(){ TaskId = 101, Description = "task a", IsComplete = false, UserId = "201", LastUpdated = DateTime.Now.AddMinutes(-20) },
                new TaskEntity(){ TaskId = 102, Description = "task b", IsComplete = true, UserId = "201", LastUpdated = DateTime.Now.AddMinutes(-40) },
                new TaskEntity(){ TaskId = 103, Description = "task c", IsComplete = false, UserId = "201", LastUpdated = DateTime.Now.AddMinutes(-30) },
            };
            var repository = _mockFactory.Create<ITaskRepository>();
            repository.Setup(r => r.ListTasksForUser(It.Is<string>(s => s == userId))).Returns(tasks);

            var target = new TaskManager(repository.Object, null);

            var result = target.ListTasksForUser(userId);

            Assert.AreEqual(tasks, result);
            repository.VerifyAll();
        }

        [TestMethod]
        public void CreateTask_Creates_A_Task()
        {
            var userId = "202";
            var description = "New task name";
            var now = new DateTime(2019, 4, 22, 11, 9, 18);
            var dateTimeProvider = _mockFactory.Create<IDateTimeProvider>();
            dateTimeProvider.Setup(d => d.GetCurrentTime()).Returns(now);

            var repository = _mockFactory.Create<ITaskRepository>();
            repository.Setup(r => r.SaveTask(It.Is<TaskEntity>(
                    t => t.UserId == userId
                    && t.TaskId == 0
                    && t.Description == description
                    && t.LastUpdated == now
                    && t.IsComplete == false
                ))).Returns(true);
            var target = new TaskManager(repository.Object, dateTimeProvider.Object);
            var result = target.CreateTask(userId, description);

            Assert.IsTrue(result);

            dateTimeProvider.VerifyAll();
            repository.VerifyAll();

        }

        [TestMethod]
        public void ChangeTaskStatus_Completes_A_Task()
        {
            var taskId = 103;
            var userId = "203";
            var task = new TaskEntity()
            {
                TaskId = taskId,
                UserId = userId,
                IsComplete = false,
                Description = "description",
                LastUpdated = DateTime.Now,
            };
            var now = new DateTime(2019, 5, 17, 13, 24, 9);
            var dateTimeProvider = _mockFactory.Create<IDateTimeProvider>();
            dateTimeProvider.Setup(d => d.GetCurrentTime()).Returns(now);

            var repository = _mockFactory.Create<ITaskRepository>();
            repository.Setup(r => r.GetTask(It.Is<int>(i => i == taskId), It.Is<string>(s => s == userId))).Returns(task);
            repository.Setup(r => r.SaveTask(It.Is<TaskEntity>(
                    t => t.TaskId == taskId
                    && t.UserId == userId
                    && t.IsComplete
                    && t.Description == "description"
                    && t.LastUpdated == now
                ))).Returns(true);

            var target = new TaskManager(repository.Object, dateTimeProvider.Object);
            var result = target.ChangeTaskStatus(userId, taskId, true);


            Assert.IsTrue(result);

            dateTimeProvider.VerifyAll();
            repository.VerifyAll();
        }

        [TestMethod]
        public void ChangeTaskStatus_Uncompletes_A_Task()
        {
            var taskId = 104;
            var userId = "204";
            var task = new TaskEntity()
            {
                TaskId = taskId,
                UserId = userId,
                IsComplete = true,
                Description = "description",
                LastUpdated = DateTime.Now,
            };
            var now = new DateTime(2019, 1, 14, 1, 59, 39);
            var dateTimeProvider = _mockFactory.Create<IDateTimeProvider>();
            dateTimeProvider.Setup(d => d.GetCurrentTime()).Returns(now);

            var repository = _mockFactory.Create<ITaskRepository>();
            repository.Setup(r => r.GetTask(It.Is<int>(i => i == taskId), It.Is<string>(s => s == userId))).Returns(task);
            repository.Setup(r => r.SaveTask(It.Is<TaskEntity>(
                    t => t.TaskId == taskId
                    && t.UserId == userId
                    && !t.IsComplete
                    && t.Description == "description"
                    && t.LastUpdated == now
                ))).Returns(true);

            var target = new TaskManager(repository.Object, dateTimeProvider.Object);
            var result = target.ChangeTaskStatus(userId, taskId, false);

            Assert.IsTrue(result);

            dateTimeProvider.VerifyAll();
            repository.VerifyAll();
        }

        [TestMethod]
        public void ChangeTaskStatus_Fails_When_Task_Not_Found()
        {
            var taskId = 105;
            var userId = "205";
            var repository = _mockFactory.Create<ITaskRepository>();
            repository.Setup(r => r.GetTask(It.Is<int>(i => i == taskId), It.Is<string>(s => s == userId))).Returns((TaskEntity)null);

            var target = new TaskManager(repository.Object, null);
            var result = target.ChangeTaskStatus(userId, taskId, true);

            Assert.IsFalse(result);
            repository.VerifyAll();
        }

        [TestMethod]
        public void DeleteTask_Deletes_A_Task()
        {
            var taskId = 106;
            var userId = "206";

            var repository = _mockFactory.Create<ITaskRepository>();
            repository.Setup(r => r.DeleteTask(It.Is<int>(i => i == taskId), It.Is<string>(s => s == userId))).Returns(true);

            var target = new TaskManager(repository.Object, null);
            var result = target.DeleteTask(userId, taskId);

            Assert.IsTrue(result);
            repository.VerifyAll();
        }
    }
}
