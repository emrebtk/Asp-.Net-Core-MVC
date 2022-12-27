
using hepsiburada.Entity;
using hepsiburada.DataAccess;
using hepsiburada.Business;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace hepsiburada.UI
{
    public class HomeController :Controller

    {
        
        public BaseController bs = new BaseController();
                  
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public void ayarlar()
        {
            
            var sepetim = bs.db.Sepett.ToList();
            ViewBag.Sepet = sepetim;
        }
        public IActionResult Index()
        {
            ayarlar();
            return View();
        }  public IActionResult Sepet()
        {
            ayarlar();
            return View(bs.db.Sepett.ToList());
        }
      
        public IActionResult SepeteEkle(int id)
        {
            ayarlar();
            var bul = bs.db.pct.FirstOrDefault(x => x.id == id);
            ViewBag.Bul = bul;
            
          
            try
            {
                
                 
                    var spt = new Sepet() { name = bul.marka, fiyat = bul.price, miktar =1 };
                  
                    bs.db.Sepett.Add(spt);
                    

                    bs.db.SaveChanges();
                
                



                return RedirectToAction("Sepet");
            }
            catch (Exception)
            {
                
                return RedirectToAction("Bilgisayar");
            }
        }

        public IActionResult Bilgisayar()
        {
            ayarlar();
            return View(bs.Pc_list());
        }
        public IActionResult Oem()
        {
            ayarlar();
            return View(bs.Oem_list());
        }
        public IActionResult Phone()
        {
            ayarlar();
            return View(bs.Phone_list());
        }
        public IActionResult Aks()
        {
            ayarlar();
            return View(bs.Aks_list());
        }
        public IActionResult Privacy()
        {
            ayarlar();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
     
        public IActionResult SepetSil(int id)
        {
            bool silindimi = bs.Sepet_Sil(id);
            if (silindimi == true)
            {
                TempData["Durum"] = " Silindi";
                return RedirectToAction("Sepet");
            }
            else
            {
                TempData["Durum"] = "Hata  Silinemedi!";
                return RedirectToAction("Sepet");
            }
        }
    }
}