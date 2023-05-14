using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Areas.ALocataire.Pages;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;

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
            List<Locataire> locataires = await ctx.Locataire.ToListAsync();

            return View(locataires);

        }

        public async Task<IActionResult> Delete(int id)
        {

            List<Locataire> locataires = await ctx.Locataire.ToListAsync();

            ctx.Entry(locataires.FirstOrDefault(e => e.locataireId == id)).State = EntityState.Deleted;
            
            ctx.SaveChanges();
            return View(locataires);
        }

    }
}