using Microsoft.AspNetCore.Mvc;
using hepsiburada.Entity;
using hepsiburada.DataAccess;
using hepsiburada.Business;


namespace hepsiburada.UI

{


    public class AdminController : Controller
    {
        public BaseController b = new BaseController();
        public IActionResult Index()
        {
            return View();
        }
        
      
        public IActionResult PcList()
        {
            return View(b.Pc_list());
        }

        public IActionResult PcEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PcEkle(pc veri)
        {
            bool eklendimi = b.Pc_Ekle(veri);
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

        public IActionResult PcDuzenle(int id)
        {
            return View(b.pc_bul(id));
        }

        [HttpPost]
        public IActionResult PcDuzenle(pc veri)
        {
            bool eklendimi = b.Pc_duzenle(veri);
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

        public IActionResult PcSil(int id)
        {
            bool silindimi = b.Pc_Sil(id);
            if (silindimi == true)
            {
                TempData["Durum"] = "Silindi";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Durum"] = "Hata  Silinemedi!";
                return RedirectToAction("Index");
            }
        }
        public IActionResult OemList()
        {
            return View(b.Oem_list());
        }

        public IActionResult OemEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OemEkle(oem veri)
        {
            bool eklendimi = b.Oem_Ekle(veri);
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

        public IActionResult OemDuzenle(int id)
        {
            return View(b.Oem_bul(id));
        }

        [HttpPost]
        public IActionResult OemDuzenle(oem veri)
        {
            bool eklendimi = b.Oem_duzenle(veri);
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

        public IActionResult OemSil(int id)
        {
            bool silindimi = b.Oem_Sil(id);
            if (silindimi == true)
            {
                TempData["Durum"] = " Silindi";
                return RedirectToAction("OemList");
            }
            else
            {
                TempData["Durum"] = "Hata  Silinemedi!";
                return RedirectToAction("OemList");
            }
        }
        public IActionResult PhoneList()
        {
            return View(b.Phone_list());
        }

        public IActionResult PhoneEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PhoneEkle(phone veri)
        {
            bool eklendimi = b.Phone_Ekle(veri);
            if (eklendimi == true)
            {
                return RedirectToAction("PhoneEkle");
            }
            else
            {
                ViewBag.Durum = "Veritabansal bir hata oluştu";
                return View();
            }
        }

        public IActionResult PhoneDuzenle(int id)
        {
            return View(b.Phone_bul(id));
        }

        [HttpPost]
        public IActionResult PhoneDuzenle(phone veri)
        {
            bool eklendimi = b.Phone_duzenle(veri);
            if (eklendimi == true)
            {
                return RedirectToAction("PhoneList");
            }
            else
            {
                ViewBag.Durum = "Veritabansal bir hata oluştu";
                return View();
            }
        }

        public IActionResult PhoneSil(int id)
        {
            bool silindimi = b.Phone_Sil(id);
            if (silindimi == true)
            {
                TempData["Durum"] = " Silindi";
                return RedirectToAction("PhoneList");
            }
            else
            {
                TempData["Durum"] = "Hata  Silinemedi!";
                return RedirectToAction("PhoneList");
            }
        }
        public IActionResult AksList()
        {
            return View(b.Aks_list());
        }

        public IActionResult AksEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AksEkle(aks veri)
        {
            bool eklendimi = b.Aks_Ekle(veri);
            if (eklendimi == true)
            {
                return RedirectToAction("AksList");
            }
            else
            {
                ViewBag.Durum = "Veritabansal bir hata oluştu";
                return View();
            }
        }

        public IActionResult AksDuzenle(int id)
        {
            return View(b.Aks_bul(id));
        }

        [HttpPost]
        public IActionResult AksDuzenle(aks veri)
        {
            bool eklendimi = b.Aks_duzenle(veri);
            if (eklendimi == true)
            {
                return RedirectToAction("AksList");
            }
            else
            {
                ViewBag.Durum = "Veritabansal bir hata oluştu";
                return View();
            }
        }

        public IActionResult AksSil(int id)
        {
            bool silindimi = b.Akst_Sil(id);
            if (silindimi == true)
            {
                TempData["Durum"] = " Silindi";
                return RedirectToAction("AksList");
            }
            else
            {
                TempData["Durum"] = "Hata  Silinemedi!";
                return RedirectToAction("AksList");
            }
        }
    }
}
