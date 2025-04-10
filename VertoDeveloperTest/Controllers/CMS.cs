using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VertoDeveloperTest.Models;
using static System.Net.Mime.MediaTypeNames;
using VertoDeveloperTest.Models;
using System.Diagnostics.Eventing.Reader;

namespace VertoDeveloperTest.Controllers
{
    public class CMS : Controller
    {
        private readonly iOTAContext _context;
        public CMS(iOTAContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Carousels);
        }
        public IActionResult Upload(IFormFile image, String title, Validator validator)
        {
            ViewData["ErrorMessage"] = "";
            String test = validator.ValidateTitle(title);

            if (test == "")
            {
                test = validator.ValidateImage(image);
            }

            if (test == "") { 
            MemoryStream stream = new MemoryStream();
            image.CopyTo(stream);
            Byte[] data = stream.ToArray();
            Carousel carousel = new Carousel();
            carousel.Img = data;
            carousel.Title = title;


            _context.Add(carousel);
            _context.SaveChanges();
            return View("Index");
            }
            else
            {
                ViewData["ErrorMessage"] = test;
                return View("Create");
            }

        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
