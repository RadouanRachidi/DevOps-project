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
    public class DetailsModel : PageModel
    {
        private readonly PraiseUS.Data.ApplicationDbContext _context;

        public DetailsModel(PraiseUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
