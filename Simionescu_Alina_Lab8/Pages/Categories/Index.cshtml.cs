using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Simionescu_Alina_Lab8.Data;
using Simionescu_Alina_Lab8.Models;

namespace Simionescu_Alina_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Simionescu_Alina_Lab8.Data.Simionescu_Alina_Lab8Context _context;

        public IndexModel(Simionescu_Alina_Lab8.Data.Simionescu_Alina_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
