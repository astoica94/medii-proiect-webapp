using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class ITask
    {
        public int ID { get; set; }
        [Display(Name = "Priority")]
        public int TaskPriority { get; set; }
        [Display(Name = "Task title")]
        public String TaskName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Due date")]
        public DateTime CreatedDate { get; set; }
        public int AuthorID {get; set;}
        public virtual Author Author { get; set; }
    }
}
