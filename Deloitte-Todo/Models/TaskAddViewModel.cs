using System.ComponentModel.DataAnnotations;

namespace Deloitte.Todo.Models
{
    public class TaskAddViewModel
    {
        [Required()]
        public string Description { get; set; }

    }
}
