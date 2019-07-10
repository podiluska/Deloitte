using AutoMapper;
using Deloitte.Todo.Interfaces;
using Deloitte.Todo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Deloitte.Todo.Controllers
{

    [Authorize]
    public class TaskController : Controller
    {
        private readonly ITaskManager _manager;
        private readonly IMapper _mapper;

        public TaskController(ITaskManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        private string CurrentUser()
        {
            var result = this.User.Claims
                .Where(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")
                .Select(c => c.Value)
                .FirstOrDefault();

            return result;
        }


        public IActionResult Index()
        {
            var tasks = _manager.ListTasksForUser(CurrentUser())
                            .Select(t => _mapper.Map<TaskViewModel>(t))
                            .ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new TaskAddViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(TaskAddViewModel model)
        {
            if (_manager.CreateTask(CurrentUser(), model.Description))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Complete(int id)
        {
            _manager.ChangeTaskStatus(CurrentUser(), id, true);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Reset(int id)
        {
            _manager.ChangeTaskStatus(CurrentUser(), id, false);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _manager.DeleteTask(CurrentUser(), id);
            return RedirectToAction(nameof(Index));
        }
    }
}
