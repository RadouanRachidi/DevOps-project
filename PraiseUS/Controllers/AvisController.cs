using Microsoft.AspNetCore.Mvc;
using PraiseUS.Models;
using System.Diagnostics;

namespace PraiseUs.Controllers
{
    public class AvisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

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