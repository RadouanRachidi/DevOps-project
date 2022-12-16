using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;

namespace PraiseUS
{
    public class DeleteModel : PageModel
    {
        private readonly PraiseUS.Data.ApplicationDbContext _context;

        public DeleteModel(PraiseUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Avis Avis { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Avis == null)
            {
                return NotFound();
            }

            var avis = await _context.Avis.FirstOrDefaultAsync(m => m.avisId == id);

            if (avis == null)
            {
                return NotFound();
            }
            else 
            {
                Avis = avis;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Avis == null)
            {
                return NotFound();
            }
            var avis = await _context.Avis.FindAsync(id);

            if (avis != null)
            {
                Avis = avis;
                _context.Avis.Remove(Avis);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
