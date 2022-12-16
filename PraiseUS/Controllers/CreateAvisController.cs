using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;

namespace PraiseUs.Controllers
{
    public class CreateAvisController : Controller
    {

        private readonly ApplicationDbContext _context;

        /*public IActionResult Create()
        {
            return View();
        }*/

        /***********************************************/
        public IActionResult OnGet()
        {
            return View();
        }

        [BindProperty]
        public Avis Avis { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> Create(Avis avis)
        {
            /*if (!ModelState.IsValid)
            {
                return View();
            }
                */

            Locataire user1 = new Locataire();
            user1.locataireId = 1;
            user1.nom = "YcfAdmin";
            user1.prenom = "YcfAdmin";
            user1.nationalite = "Français";
            user1.dateDeNaissance = new DateTime (2001/19/12);
            user1.inscriptionDate = new DateTime (2022/19/12);

            avis.locataire = user1;

            _context.Avis.Add(avis);
            await _context.SaveChangesAsync();

            return RedirectToPage("/");
        }

            /***********************************************/

            public IActionResult My_Avis()
        {
            return View();
        }

        public IActionResult New_Avis()
        {
            return View();
        }

    }
}