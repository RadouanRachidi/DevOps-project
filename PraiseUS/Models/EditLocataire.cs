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

namespace PraiseUS.Models
{
    public class EditLocataireModel : PageModel
    {
        /*private readonly PraiseUS.Data.ApplicationDbContext _context;

        public EditModelLocataire(PraiseUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Locataire Locataire { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Locataire == null)
            {
                return NotFound();
            }

            var locataire =  await _context.Locataire.FirstOrDefaultAsync(m => m.locataireId == id);
            if (locataire == null)
            {
                return NotFound();
            }
            Locataire = locataire;
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

            _context.Attach(Locataire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocataireExists(Locataire.locataireId))
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

        private bool LocataireExists(int id)
        {
          return _context.Locataire.Any(e => e.locataireId == id);
        }*/
    }
}
