using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;

namespace PraiseUs.Controllers
{
    public class IndexAvisController : Controller
    {

        private readonly ApplicationDbContext _context;

        public IActionResult Index()
        {
            return View();
        }


    }
}