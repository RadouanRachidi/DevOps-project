using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PraiseUS.Data;
using PraiseUS.Models;

namespace PraiseUS.Models
{
    public class CreateModelLocataire : PageModel
    {
        private readonly PraiseUS.Data.ApplicationDbContext _context;

        public CreateModelLocataire(PraiseUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Locataire Locataire { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Locataire.Add(Locataire);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
