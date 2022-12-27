using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tekrar4.Models.ORM.Entity;

namespace Tekrar4.Controllers
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
            return View(KategoriListesi());
        }

        public IActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KategoriEkle(Kategori veri)
        {
            bool eklendimi = Kategori_Ekle(veri);
            if (eklendimi == true)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Durum = "Veritabansal bir hata oluştu";
                return View();
            }
        }

        public IActionResult KategoriDuzenle(int id)
        {
            return View(KategoriBul(id));
        }

        [HttpPost]
        public IActionResult KategoriDuzenle(Kategori veri)
        {
            bool eklendimi = Kategori_Duzenle(veri);
            if (eklendimi == true)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Durum = "Veritabansal bir hata oluştu";
                return View();
            }
        }

        public IActionResult KategoriSil(int id)
        {
            bool silindimi = Kategori_Sil(id);
            if (silindimi == true)
            {
                TempData["Durum"] = "Kategori Silindi";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Durum"] = "Hata Kategori Silinemedi!";
                return RedirectToAction("Index");
            }
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


    }
}