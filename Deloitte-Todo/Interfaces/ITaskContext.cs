using Deloitte.Todo.Data;
using Microsoft.EntityFrameworkCore;

namespace Deloitte.Todo.Interfaces
{
    public interface ITaskContext
    {
        int SaveChanges();
        DbSet<TaskEntity> Tasks { get; set; }
    }
}
