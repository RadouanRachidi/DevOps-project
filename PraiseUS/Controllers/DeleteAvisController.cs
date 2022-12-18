using Microsoft.AspNetCore.Mvc;
using PraiseUS.Models;
using System.Diagnostics;

namespace PraiseUs.Controllers
{
    public class DeleteAvisController : Controller
    {
        public IActionResult DeleteAvis()
        {
            return View();
        }

    }
}