using Kurumsal1.Models.ORM.Context;
using Kurumsal1.Models.ORM.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal1.Controllers
{
    public class BaseController : Controller
    {
        public KContext db;
        public BaseController()
        {
            db = new KContext();
        }

        public void Ayarlar()
        {
            var ayarbul = db.Ayarlar.FirstOrDefault();
            ViewBag.SiteAdi = ayarbul.SiteAdi;
            ViewBag.Telefon = ayarbul.Telefon;
            ViewBag.Mail = ayarbul.Mail;
            ViewBag.Adres = ayarbul.Adres;
            ViewBag.SliderListesi = db.Sliderlar.ToList();
            ViewBag.Hakkimizda = ayarbul.Hakkimizda.Substring(0,106);
            ViewBag.Bloglar = db.Bloglar.OrderByDescending(x=>x.ID).Take(3).ToList();
        }

        public List<Slider> Slider_List()
        {
            return db.Sliderlar.ToList();
        }

        public bool Slider_Ekle(Slider model)
        {
            try
            {
                db.Sliderlar.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public Slider Slider_Bul(int id)
        {
            return db.Sliderlar.FirstOrDefault(x => x.ID == id);
        }

        public bool Slider_Duzenle(Slider model)
        {
            try
            {
                var bul = Slider_Bul(model.ID);
                if (model.Icerik != null)
                {
                    bul.Icerik = model.Icerik;
                }

                if (model.Baslik != null)
                {
                    bul.Baslik = model.Baslik;
                }

                if (model.Resim != null)
                {
                    bul.Resim = model.Resim;
                }

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Slider_Sil(int id)
        {
            try
            {
                var bul = Slider_Bul(id);
                db.Sliderlar.Remove(bul);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Blog Blog_Bul(int id)
        {
            return db.Bloglar.FirstOrDefault(x => x.ID == id);
        }

        public List<Blog> Blog_Listesi()
        {
            return db.Bloglar.ToList();
        }

        public bool Blog_Ekle(Blog model)
        {
            try
            {
                model.Tarih = DateTime.Now;
                db.Bloglar.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Blog_Duzenle(Blog model)
        {
            try
            {
                var bul = Blog_Bul(model.ID);
                bul.Baslik = model.Baslik;
                bul.Icerik = model.Icerik;
                bul.Resim = model.Resim;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Blog_Sil(int id)
        {
            try
            {
                var bul = Blog_Bul(id);
                db.Bloglar.Remove(bul);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
