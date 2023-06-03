using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Areas.ALocataire.Pages;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace PraiseUs.Controllers
{
    public class IndexLocataireController : Controller
    {

        private readonly ApplicationDbContext ctx;
        public IndexLocataireController(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

     
        public async Task<IActionResult> Index()
        {
            //List<Locataire> locataires = await ctx.Locataire.ToListAsync();

            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            List<Locataire> locataires = await ctx.Locataire
                .Where(l => l.Id_Users == userId)
                .ToListAsync();

            return View(locataires);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            List<Locataire> locataires = await ctx.Locataire.ToListAsync();

            if (id == null)
            {
                return BadRequest();
            }

            int locataireId = id.Value;

            await ctx.Database.ExecuteSqlInterpolatedAsync($"EXEC SupprimerFicheLocataire {locataireId}");

            return View(locataires);
        }

    }
}