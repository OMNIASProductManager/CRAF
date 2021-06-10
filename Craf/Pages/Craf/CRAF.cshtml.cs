using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Facilityz.Data;
using Facilityz.Models;

namespace Facilityz.Pages.Craf
{
    public class CRAFModel : PageModel
    {
        private readonly Facilityz.Data.FacilityzContext _context;

        public CRAFModel(Facilityz.Data.FacilityzContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "UserId", "UserId");
            return Page();
        }

        [BindProperty]
        public Models.Craf Craf { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Craf.Add(Craf);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Menu/Menu");
        }
    }
}