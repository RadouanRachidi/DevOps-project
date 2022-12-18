using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;

namespace PraiseUS.Models
{
    public class DetailsModelLocataire : PageModel
    {
        private readonly PraiseUS.Data.ApplicationDbContext _context;

        public DetailsModelLocataire(PraiseUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Locataire Locataire { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Locataire == null)
            {
                return NotFound();
            }

            var locataire = await _context.Locataire.FirstOrDefaultAsync(m => m.locataireId == id);
            if (locataire == null)
            {
                return NotFound();
            }
            else 
            {
                Locataire = locataire;
            }
            return Page();
        }
    }
}
