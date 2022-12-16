using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;

namespace PraiseUS
{
    public class EditModel : PageModel
    {
        private readonly PraiseUS.Data.ApplicationDbContext _context;

        public EditModel(PraiseUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Avis Avis { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Avis == null)
            {
                return NotFound();
            }

            var avis =  await _context.Avis.FirstOrDefaultAsync(m => m.avisId == id);
            if (avis == null)
            {
                return NotFound();
            }
            Avis = avis;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Avis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvisExists(Avis.avisId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AvisExists(int id)
        {
          return _context.Avis.Any(e => e.avisId == id);
        }
    }
}
