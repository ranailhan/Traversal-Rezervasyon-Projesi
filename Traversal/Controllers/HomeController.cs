using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Traversal.Models;

namespace Traversal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index sayfasý çaðrýldý.");
            _logger.LogError("Log error çaðrýldý.");
            return View();
        }

        public IActionResult Privacy()
        {
            DateTime d = DateTime.Now;
            _logger.LogInformation(d+"privacy sayfasý çaðrýldý.");
            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation("Test sayfasý çaðrýlduý");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
