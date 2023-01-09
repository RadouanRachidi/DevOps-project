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

        /* public IndexLocataiteController(ApplicationDbContext ctx)
         {
             this.ctx = ctx;
         }

         //GET: Home
         public ActionResult Index()
         {
             return View();
         }

         [HttpPost]
         public ActionResult Index(Locataire locataire)
         {
             string nom = locataire.nom;
             string prenom = locataire.prenom;
             string nationalite = locataire.nationalite;
             DateTime dateNaissance = locataire.dateDeNaissance;
             DateTime dateInscription = locataire.inscriptionDate;

             ctx.Locataire.Add(locataire);
             ctx.SaveChanges();

             return View();
         }*/

        public async Task<IActionResult> Delete(int id)
        {
            // This would select the beer and pass it ingithub
            // to the view as the view's model.
            // Brewer should also be populated for this beer.
            //var beer = _brewerRepository.GetBy(brewerId).Beers.FirstOrDefault(e => e.BeerId == id);
            //locataires.Remove(locataires.FirstOrDefault());

            List<Locataire> locataires = await ctx.Locataire.ToListAsync();

            ctx.Entry(locataires.FirstOrDefault(e => e.locataireId == id)).State = EntityState.Deleted;
            

            ctx.SaveChanges();
            return View(locataires);
        }

    }
}