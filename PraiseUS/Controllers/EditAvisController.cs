using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;

namespace PraiseUs.Controllers
{
    public class EditAvisController : Controller
    {

        private readonly ApplicationDbContext _context;

        public IActionResult Edit()
        {
            return View();
        }


    }
}