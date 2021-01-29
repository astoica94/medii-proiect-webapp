using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name = "Author name")]
        public String Name { get; set; }
        public ICollection<ITask> Itasks { get; set; }
    }
}
