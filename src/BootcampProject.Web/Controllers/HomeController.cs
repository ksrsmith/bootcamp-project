using System.Diagnostics;
using BootcampProject.Web.Models;
using BootcampProject.Web.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;

namespace BootcampProject.Web.Controllers
{
    public class HomeController(BootcampProjectContext context) : Controller
    {
        private readonly BootcampProjectContext _context = context;

        public IActionResult Index()
        {
            string recipeNames = string.Join(", ", _context.Recipes.Select(r => r.Name).ToList());

            ViewBag.Recipes = recipeNames;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
