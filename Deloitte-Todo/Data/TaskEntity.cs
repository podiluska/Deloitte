using System;
using System.ComponentModel.DataAnnotations;

namespace Deloitte.Todo.Data
{
    public class TaskEntity
    {      
        [Key]
        public int TaskId { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
