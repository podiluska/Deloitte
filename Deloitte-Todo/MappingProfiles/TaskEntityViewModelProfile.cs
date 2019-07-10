using AutoMapper;
using Deloitte.Todo.Data;
using Deloitte.Todo.Models;

namespace Deloitte.Todo.MappingProfiles
{
    public class TaskEntityViewModelProfile : Profile
    {
        public TaskEntityViewModelProfile()
        {
            CreateMap<TaskEntity, TaskViewModel>();
        }
    }
}
