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
    public class IndexLocataireModel : PageModel
    {
        /*private readonly PraiseUS.Data.ApplicationDbContext _context;

        public IndexLocataire(PraiseUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Locataire> Locataire { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Locataire != null)
            {
                Locataire = await _context.Locataire.ToListAsync();
            }
        }*/
    }
}
