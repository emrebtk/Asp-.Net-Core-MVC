using Microsoft.AspNetCore.Mvc;
using Tekrar4.Models.ORM.Context;
using Tekrar4.Models.ORM.Entity;

namespace Tekrar4.Controllers
{
    public class BaseController : Controller
    {
        public KutuphaneContext db;
        public BaseController()
        {
            db = new KutuphaneContext();
        }


        public bool Kategori_Ekle(Kategori model)
        {
            try
            {
                db.Kategoriler.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Kategori_Sil(int id)
        {
            var bul = db.Kategoriler.FirstOrDefault(x => x.ID == id);
            if (bul != null)
            {
                db.Kategoriler.Remove(bul);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Kategori> KategoriListesi()
        {
            return db.Kategoriler.ToList();
        }

        public Kategori KategoriBul(int id)
        {
            return db.Kategoriler.FirstOrDefault(x => x.ID == id);
        }

        public bool Kategori_Duzenle(Kategori model)
        {
            var bul = KategoriBul(model.ID);
            if (bul != null)
            {
                bul.KategoriAdi = model.KategoriAdi;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
