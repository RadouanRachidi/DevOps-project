using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;

namespace PraiseUs.Controllers
{
    public class DetailsLocataireController : Controller
    {

        private readonly ApplicationDbContext _context;

        public IActionResult Details()
        {
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resource = await _context.Locataire
                .FirstOrDefaultAsync(m => m.locataireId == id);
            if (resource == null)
            {
                return NotFound();
            }

            return View(resource);
        }


    }
}