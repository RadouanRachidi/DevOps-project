using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using NuGet.Protocol.Plugins;
using PraiseUs.Controllers;
using PraiseUS.Data;
using PraiseUS.Models;

namespace PraiseUS.Areas.ALocataire.Pages
{
    public class LocataireCreateModel : PageModel
    {
        private readonly ApplicationDbContext ctx;

        public LocataireCreateModel(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Locataire Locataire { get; set; } = new();

        
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyLocataire = new Locataire();

            if (await TryUpdateModelAsync(emptyLocataire, "Locataire", f => f.nom, f => f.prenom, f => f.nationalite, f => f.dateDeNaissance, f => f.inscriptionDate))
            {
                /*ctx.emptyLocataire.inscriptionDate = new DateTime Now();*/

                ctx.Locataire.Add(emptyLocataire);
                await ctx.SaveChangesAsync();


                return RedirectToPage("/");
            }

            return Page();
        }

    }

}

