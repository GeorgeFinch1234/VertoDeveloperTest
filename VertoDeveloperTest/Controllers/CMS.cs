using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using VertoDeveloperTest.Models;

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
            return View();
        }
        public IActionResult Create(IFormFile image, String title)
        {

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
