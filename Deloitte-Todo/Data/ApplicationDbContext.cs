using Deloitte.Todo.Data;
using Deloitte.Todo.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Deloitte_Todo.Data
{
    public class ApplicationDbContext : IdentityDbContext, ITaskContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
