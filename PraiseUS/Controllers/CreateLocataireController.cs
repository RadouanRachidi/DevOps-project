using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Areas.ALocataire.Pages;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace PraiseUs.Controllers
{
    public class CreateLocataireController : Controller
    {

        private readonly ApplicationDbContext ctx;

        public CreateLocataireController(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Locataire locataire)
        {
            bool isExisting = ctx.Locataire.Any(u =>
                u.nom == locataire.nom &&
                u.prenom == locataire.prenom &&
                u.nationalite == locataire.nationalite &&
                u.dateDeNaissance == locataire.dateDeNaissance);

            if (isExisting)
            {
                return BadRequest("Ce compte existe déjà.");
            }

            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            string nom = locataire.nom;
            string prenom = locataire.prenom;
            string nationalite = locataire.nationalite;
            DateTime dateNaissance = locataire.dateDeNaissance;
            locataire.inscriptionDate = DateTime.Today;
            locataire.Id_Users = userId;
            ctx.Locataire.Add(locataire);
            ctx.SaveChanges();

            return View();
        }
    }
}