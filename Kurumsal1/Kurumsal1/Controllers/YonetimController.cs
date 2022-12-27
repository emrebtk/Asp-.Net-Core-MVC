using Kurumsal1.Models.ORM.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal1.Controllers
{
    public class YonetimController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SliderListesi()
        {
            return View(Slider_List());
        }

        public IActionResult SliderEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SliderEkle(Slider model)
        {
            bool kontrol = Slider_Ekle(model);
            if (kontrol == true)
            {
                return RedirectToAction("SliderListesi");
            }
            else
            {
                ViewBag.Durum = "Veritabansal Bir Hata Oluştu";
                return View();
            }
        }

        public IActionResult SliderDuzenle(int id)
        {
            return View(Slider_Bul(id));
        }
        [HttpPost]
        public IActionResult SliderDuzenle(Slider model)
        {
            var kontrol = Slider_Duzenle(model);
            if (kontrol == true)
            {
                return RedirectToAction("SliderListesi");
            }
            else
            {
                ViewBag.Durum = "Veritabansal Bir Hata Oluştu";
                return View();
            }
        }

        public IActionResult SliderSil(int id)
        {
            var kontrol = Slider_Sil(id);
            if (kontrol == true)
            {
                return RedirectToAction("SliderListesi");
            }
            else
            {
                TempData["Durum"] = "Slider Silinemedi!";
                return RedirectToAction("SliderListesi");
            }
        }

        public IActionResult Bloglar()
        {
            return View(Blog_Listesi());
        }

        public IActionResult BlogEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BlogEkle(Blog model)
        {
            var kontrol = Blog_Ekle(model);
            if (kontrol == true)
            {
                return RedirectToAction("Bloglar");
            }
            else
            {
                ViewBag.Durum = "Veritabansal bir hata oluştu";
                return View();
            }
        }

        public IActionResult BlogDuzenle(int id)
        {
            return View(Blog_Bul(id));
        }

        [HttpPost]
        public IActionResult BlogDuzenle(Blog model)
        {
            var kontrol = Blog_Duzenle(model);
            if (kontrol == true)
            {
                return RedirectToAction("Bloglar");
            }
            else
            {
                ViewBag.Durum = "Veritabansal bir hata oluştu";
                return View();
            }
        }

        public IActionResult BlogSil(int id)
        {
            var kontrol = Blog_Sil(id);
            if (kontrol == true)
            {
                return RedirectToAction("Bloglar");
            }
            else
            {
                TempData["Durum"] = "Veritabansal bir hata oluştu";
                return RedirectToAction("Bloglar");
            }
        }


        public IActionResult HakkimizdaDuzenle()
        {
            return View(db.Ayarlar.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult HakkimizdaDuzenle(Ayarlar model)
        {
            try
            {
                var bul = db.Ayarlar.FirstOrDefault();
                bul.Hakkimizda = model.Hakkimizda;
                db.SaveChanges();
                ViewBag.Durum = "1";
                return View();
            }
            catch (Exception)
            {
                ViewBag.Durum = "2";
                return View();
            }
        }
    }
}
