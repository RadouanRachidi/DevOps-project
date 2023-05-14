using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Construction;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PraiseUs.Controllers
{
    public class EditLocataireController : Controller
    {
        private readonly ApplicationDbContext ctx;

        public EditLocataireController(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<ActionResult> Edit(int id)
        {
            List<Locataire> locataires = await ctx.Locataire.ToListAsync();

            Locataire locataire = locataires.FirstOrDefault(e => e.locataireId == id);

            return View(locataire);
        }

        //Récupere pas les données et ne met pas à jour
        [HttpPost]
        public async Task<IActionResult> Edit(Locataire locataire)
        {
            Locataire loc = ctx.Locataire.Where(id => id.locataireId == locataire.locataireId).FirstOrDefault();
            loc.nom = locataire.nom;
            loc.prenom = locataire.prenom;
            loc.nationalite = locataire.nationalite;
            
            ctx.Locataire.Update(loc);
            ctx.SaveChanges();

            return View(loc);
        }

    }
}