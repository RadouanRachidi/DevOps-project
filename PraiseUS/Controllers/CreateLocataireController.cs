using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Areas.ALocataire.Pages;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;

namespace PraiseUs.Controllers
{
    public class CreateLocataireController : Controller
    {

        private readonly ApplicationDbContext ctx;

        public CreateLocataireController(ApplicationDbContext ctx)
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
        }
    }
}