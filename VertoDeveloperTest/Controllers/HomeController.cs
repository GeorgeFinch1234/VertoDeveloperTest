using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VertoDeveloperTest.Models;

namespace VertoDeveloperTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly iOTAContext _context;
       

        public HomeController(ILogger<HomeController> logger, iOTAContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           
            return View(_context.Carousels);
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
