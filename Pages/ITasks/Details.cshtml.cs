using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.ITasks
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication1.Data.WebApplication1Context _context;

        public DetailsModel(WebApplication1.Data.WebApplication1Context context)
        {
            _context = context;
        }

        public List<TaskItem> TaskItems { get; set; }
        public ITask ITask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ITask = await _context.ITask.FirstOrDefaultAsync(m => m.ID == id);

            TaskItems = await _context.TaskItem.Where(subtask => subtask.ITaskID == id).ToListAsync();

            if (ITask == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
