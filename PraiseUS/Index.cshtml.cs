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
    public class IndexModel : PageModel
    {
        private readonly PraiseUS.Data.ApplicationDbContext _context;

        public IndexModel(PraiseUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Avis> Avis { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Avis != null)
            {
                Avis = await _context.Avis.ToListAsync();
            }
        }
    }
}
