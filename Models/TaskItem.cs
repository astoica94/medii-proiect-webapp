using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
    public class TaskItem
    {
        public int ID { get; set; }
        public int ITaskID { get; set; }
        [Display(Name = "Parent task")]
        public ITask ITask { get; set; }
        [Display(Name = "Sub task item text")]
        public String TaskText { get; set; }
        [Display(Name = "Completed?")]
        public Boolean TaskDone { get; set; }
    }
}
