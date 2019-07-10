using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Deloitte.Todo.Models
{
    public class TaskViewModel
    {
        [HiddenInput]
        public int TaskId { get; set; }
        public string Description { get; set; }
        [Display(Name = "Is Complete")]
        public bool IsComplete { get; set; }
        [Display(Name = "Last updated")]
        public DateTime LastUpdated { get; set; }

    }
}
