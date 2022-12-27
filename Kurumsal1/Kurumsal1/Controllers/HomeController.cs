using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kurumsal1.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Ayarlar();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult BlogDetay(int id)
        {
            Ayarlar();
            var bul = Blog_Bul(id);
            bul.OkunmaSayisi++;
            db.SaveChanges();
            return View(bul);
        }

        public IActionResult Bloglar()
        {
            Ayarlar();
            return View(Blog_Listesi());
        }
    }
}