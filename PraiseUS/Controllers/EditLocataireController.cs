using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Construction;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;
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

        public ActionResult Edit()
        {
            return View();
        }

       /* [HttpGet]
        public ActionResult Edit(int locataireid)
        {
            *//*string nom = locataire.nom;
            string prenom = locataire.prenom;
            string nationalite = locataire.nationalite;
            DateTime dateNaissance = locataire.dateDeNaissance;
            DateTime dateInscription = locataire.inscriptionDate;*//*

            if (await TryUpdateModelAsync(locataireToUpdate, "locataire", f => f.Name, f => f.Description, f => f.Price))
            {
                await ctx.SaveChangesAsync();

                return RedirectToPage("./Index");
            }

            ctx.Locataire.Update(locataire);
            ctx.SaveChanges();

            return View();
        }*/

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var LocataireToUpdate = await ctx.Locataire
                .FirstOrDefaultAsync(f => f.locataireId == id);

            if (LocataireToUpdate == null)
                return NotFound();


            if (await TryUpdateModelAsync(LocataireToUpdate, "locataire", f => f.nom, f => f.prenom, f => f.nationalite))
            {
                await ctx.SaveChangesAsync();

                return RedirectToPage("/");
            }

            return View();
        }

        /*private readonly ApplicationDbContext ctx;

        public EditLocataireController(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        [BindProperty]
        public Locataire Locataire { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Locataire = await ctx.Locataire
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.locataireId == id);

            if (Locataire == null)
                return NotFound();

            return View();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var LocataireToUpdate = await ctx.Locataire
                .FirstOrDefaultAsync(f => f.locataireId == id);

            if (LocataireToUpdate == null)
                return NotFound();


            if (await TryUpdateModelAsync(LocataireToUpdate, "locataire", f => f.nom, f => f.prenom, f => f.nationalite))
            {
                await ctx.SaveChangesAsync();

                return RedirectToPage("/");
            }

            return View();
        }

        private bool FruitExists(int id)
        {
            return ctx.Locataire.Any(e => e.locataireId == id);
        }*/

    }
}