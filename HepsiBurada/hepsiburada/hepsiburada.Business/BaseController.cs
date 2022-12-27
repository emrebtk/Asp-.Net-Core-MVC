using hepsiburada.Entity;
using hepsiburada.DataAccess;
using hepsiburada.Business;

namespace hepsiburada.Business
{
    public class BaseController 
    {
        public HContext db;
        public BaseController()
        {
            db = new HContext();
        }

      
        public bool Pc_Ekle(pc model)
        {
            try
            {
                
                db.pct.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Pc_Sil(int id)
        {
            var bul = db.pct.FirstOrDefault(x => x.id == id);
            if (bul != null)
            {
                db.pct.Remove(bul);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<pc> Pc_list()
        {
            return db.pct.ToList();
        }

        public pc pc_bul(int id)
        {
            return db.pct.FirstOrDefault(x => x.id == id);
        }

        public bool Pc_duzenle(pc m)
        {
            var bul = pc_bul(m.id);
            if (bul != null)
            {
                bul.link=m.link;
                bul.marka=m.marka;
                bul.detail=m.detail;
                bul.model=m.model;
                bul.price=m.price;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Oem_Ekle(oem model)
        {
            try
            {

                db.oemt.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Oem_Sil(int id)
        {
            var bul = db.oemt.FirstOrDefault(x => x.id == id);
            if (bul != null)
            {
                db.oemt.Remove(bul);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<oem> Oem_list()
        {
            return db.oemt.ToList();
        }

        public pc Oem_bul(int id)
        {
            return db.pct.FirstOrDefault(x => x.id == id);
        }

        public bool Oem_duzenle(oem m)
        {
            var bul = Oem_bul(m.id);
            if (bul != null)
            {
                bul.link = m.link;
                bul.marka = m.marka;
                bul.detail = m.detail;
                bul.model = m.model;
                bul.price = m.price;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Aks_Ekle(aks model)
        {
            try
            {

                db.akst.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Akst_Sil(int id)
        {
            var bul = db.akst.FirstOrDefault(x => x.id == id);
            if (bul != null)
            {
                db.akst.Remove(bul);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<aks> Aks_list()
        {
            return db.akst.ToList();
        }

        public pc Aks_bul(int id)
        {
            return db.pct.FirstOrDefault(x => x.id == id);
        }

        public bool Aks_duzenle(aks m)
        {
            var bul = Aks_bul(m.id);
            if (bul != null)
            {
                bul.link = m.link;
                bul.marka = m.marka;
                bul.detail = m.detail;
                bul.model = m.model;
                bul.price = m.price;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Phone_Ekle(phone model)
        {
            try
            {

                db.phonet.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Phone_Sil(int id)
        {
            var bul = db.phonet.FirstOrDefault(x => x.id == id);
            if (bul != null)
            {
                db.phonet.Remove(bul);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<phone> Phone_list()
        {
            return db.phonet.ToList();
        }

        public phone Phone_bul(int id)
        {
            return db.phonet.FirstOrDefault(x => x.id == id);
        }

        public bool Phone_duzenle(phone m)
        {
            var bul = Phone_bul(m.id);
            if (bul != null)
            {
                bul.link = m.link;
                bul.marka = m.marka;
                bul.detail = m.detail;
                bul.model = m.model;
                bul.price = m.price;    
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Sepet_Sil(int id)
        {
            var bul = db.Sepett.FirstOrDefault(x => x.id == id);
            if (bul != null)
            {
                db.Sepett.Remove(bul);
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
